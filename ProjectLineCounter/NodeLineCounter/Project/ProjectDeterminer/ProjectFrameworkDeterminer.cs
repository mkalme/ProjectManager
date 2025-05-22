using System;
using System.Xml;

namespace ProjectLineCounter {
    public class ProjectFrameworkDeterminer : IProjectTypeDeterminer<FrameworkType, XmlNode> {
        public FrameworkType DetermineType(XmlNode document) {
            if (document.SelectSingleNode("Project/PropertyGroup/TargetFrameworkVersion") == null) {
                return FrameworkType.Net;
            }

            return FrameworkType.Framework;
        }
    }
}
