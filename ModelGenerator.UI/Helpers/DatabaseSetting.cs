using ModelGenerator.UI.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGenerator.UI.Helpers
{
    public static class DatabaseSetting
    {
        public static bool CheckDatabaseSetting()
        {
            if (
                string.IsNullOrEmpty(DataCommunication.ServerName) ||
                string.IsNullOrEmpty(DataCommunication.PortNumber) ||
                string.IsNullOrEmpty(DataCommunication.UserId) ||
                string.IsNullOrEmpty(DataCommunication.Password) ||
                string.IsNullOrEmpty(DataCommunication.DatabaseName)
            )
            {
                return false;
            }

            return true;
        }
    }
}
