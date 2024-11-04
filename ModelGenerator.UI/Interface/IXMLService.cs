using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Interface
{
    public interface IXMLService
    {
        void Write();
        string GetValues(string condition = null);
    }
}
