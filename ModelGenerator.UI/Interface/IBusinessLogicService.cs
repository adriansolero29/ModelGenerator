using ModelGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Interface
{
    public interface IBusinessLogicService
    {
        Task<IEnumerable<string>> SchemaList();
        Task<IEnumerable<string>> TableList(string schemaName);
        Task<IEnumerable<ColumnModel>> ColumnList(string schemaName, string tableName);
    }
}
