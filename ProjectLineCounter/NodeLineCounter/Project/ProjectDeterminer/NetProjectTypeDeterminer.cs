using System;
using System.Linq;
using System.Xml;

namespace ProjectLineCounter {
    public class NetProjectTypeDeterminer : IProjectTypeDeterminer<ProjectType, XmlNode> {
        public ProjectType DetermineType(XmlNode document) {
            XmlNode outputTypeNode = document.SelectSingleNode("Project/PropertyGroup/OutputType");

            if (outputTypeNode == null || outputTypeNode.InnerText == "Library") return ProjectType.ClassLibrary;
            if (outputTypeNode.InnerText == "WinExe") return ProjectType.DesktopApplication;
            if (outputTypeNode.InnerText == "Exe") {
                XmlNode targetFrameworkNode = document.SelectSingleNode("Project/PropertyGroup/TargetFramework");

                if (targetFrameworkNode != null &&
                    new string[] { "net5.0-windows", "net6.0-windows" }.Contains(targetFrameworkNode.InnerText)) {
                    
                    return ProjectType.DesktopApplication;
                }

                return ProjectType.ConsoleApplication;
            }

            return ProjectType.Unknown;
        }
    }
}
