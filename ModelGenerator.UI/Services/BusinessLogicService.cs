using ModelGenerator.UI.Interface;
using ModelGenerator.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static ModelGenerator.UI.Enums.Enums;
using static ModelGenerator.UI.Helpers.ServiceResolvers;

namespace ModelGenerator.UI.Services
{
    public class BusinessLogicService : IBusinessLogicService
    {
        private readonly IDataLoaderRepository dataLoaderRepo;
        
        public BusinessLogicService(ServiceResolver dataLoaderService)
        {
            dataLoaderRepo = dataLoaderService(DataLoaderService.PostgreSQL);
        }

        public async Task<IEnumerable<ColumnModel>> ColumnList(string schemaName, string tableName)
        {
            return await dataLoaderRepo.GetColumns(schemaName, tableName);
        }

        public async Task<IEnumerable<string>> SchemaList()
        {
            return await dataLoaderRepo.GetSchemas();
        }

        public async Task<IEnumerable<string>> TableList(string schemaName)
        {
            return await dataLoaderRepo.GetTables(schemaName);
        }
    }
}
