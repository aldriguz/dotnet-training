using System.IO;
using System.Xml;

namespace XmlDocumentProcessor
{    
    internal class XmlProcessor
    {
        private readonly XmlDocument _xmlDocument;
        public XmlProcessor(string file)
        {
            if (File.Exists(file))
                throw new FileNotFoundException();

            _xmlDocument = new XmlDocument();
            _xmlDocument.LoadXml(file);
        }

        public void Process()
        {

        }
    }
}
