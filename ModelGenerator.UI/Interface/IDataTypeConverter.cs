using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Interface
{
    public interface IDataTypeConverter
    {
        string Convert(string dbDataType);
    }
}
