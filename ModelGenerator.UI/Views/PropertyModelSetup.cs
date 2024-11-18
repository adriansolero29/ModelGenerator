using ModelGenerator.UI.Interface;
using ModelGenerator.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ModelGenerator.UI.Helpers.ServiceResolvers;

namespace ModelGenerator.UI.Views
{
    public partial class PropertyModelSetup : Form
    {
        private readonly IXMLPropertyTypesList propertyTypeList;
        private readonly IServiceProvider serviceProvider;
        private readonly IXMLService propertyTypeService;

        public PropertyModelSetup(ServiceResolverXML serviceResolverXML, IXMLPropertyTypesList propertyTypeList, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            FieldPanel.Enabled = false;

            this.propertyTypeList = propertyTypeList;
            this.serviceProvider = serviceProvider;
            this.propertyTypeService = serviceResolverXML(Enums.Enums.XMLService.PropertyModels);
        }

        #region Properties

        private PropertyTypeModel _propertyTypeInfo;
        public PropertyTypeModel PropertyTypeInfo
        {
            get 
            { 
                return _propertyTypeInfo; 
            }
            set 
            {
                _propertyTypeInfo = value; 
                if (value != null)
                {
                    ModelName.Text = value.ModelName;
                    ModelFormat.Text = value.ModelFormat;
                }
            }
        }

        public bool IsEdit { get; set; }

        #endregion

        #region Methods

        private void Init()
        {
            ModelList.DataSource = propertyTypeList.GetProperties();
        }

        #endregion

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FieldPanel.Enabled = true;
            PropertyTypeInfo = new PropertyTypeModel();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FieldPanel.Enabled = true;
            IsEdit = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.propertyTypeService.Write(ModelName.Text, ModelFormat.Text);
                MessageBox.Show("Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
            else
            {
                this.propertyTypeService.Add(ModelName.Text, ModelFormat.Text);
                MessageBox.Show("Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
        }

        private void PropertyModelSetup_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void ModelList_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedModel = ModelList.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedModel))
            {
                var propertyType = propertyTypeService.GetValues(selectedModel);
                PropertyTypeInfo = new PropertyTypeModel { ModelName = selectedModel, ModelFormat = propertyType };
            }
        }


    }
}
