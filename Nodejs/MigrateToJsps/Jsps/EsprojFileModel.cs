﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MigrateToJsps
{
    [XmlRoot(ElementName = "Project")]
    public class EsprojFile
    {
        [XmlAttribute(AttributeName = "Sdk")]
        public string Sdk = @"Microsoft.VisualStudio.JavaScript.Sdk/0.5.85-alpha";

        [XmlElement(ElementName = "PropertyGroup")]
        public EsprojPropertyGroup PropertyGroup { get; set; }
    }

    [XmlRoot(ElementName = "PropertyGroup")]
    public class EsprojPropertyGroup
    {
        [XmlAnyElement("BuildCommandComment")]
        public XmlComment BuildCommandComment = new XmlDocument().CreateComment("Command to run on project build");

        [XmlElement(ElementName = "BuildCommand", IsNullable = false)]
        public string BuildCommand;

        [XmlAnyElement("CleanCommandComment")]
        public XmlComment CleanCommandComment = new XmlDocument().CreateComment("Command to run on project clean");

        [XmlElement(ElementName = "CleanCommand", IsNullable = false)]
        public string CleanCommand;

        [XmlElement(ElementName = "StartupCommand", IsNullable = false)]
        public string StartupCommand;
    }
}
