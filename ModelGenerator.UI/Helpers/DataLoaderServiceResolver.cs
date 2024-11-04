using ModelGenerator.UI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Helpers
{
    public class DataLoaderServiceResolver
    {
        public delegate IDataLoaderRepository ServiceResolver(DataLoaderService key);
    }

    public enum DataLoaderService
    {
        PostgreSQL,
        SQLServer
    }
}
