using System.Xml;
using System.Xml.Serialization;
using XmlReaderProcessor;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Settings for reader
XmlReaderSettings settings = new XmlReaderSettings();
settings.IgnoreWhitespace = true;
settings.ConformanceLevel = ConformanceLevel.Fragment;

// Reading the file
using XmlReader reader = XmlReader.Create("Files/XmlAttributes.xml", settings);
XmlSerializer serializer = new XmlSerializer(typeof(XmlSerializer));

while (reader.Read())
{
    Console.Write(new string(' ', reader.Depth * 2)); // Write indentation
    Console.Write(reader.NodeType.ToString());

    if (reader.NodeType == XmlNodeType.Element || reader.NodeType == XmlNodeType.EndElement)
    {
        Console.Write(" Name=" + reader.Name);
    }
    else if (reader.NodeType == XmlNodeType.Text)
    {
        Console.Write(" Value=" + reader.Value);
    }

    if(reader.NodeType == XmlNodeType.Element && reader.Name == "Message1")
    {
        ReadingAttributes.ReadAttributesFromReader(reader);
    }
    Console.WriteLine();
}

Console.ReadLine();

/*
XmlNode node = new XmlNode();
reader.MoveToContent();
var data = reader.ReadElementContentAsString();
reader.ReadStartElement("catalog");
XmlElement element;
XmlNode node;
XmlAttribute atribute;
*/