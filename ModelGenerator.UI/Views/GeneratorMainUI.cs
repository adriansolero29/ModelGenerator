using ModelGenerator.UI.Class;
using ModelGenerator.UI.Helpers;
using ModelGenerator.UI.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static ModelGenerator.UI.Enums.Enums;
using static ModelGenerator.UI.Helpers.ServiceResolvers;

namespace ModelGenerator.UI.Views
{
    public partial class GeneratorMainUI : Form
    {
        private readonly IXMLService databaseXmlService;
        private readonly IXMLService xmlPropertyService;
        private readonly IDataTypeConverter dataTypeConverter;
        private readonly IBusinessLogicService businessLogicService;
        private readonly IXMLPropertyTypesList xMLPropertyTypesList;
        private readonly DatabaseSettingSetupWindow databaseSettingSetupWindow;
        private readonly GeneratedModelViewer modelViewer;

        public GeneratorMainUI(ServiceResolverXML databaseXmlServiceResolver, IBusinessLogicService businessLogicService, IXMLPropertyTypesList xMLPropertyTypesList, DataTypeConverterServiceResolver dataTypeConverter, DatabaseSettingSetupWindow databaseSettingSetupWindow, GeneratedModelViewer modelViewer)
        {
            InitializeComponent();
            this.databaseXmlService = databaseXmlServiceResolver(XMLService.XMLDatabaseSetting);
            this.xmlPropertyService = databaseXmlServiceResolver(XMLService.PropertyModels);
            this.dataTypeConverter = dataTypeConverter(DataLoaderService.PostgreSQL);
            this.businessLogicService = businessLogicService;
            this.xMLPropertyTypesList = xMLPropertyTypesList;
            this.databaseSettingSetupWindow = databaseSettingSetupWindow;
            this.modelViewer = modelViewer;

            Init();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DatabaseSetting_Click(object sender, EventArgs e)
        {
            databaseSettingSetupWindow.ShowDialog();
        }

        private async void Init()
        {
            databaseXmlService.GetValues();

            databaseTypeValue.Text = DataCommunication.DatabaseType;
            databaseNameValue.Text = DataCommunication.DatabaseName;
            PortNumber.Text = DataCommunication.PortNumber;
            UserId.Text = DataCommunication.UserId;

            SchemaList.DataSource = await businessLogicService.SchemaList();
            PropertyTypeList.DataSource = xMLPropertyTypesList.GetProperties();
        }

        private async void SchemaList_SelectedValueChanged(object sender, EventArgs e)
        {
            TableList.DataSource = await businessLogicService.TableList(SchemaList.SelectedItem.ToString());
        }

        private async void TableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var schemaName = SchemaList.SelectedItem.ToString();
            var tableName = TableList.SelectedItem.ToString();

            ColumnList.Items.Clear();
            if (SchemaList.SelectedItem != null)
            {
                var columnList = await businessLogicService.ColumnList(schemaName, tableName);
                ListViewItem listViewItem;
                foreach (var item in columnList)
                {
                    listViewItem = new ListViewItem(item.ColumnName);
                    listViewItem.SubItems.Add(item.ColumnDataType.ToString());

                    ColumnList.Items.Add(listViewItem);
                }
            }
        }

        private void GenerateModel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PropertyTypeList.SelectedItem.ToString()))
            {
                MessageBox.Show("Select property type", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModelOutputGenerator.ModelName = TableList.SelectedItem.ToString();
            ModelOutputGenerator.ModelSchema = SchemaList.SelectedItem.ToString();

            var listColumns = new List<(string, string)>();
            foreach (ListViewItem item in ColumnList.Items)
            {
                listColumns.Add((item.Text, item.SubItems[1].Text));
            }

            var output = ModelOutputGenerator.Output(PropertyTypeList.SelectedItem.ToString(), listColumns, ObjectLoaderCheck.Checked, ModelSuffix.Text, xmlPropertyService, dataTypeConverter);
            modelViewer.ModelOutputValue = output;
            modelViewer.ShowDialog();
        }

        private void ModelSuffix_TextChanged(object sender, EventArgs e)
        {
            var sampleOutput = "ModelName";
            ModelSampleOutput.Text = $"{sampleOutput}{ModelSuffix.Text}";
        }
    }
}
