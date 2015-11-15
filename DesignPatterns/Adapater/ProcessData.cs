using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater
{
    public class ProcessData
    {
        private readonly IDataReader _dataReader;

        public ProcessData(IDataReader dataReader)
        {
            _dataReader = dataReader;
        }

        public int processDataReader()
        {
            int rowCount = _dataReader.GetRowCount();
            Console.WriteLine("Row count {0}", rowCount);
            int alphaCount = _dataReader.GetWordCount();
            Console.WriteLine("Alpha count {0}", alphaCount);
            return rowCount+alphaCount;
        }
    }
}
