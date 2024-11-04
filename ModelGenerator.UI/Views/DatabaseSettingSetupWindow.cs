using ModelGenerator.UI.Class;
using ModelGenerator.UI.Helpers;
using ModelGenerator.UI.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ModelGenerator.UI.Helpers.XMLServiceResolver;

namespace ModelGenerator.UI.Views
{
    public partial class DatabaseSettingSetupWindow : Form
    {
        private readonly IDBInit dbInitialize;
        private IXMLService xmlService;

        public DatabaseSettingSetupWindow(IDBInit dbInitialize, ServiceResolverXML xMLServiceResolver)
        {
            InitializeComponent();
            this.dbInitialize = dbInitialize;
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
                "SQL Server"
            };

            DatabaseTypes.DataSource = databaseTypes;

            DatabaseTypes.SelectedItem = DataCommunication.DatabaseType;
            DatabaseName.Text = DataCommunication.DatabaseName;
            PortNumber.Text = DataCommunication.PortNumber;
            UserId.Text = DataCommunication.UserId;
            Password.Text = DataCommunication.Password;
        }

        private void DatabaseTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DatabaseTypes.SelectedItem?.ToString() == "PostgreSQL")
            {
                dbInitialize.InitializeConnection();
            }
        }
    }
}
