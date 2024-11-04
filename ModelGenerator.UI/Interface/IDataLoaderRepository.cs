using ModelGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Interface
{
    public interface IDataLoaderRepository
    {
        Task<IEnumerable<string>> GetSchemas();
        Task<IEnumerable<string>> GetTables(string schema);
        Task<IEnumerable<ColumnModel>> GetColumns(string schema, string table);
    }
}
