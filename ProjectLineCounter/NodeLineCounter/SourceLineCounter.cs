using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectLineCounter {
    public class SourceLineCounter : INodeLineCounter {
        public event LineCountEventHandler ProjectScanned;
        public delegate void LineCountEventHandler(object sender, LineCountEventArgs args);

        public SourceLineCounter() {

        }

        public ItemLineCount Count(string sourceDirectory) {
            var fileCache = new HashSet<string>(Directory.GetFiles(sourceDirectory, "*.cs", SearchOption.AllDirectories));

            string[] projectFiles = Directory.GetFiles(sourceDirectory, "*.csproj", SearchOption.AllDirectories);
            LineCountEventArgs args = new LineCountEventArgs(projectFiles.Length);
            IList<ItemLineCount> projects = ScanProjects(projectFiles, CreateSolutionLineCounter(fileCache), args);

            DirectoryLineCount directoryLineCount = CreateSolutionDirectory(sourceDirectory, projects);

            CountAllFileCache(fileCache, directoryLineCount);

            return directoryLineCount;
        }

        private IList<ItemLineCount> ScanProjects(string[] projectFiles, INodeLineCounter solutionLineCounter, LineCountEventArgs args) {
            List<ItemLineCount> projects = new List<ItemLineCount>(projectFiles.Length);
            foreach (string solutionProjectFile in projectFiles) {
                string projectDirectory = Path.GetDirectoryName(solutionProjectFile);

                projects.Add(solutionLineCounter.Count(projectDirectory));

                args.CurrentScannedProjects++;
                ProjectScanned.Invoke(this, args);
            }

            return projects;
        }
        private DirectoryLineCount CreateSolutionDirectory(string sourceDirectory, IList<ItemLineCount> projects) {
            DirectoryLineCount directoryLineCount = new DirectoryLineCount(sourceDirectory, NodeType.Collection);

            var solutionDirectories = new HashSet<string>(Directory.GetFiles(sourceDirectory, "*.sln", SearchOption.AllDirectories).Select(x => Path.GetDirectoryName(x)));
            var solutions = new Dictionary<string, DirectoryLineCount>(solutionDirectories.Count);

            foreach (var project in projects) {
                string projectDirectory = Path.GetDirectoryName(project.Path);

                if (!solutions.TryGetValue(projectDirectory, out DirectoryLineCount solution)) {
                    if (!solutionDirectories.Contains(projectDirectory)) {
                        project.Parent = directoryLineCount;
                        directoryLineCount.Items.Add(project);
                    } else {
                        solution = new DirectoryLineCount(projectDirectory, NodeType.Solution);
                        solution.Parent = directoryLineCount;

                        project.Parent = solution;
                        solution.Items.Add(project);

                        solutions.Add(projectDirectory, solution);
                        directoryLineCount.Items.Add(solution);
                    }
                } else {
                    project.Parent = solution;
                    solution.Items.Add(project);
                }
            }

            return directoryLineCount;
        }
        private void CountAllFileCache(ISet<string> fileCache, DirectoryLineCount directory) {
            INodeValidator validator = new FileValidator();
            INodeLineCounter fileLineCounter = new FileLineCounter();

            foreach (var csFile in fileCache) {
                if (!validator.IsValid(csFile)) continue;

                ItemLineCount file = fileLineCounter.Count(csFile);
                file.Parent = directory;

                directory.Items.Add(file);
            }
        }

        protected virtual INodeLineCounter CreateSolutionLineCounter(ISet<string> fileCache) {
            NetProjectLineCounter netProject = new NetProjectLineCounter();
            netProject.DirectoryValidator = new NodeCacheValidator(netProject.DirectoryValidator, fileCache, true);
            netProject.FileValidator = new NodeCacheValidator(netProject.FileValidator, fileCache, false);

            FrameworkProjectLineCounter frameworkProject = new FrameworkProjectLineCounter();
            frameworkProject.DirectoryValidator = new NodeCacheValidator(frameworkProject.DirectoryValidator, fileCache, true);
            frameworkProject.FileValidator = new NodeCacheValidator(frameworkProject.FileValidator, fileCache, false);

            ProjectLineCounter projectCounter = new ProjectLineCounter() {
                NetProjectLineCounter = netProject,
                FrameworkProjectLineCounter = frameworkProject
            };

            return new SolutionLineCounter() {
                ProjectLineCounter = projectCounter
            };
        }
    }
}
