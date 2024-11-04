using ModelGenerator.UI.Class;
using ModelGenerator.UI.Interface;
using ModelGenerator.UI.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelGenerator.UI.DataAccess
{
    public class PostgreSQLDataLoader : IDataLoaderRepository
    {
        private readonly IDBInit dbInit;

        public PostgreSQLDataLoader(IDBInit dbInit)
        {
            this.dbInit = dbInit;
        }

        public async Task<IEnumerable<ColumnModel>> GetColumns(string schema, string table)
        {
            try
            {
                return await Task.Run(async () =>
                {
                    var output = new List<ColumnModel>();
                    dbInit.OpenConnection();
                    string query = $@"SELECT * FROM information_schema.""columns"" WHERE ""table_schema"" = '{schema}' AND ""table_name"" = '{table}'";
                    using (var command = new NpgsqlCommand(query, (NpgsqlConnection)DataCommunication.DatabaseConnection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                output.Add(new ColumnModel
                                {
                                    ColumnName = reader["column_name"].ToString(),
                                    ColumnDataType = reader["data_type"].ToString()
                                });
                            }
                        }
                    }

                    dbInit.DisposeConnection();
                    return output;
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<string>> GetSchemas()
        {
            try
            {
                return await Task.Run(async () =>
                {
                    var output = new List<string>();
                    dbInit.OpenConnection();
                    string query = "SELECT * FROM information_schema.schemata";
                    using (var command = new NpgsqlCommand(query, (NpgsqlConnection)DataCommunication.DatabaseConnection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                output.Add(reader["schema_name"].ToString());
                            }
                        }
                    }

                    dbInit.DisposeConnection();
                    return output;
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<string>> GetTables(string schema)
        {
            try
            {
                return await Task.Run(async () =>
                {
                    var output = new List<string>();
                    dbInit.OpenConnection();
                    string query = @"SELECT * FROM information_schema.""tables"" WHERE ""table_schema"" = '" + schema + "'";
                    using (var command = new NpgsqlCommand(query, (NpgsqlConnection)DataCommunication.DatabaseConnection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                output.Add(reader["table_name"].ToString());
                            }
                        }
                    }

                    dbInit.DisposeConnection();
                    return output;
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
