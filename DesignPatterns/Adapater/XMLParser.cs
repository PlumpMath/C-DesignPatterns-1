using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Adapater
{
    public class XMLParser : IXMLParser
    {
        private readonly string _xmlFile;
        private string[] _values;
        private string[] _elements;

        public XMLParser(string xmlFile)
        {
            _xmlFile = xmlFile;
            processXml();
        }

        public string[] GetValues()
        {
            return _values;
        }
        public string[] GetElements()
        {
            return _elements;
        }

        private void processXml()
        {
            XmlReader xReader = XmlReader.Create(_xmlFile);
            List<string> dataElements = new List<string>();
            List<string> dataValues = new List<string>();
            while (xReader.Read())
            {
                switch (xReader.NodeType)
                {
                    case XmlNodeType.Text:
                        dataValues.Add(xReader.Value);
                        break;
                    case XmlNodeType.Element:
                        dataElements.Add(xReader.Value);
                        break;
                    default:
                        break;
                }
            }
            _elements = dataElements.ToArray();
            _values = dataValues.ToArray();
        }
    }
}
