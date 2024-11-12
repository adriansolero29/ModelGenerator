using ModelGenerator.UI.Class;
using ModelGenerator.UI.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ModelGenerator.UI.Enums.Enums;
using static ModelGenerator.UI.Helpers.ServiceResolvers;

namespace ModelGenerator.UI.Views
{
    public partial class DatabaseSettingSetupWindow : Form
    {
        private readonly IDBInit dbInitialize;
        private readonly IXMLDatabaseSetting xmlDatabaseSetting;
        private readonly IXMLService xmlService;

        public DatabaseSettingSetupWindow(IDBInit dbInitialize, IXMLDatabaseSetting xmlDatabaseSetting, ServiceResolverXML xMLServiceResolver)
        {
            InitializeComponent();
            this.dbInitialize = dbInitialize;
            this.xmlDatabaseSetting = xmlDatabaseSetting;
            this.xmlService = xMLServiceResolver(XMLService.XMLDatabaseSetting);

            xmlService.GetValues();
            Init();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Init()
        {
            var databaseTypes = new List<string>()
            {
                "PostgreSQL",
            };

            DatabaseTypes.DataSource = databaseTypes;

            DatabaseTypes.SelectedItem = DataCommunication.DatabaseType;
            ServerName.Text = DataCommunication.ServerName;
            PortNumber.Text = DataCommunication.PortNumber;
            UserId.Text = DataCommunication.UserId;
            Password.Text = DataCommunication.Password;
            DatabaseName.Text = DataCommunication.DatabaseName;
        }

        private void DatabaseTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DatabaseTypes.SelectedItem?.ToString() == "PostgreSQL")
            {
                dbInitialize.InitializeConnection();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataCommunication.DatabaseType = DatabaseTypes.SelectedItem.ToString();
            DataCommunication.DatabaseName = DatabaseName.Text;
            DataCommunication.ServerName = ServerName.Text;
            DataCommunication.PortNumber = PortNumber.Text;
            DataCommunication.UserId = UserId.Text;
            DataCommunication.Password = Password.Text;

            xmlDatabaseSetting.ChangeDatabaseSetting();
            MessageBox.Show("Setting saved! Application will now restart");
            Application.Restart();
        }
    }
}
