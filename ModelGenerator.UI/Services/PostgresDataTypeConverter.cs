using ModelGenerator.UI.Interface;
using System;
using System.Collections.Generic;

namespace ModelGenerator.UI.Services
{
    public class PostgresDataTypeConverter : IDataTypeConverter
    {
        private static readonly Dictionary<Type, string> TypeAliases = new Dictionary<Type, string>
        {
            { typeof(bool), "bool" },
            { typeof(byte), "byte" },
            { typeof(sbyte), "sbyte" },
            { typeof(short), "short" },
            { typeof(ushort), "ushort" },
            { typeof(int), "int" },
            { typeof(uint), "uint" },
            { typeof(long), "long" },
            { typeof(ulong), "ulong" },
            { typeof(float), "float" },
            { typeof(double), "double" },
            { typeof(decimal), "decimal" },
            { typeof(string), "string" },
            { typeof(char), "char" },
            { typeof(object), "object" },
            { typeof(Guid), "Guid" },
            { typeof(DateTime), "DateTime" },
            { typeof(TimeSpan), "TimeSpan" },
            { typeof(byte[]), "byte[]" }
        };

        public string Convert(string dbDataType)
        {
            string output = "";

            if (dbDataType == "boolean")
                output = TypeAliases[typeof(bool)];
            else if (dbDataType == "smallint")
                output = TypeAliases[typeof(short)];
            else if (dbDataType == "integer")
                output = TypeAliases[typeof(int)];
            else if (dbDataType == "bigint")
                output = TypeAliases[typeof(long)];
            else if (dbDataType == "real")
                output = TypeAliases[typeof(float)];
            else if (dbDataType == "double precision")
                output = TypeAliases[typeof(double)];
            else if (dbDataType == "numeric" || dbDataType == "money")
                output = TypeAliases[typeof(decimal)];
            else if (dbDataType == "text" || dbDataType == "character varying" || dbDataType == "character" || dbDataType == "citext" || dbDataType == "json" || dbDataType == "jsonb" || dbDataType == "xml")
                output = TypeAliases[typeof(string)];
            else if (dbDataType == "uuid")
                output = TypeAliases[typeof(Guid)];
            else if (dbDataType == "bytea")
                output = TypeAliases[typeof(byte[])];
            else if (dbDataType == "timestamp without time zone" || dbDataType == "timestamp with time zone" || dbDataType == "date")
                output = TypeAliases[typeof(DateTime)];
            else if (dbDataType == "time without time zone")
                output = TypeAliases[typeof(TimeSpan)] + " or TimeOnly (6.0+)";
            else if (dbDataType == "time with time zone")
                output = TypeAliases[typeof(DateTimeOffset)];
            else if (dbDataType == "interval")
                output = TypeAliases[typeof(TimeSpan)];
            else
                output = "Unknown type";

            return output;
        }
    }
}
