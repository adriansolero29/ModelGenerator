using ModelGenerator.UI.Class;
using ModelGenerator.UI.Interface;
using System;
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
        private readonly DatabaseSettingSetupWindow databaseSettingSetupWindow;
        private readonly GeneratedModelViewer modelViewer;

        public GeneratorMainUI(ServiceResolverXML databaseXmlServiceResolver, DataTypeConverterServiceResolver dataTypeConverter, IBusinessLogicService businessLogicService, DatabaseSettingSetupWindow databaseSettingSetupWindow, GeneratedModelViewer modelViewer)
        {
            InitializeComponent();
            this.databaseXmlService = databaseXmlServiceResolver(XMLService.XMLDatabaseSetting);
            this.xmlPropertyService = databaseXmlServiceResolver(XMLService.PropertyModels);
            this.dataTypeConverter = dataTypeConverter(DataLoaderService.PostgreSQL);
            this.businessLogicService = businessLogicService;
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
            PropertyTypeList.Items.Add("Regular Property");
            PropertyTypeList.Items.Add("Full Property");
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
            if (PropertyTypeList.SelectedItem.ToString() == "Regular Property")
            {
                StringBuilder stringBuilder = new StringBuilder(string.Empty);
                var propFormat = xmlPropertyService.GetValues("RegularProperty");

                foreach (ListViewItem item in ColumnList.Items)
                {
                    string tempFormat = propFormat;
                    string propOutput = tempFormat.Replace("DataTypeValue", dataTypeConverter.Convert(item.SubItems[1].Text)).Replace("PropertyNameValue", item.Text);

                    if (ObjectLoaderCheck.Checked)
                    {
                        if (item.Text.Length > 2 && item.Text.Substring(item.Text.Length - 2) == "Id")
                        {
                            var dataType = item.Text.Substring(0, item.Text.Length - 2);
                            propOutput = tempFormat.Replace("DataTypeValue", dataType + ModelSuffix.Text).Replace("PropertyNameValue", item.Text);
                        }
                    }
                    
                    stringBuilder.Append($"{propOutput}");
                }

                modelViewer.ModelOutputValue = @$"using System;
using System.Text;

namespace {SchemaList.SelectedItem.ToString()}
{{
    public class {TableList.SelectedItem.ToString()}
    {{
        {stringBuilder.ToString()}
    }}
}}";
                modelViewer.ModelName = SchemaList.SelectedItem.ToString() + "." + TableList.SelectedItem.ToString();
                modelViewer.ShowDialog();
            }
            else if (PropertyTypeList.SelectedItem.ToString() == "Full Property")
            {
                StringBuilder stringBuilder = new StringBuilder(string.Empty);
                var propFormat = xmlPropertyService.GetValues("FullProperty");

                foreach (ListViewItem item in ColumnList.Items)
                {
                    string tempFormat = propFormat;
                    string propOutput = tempFormat.Replace("DataTypeValue", dataTypeConverter.Convert(item.SubItems[1].Text)).Replace("PropertyNameValue", item.Text).Replace("_propertyNameValue", "_" + item.Text.Substring(0, 1).ToLower() + item.Text.Substring(1));
                    stringBuilder.Append($"{propOutput}\n");
                }

                modelViewer.ModelOutputValue = "public class " + TableList.SelectedItem.ToString() + "\n{\n" + stringBuilder.ToString() + "\n}";
                modelViewer.ModelName = SchemaList.SelectedItem.ToString() + "." + TableList.SelectedItem.ToString();
                modelViewer.ShowDialog();
            }
        }

        private void ModelSuffix_TextChanged(object sender, EventArgs e)
        {
            var sampleOutput = "ModelName";
            ModelSampleOutput.Text = $"{sampleOutput}{ModelSuffix.Text}";
        }
    }
}
