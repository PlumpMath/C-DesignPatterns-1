using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater
{
    public class StreamDataReader : IDataReader
    {
        private readonly string _filePath;

        public StreamDataReader(string filePath)
        {
            _filePath = filePath;
        }
        public int GetWordCount()
        {
            string data = File.ReadAllText(_filePath,Encoding.UTF8);
            char[] seperator = { ' ', '\n', '\t' };
            string[] words = data.Split(seperator);
            return words.Count();
        }

        public int GetRowCount()
        {
            string[] lines = File.ReadAllLines(_filePath);
            return lines.Count();
        }
    }
}
