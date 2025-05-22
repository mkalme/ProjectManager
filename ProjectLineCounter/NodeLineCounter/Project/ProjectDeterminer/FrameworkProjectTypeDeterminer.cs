using System;
using System.Xml;

namespace ProjectLineCounter {
    public class FrameworkProjectTypeDeterminer : IProjectTypeDeterminer<ProjectType, XmlDocument> {
        public ProjectType DetermineType(XmlDocument document) {
            XmlNode outputTypeNode = document.SelectSingleNode("Project/PropertyGroup/OutputType");

            if (outputTypeNode != null) {
                string innerText = outputTypeNode.InnerText;

                if (innerText == "WinExe") return ProjectType.DesktopApplication;
                if (innerText == "Library") return ProjectType.ClassLibrary;
                if (innerText == "Exe") return ProjectType.ConsoleApplication;
            }

            return ProjectType.Unknown;
        }
    }
}
