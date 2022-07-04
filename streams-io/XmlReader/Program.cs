using System.Xml;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Settings for reader
XmlReaderSettings settings = new XmlReaderSettings();
settings.IgnoreWhitespace = true;
settings.ConformanceLevel = ConformanceLevel.Fragment;

// Reading the file
using XmlReader reader = XmlReader.Create("XMLFile1.xml", settings);

reader.MoveToContent();
reader.ReadStartElement("catalog");

XmlElement element;
XmlNode node;
XmlAttribute atribute;
