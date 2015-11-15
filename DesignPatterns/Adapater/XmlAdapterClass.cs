using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater
{
    public class XmlAdapterClass : IDataReader
    {
        private readonly string _xmlFilePath;
        private readonly XMLParser xmlParser;

        public XmlAdapterClass(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            xmlParser = new XMLParser(_xmlFilePath);
        }

        public int GetWordCount()
        {
            return xmlParser.GetElements().Count();
        }

        public int GetRowCount()
        {
            return xmlParser.GetValues().Count();
        }
    }
}
