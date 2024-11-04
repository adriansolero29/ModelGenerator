using ModelGenerator.UI.Class;
using ModelGenerator.UI.Interface;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelGenerator.UI.Services
{
    public class PostgreSQLConnection : IDBInit
    {
        public void DisposeConnection()
        {
            try
            {
                DataCommunication.DatabaseConnection.Close();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void InitializeConnection()
        {
            NpgsqlConnectionStringBuilder cnBuilder = new NpgsqlConnectionStringBuilder();
            cnBuilder["Server"] = DataCommunication.ServerName;
            cnBuilder["Port"] = DataCommunication.PortNumber;
            cnBuilder["Database"] = DataCommunication.DatabaseName;
            cnBuilder["UserId"] = DataCommunication.UserId;
            cnBuilder["Password"] = DataCommunication.Password;

            DataCommunication.DatabaseConnection = new NpgsqlConnection(cnBuilder.ConnectionString);
        }

        public void OpenConnection()
        {
            try
            {
                DataCommunication.DatabaseConnection.Open();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
