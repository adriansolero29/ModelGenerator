using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelGenerator.UI.Views
{
    public partial class GeneratedModelViewer : Form
    {
        public GeneratedModelViewer()
        {
            InitializeComponent();
        }

        private string _modelOutputValue;

        public string ModelOutputValue
        {
            get { return _modelOutputValue; }
            set 
            { 
                _modelOutputValue = value;
                ModelOutput.Text = value;
            }
        }

        private string _modelName;

        public string ModelName
        {
            get { return _modelName; }
            set 
            { 
                _modelName = value;
                TableLabel.Text = value;
            }
        }
    }
}
