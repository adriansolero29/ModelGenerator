using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Class
{
    public sealed class DataCommunication
    {
        public static IDbConnection DatabaseConnection { get; set; }
        public static string DatabaseType { get; set; }
        public static string ServerName { get; set; }
        public static string PortNumber { get; set; }
        public static string DatabaseName { get; set; }
        public static string UserId { get; set; }
        public static string Password { get; set; }
    }
}
