using System;
using System.IO;
using System.Xml;

namespace ProjectLineCounter {
    public class ProjectTypeDeterminer : IProjectTypeDeterminer<(ProjectType, FrameworkType), string> {
        public IProjectTypeDeterminer<FrameworkType, XmlNode> ProjectFrameworkDeterminer { get; set; }

        public IProjectTypeDeterminer<ProjectType, XmlNode> NetProjectTypeDeterminer { get; set; }
        public IProjectTypeDeterminer<ProjectType, XmlDocument> FrameworkProjectTypeDeterminer { get; set; }

        public ProjectTypeDeterminer() {
            ProjectFrameworkDeterminer = new ProjectFrameworkDeterminer();

            NetProjectTypeDeterminer = new NetProjectTypeDeterminer();
            FrameworkProjectTypeDeterminer = new FrameworkProjectTypeDeterminer();
        }

        public (ProjectType, FrameworkType) DetermineType(string projectDirectory) {
            string csprojFile = $"{projectDirectory}\\{Path.GetFileName(projectDirectory)}.csproj";

            ProjectType projectType = ProjectType.Unknown;
            FrameworkType framework = FrameworkType.Net;

            if (File.Exists(csprojFile)) {
                var xmlReader = new XmlTextReader(File.OpenRead(csprojFile));
                xmlReader.Namespaces = false;

                XmlDocument document = new XmlDocument();
                document.Load(xmlReader);

                framework = ProjectFrameworkDeterminer.DetermineType(document);
                switch (framework) {
                    case FrameworkType.Net:
                        projectType = NetProjectTypeDeterminer.DetermineType(document);
                        break;
                    case FrameworkType.Framework:
                        projectType = FrameworkProjectTypeDeterminer.DetermineType(document);
                        break;
                }

            }
            return (projectType, framework);
        }
    }
}
