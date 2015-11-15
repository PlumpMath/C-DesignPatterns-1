using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapater
{
    public interface IXMLParser
    {
        string[] GetValues();

        string[] GetElements();
    }
}
