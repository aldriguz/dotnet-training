using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlReaderProcessor
{
    public static class ReadingAttributes
    {
        public static void ReadAttributesFromReader(XmlReader reader)
        {
            Console.Write(" Name=" + reader.Name);
        }
    }
}
