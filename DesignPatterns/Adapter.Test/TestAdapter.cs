using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Adapater;

namespace Adapter.Test
{
    [TestFixture]
    public class TestAdapter
    {
        [Test]
        public void TestFileCount()
        {
            StreamDataReader streamDataReader = new StreamDataReader(@"C:/Temp/TestData.txt");
            ProcessData p = new ProcessData(streamDataReader);

            Assert.AreEqual(13, p.processDataReader());
        }

        [Test]
        public void TestXmlCount()
        {
            XmlAdapterClass adpXml = new XmlAdapterClass(@"C:/Temp/TestData.xml");
            ProcessData p = new ProcessData(adpXml);

            Assert.AreEqual(7, p.processDataReader());
        }
    }
}
