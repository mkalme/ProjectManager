using System;

namespace ProjectLineCounter {
    public class ProjectLineCounter : INodeLineCounter {
        public IProjectTypeDeterminer<(ProjectType, FrameworkType), string> ProjectTypeDeterminer { get; set; }
        public INodeLineCounter NetProjectLineCounter { get; set; }
        public INodeLineCounter FrameworkProjectLineCounter { get; set; }

        public ProjectLineCounter() {
            ProjectTypeDeterminer = new ProjectTypeDeterminer();
            NetProjectLineCounter = new NetProjectLineCounter();
            FrameworkProjectLineCounter = new FrameworkProjectLineCounter();
        }

        public ItemLineCount Count(string projectDirectory) {
            (ProjectType projectType, FrameworkType framework) = ProjectTypeDeterminer.DetermineType(projectDirectory);

            ProjectLineCount projectLineCount;
            switch (framework) {
                case FrameworkType.Framework:
                    projectLineCount = FrameworkProjectLineCounter.Count(projectDirectory) as ProjectLineCount;
                    break;
                case FrameworkType.Net:
                default:
                    projectLineCount = NetProjectLineCounter.Count(projectDirectory) as ProjectLineCount;
                    break;
            }
            projectLineCount.ProjectType = projectType;
            
            return projectLineCount;
        }
    }
}
