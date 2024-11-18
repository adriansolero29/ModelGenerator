
namespace ModelGenerator.UI.Views
{
    partial class GeneratorMainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ModelSampleOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelSuffix = new System.Windows.Forms.TextBox();
            this.ModelSuffixLabel = new System.Windows.Forms.Label();
            this.ObjectLoaderCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PropertyTypeList = new System.Windows.Forms.ComboBox();
            this.GenerateModel = new System.Windows.Forms.Button();
            this.columnLabel = new System.Windows.Forms.Label();
            this.ColumnList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lblSchema = new System.Windows.Forms.Label();
            this.SchemaList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TableList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserId = new System.Windows.Forms.Label();
            this.PortNumber = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.databaseNameValue = new System.Windows.Forms.Label();
            this.databaseTypeValue = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.propertyTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.DatabaseSetting,
            this.propertyTypesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DatabaseSetting
            // 
            this.DatabaseSetting.Name = "DatabaseSetting";
            this.DatabaseSetting.Size = new System.Drawing.Size(107, 20);
            this.DatabaseSetting.Text = "Database Setting";
            this.DatabaseSetting.Click += new System.EventHandler(this.DatabaseSetting_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ModelSampleOutput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ModelSuffix);
            this.panel1.Controls.Add(this.ModelSuffixLabel);
            this.panel1.Controls.Add(this.ObjectLoaderCheck);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PropertyTypeList);
            this.panel1.Controls.Add(this.GenerateModel);
            this.panel1.Controls.Add(this.columnLabel);
            this.panel1.Controls.Add(this.ColumnList);
            this.panel1.Controls.Add(this.lblSchema);
            this.panel1.Controls.Add(this.SchemaList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TableList);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 536);
            this.panel1.TabIndex = 2;
            // 
            // ModelSampleOutput
            // 
            this.ModelSampleOutput.AutoSize = true;
            this.ModelSampleOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ModelSampleOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModelSampleOutput.Location = new System.Drawing.Point(352, 468);
            this.ModelSampleOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelSampleOutput.Name = "ModelSampleOutput";
            this.ModelSampleOutput.Size = new System.Drawing.Size(14, 15);
            this.ModelSampleOutput.TabIndex = 14;
            this.ModelSampleOutput.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(292, 468);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sample:";
            // 
            // ModelSuffix
            // 
            this.ModelSuffix.Location = new System.Drawing.Point(111, 465);
            this.ModelSuffix.Name = "ModelSuffix";
            this.ModelSuffix.Size = new System.Drawing.Size(176, 23);
            this.ModelSuffix.TabIndex = 12;
            this.ModelSuffix.TextChanged += new System.EventHandler(this.ModelSuffix_TextChanged);
            // 
            // ModelSuffixLabel
            // 
            this.ModelSuffixLabel.AutoSize = true;
            this.ModelSuffixLabel.Location = new System.Drawing.Point(9, 468);
            this.ModelSuffixLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelSuffixLabel.Name = "ModelSuffixLabel";
            this.ModelSuffixLabel.Size = new System.Drawing.Size(98, 15);
            this.ModelSuffixLabel.TabIndex = 11;
            this.ModelSuffixLabel.Text = "Model Suffix:";
            // 
            // ObjectLoaderCheck
            // 
            this.ObjectLoaderCheck.AutoSize = true;
            this.ObjectLoaderCheck.Location = new System.Drawing.Point(12, 494);
            this.ObjectLoaderCheck.Name = "ObjectLoaderCheck";
            this.ObjectLoaderCheck.Size = new System.Drawing.Size(320, 19);
            this.ObjectLoaderCheck.TabIndex = 10;
            this.ObjectLoaderCheck.Text = "Auto set data type if column contains \'Id\'";
            this.ObjectLoaderCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 439);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Property Type";
            // 
            // PropertyTypeList
            // 
            this.PropertyTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyTypeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PropertyTypeList.FormattingEnabled = true;
            this.PropertyTypeList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PropertyTypeList.Location = new System.Drawing.Point(111, 436);
            this.PropertyTypeList.Margin = new System.Windows.Forms.Padding(2);
            this.PropertyTypeList.Name = "PropertyTypeList";
            this.PropertyTypeList.Size = new System.Drawing.Size(176, 23);
            this.PropertyTypeList.TabIndex = 8;
            // 
            // GenerateModel
            // 
            this.GenerateModel.Location = new System.Drawing.Point(292, 431);
            this.GenerateModel.Name = "GenerateModel";
            this.GenerateModel.Size = new System.Drawing.Size(180, 30);
            this.GenerateModel.TabIndex = 7;
            this.GenerateModel.Text = "Generate Model";
            this.GenerateModel.UseVisualStyleBackColor = true;
            this.GenerateModel.Click += new System.EventHandler(this.GenerateModel_Click);
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Location = new System.Drawing.Point(9, 224);
            this.columnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(56, 15);
            this.columnLabel.TabIndex = 6;
            this.columnLabel.Text = "Columns";
            // 
            // ColumnList
            // 
            this.ColumnList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ColumnList.FullRowSelect = true;
            this.ColumnList.HideSelection = false;
            this.ColumnList.Location = new System.Drawing.Point(12, 242);
            this.ColumnList.Name = "ColumnList";
            this.ColumnList.Size = new System.Drawing.Size(460, 183);
            this.ColumnList.TabIndex = 5;
            this.ColumnList.UseCompatibleStateImageBehavior = false;
            this.ColumnList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Column Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Type";
            this.columnHeader2.Width = 230;
            // 
            // lblSchema
            // 
            this.lblSchema.AutoSize = true;
            this.lblSchema.Location = new System.Drawing.Point(8, 140);
            this.lblSchema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSchema.Name = "lblSchema";
            this.lblSchema.Size = new System.Drawing.Size(56, 15);
            this.lblSchema.TabIndex = 4;
            this.lblSchema.Text = "Schemas";
            // 
            // SchemaList
            // 
            this.SchemaList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchemaList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SchemaList.FormattingEnabled = true;
            this.SchemaList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SchemaList.Location = new System.Drawing.Point(9, 157);
            this.SchemaList.Margin = new System.Windows.Forms.Padding(2);
            this.SchemaList.Name = "SchemaList";
            this.SchemaList.Size = new System.Drawing.Size(467, 23);
            this.SchemaList.TabIndex = 3;
            this.SchemaList.SelectedValueChanged += new System.EventHandler(this.SchemaList_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tables";
            // 
            // TableList
            // 
            this.TableList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TableList.FormattingEnabled = true;
            this.TableList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TableList.Location = new System.Drawing.Point(9, 199);
            this.TableList.Margin = new System.Windows.Forms.Padding(2);
            this.TableList.Name = "TableList";
            this.TableList.Size = new System.Drawing.Size(467, 23);
            this.TableList.TabIndex = 1;
            this.TableList.SelectedIndexChanged += new System.EventHandler(this.TableList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.UserId);
            this.groupBox1.Controls.Add(this.PortNumber);
            this.groupBox1.Controls.Add(this.lblUserId);
            this.groupBox1.Controls.Add(this.lblPortNumber);
            this.groupBox1.Controls.Add(this.databaseNameValue);
            this.groupBox1.Controls.Add(this.databaseTypeValue);
            this.groupBox1.Controls.Add(this.lblDatabaseName);
            this.groupBox1.Controls.Add(this.lblDatabase);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(468, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Information";
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(118, 88);
            this.UserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(13, 13);
            this.UserId.TabIndex = 7;
            this.UserId.Text = "-";
            // 
            // PortNumber
            // 
            this.PortNumber.AutoSize = true;
            this.PortNumber.Location = new System.Drawing.Point(118, 65);
            this.PortNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(13, 13);
            this.PortNumber.TabIndex = 6;
            this.PortNumber.Text = "-";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(59, 88);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(55, 13);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.Text = "User Id:";
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Location = new System.Drawing.Point(35, 65);
            this.lblPortNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(79, 13);
            this.lblPortNumber.TabIndex = 4;
            this.lblPortNumber.Text = "Port Number:";
            // 
            // databaseNameValue
            // 
            this.databaseNameValue.AutoSize = true;
            this.databaseNameValue.Location = new System.Drawing.Point(118, 42);
            this.databaseNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.databaseNameValue.Name = "databaseNameValue";
            this.databaseNameValue.Size = new System.Drawing.Size(13, 13);
            this.databaseNameValue.TabIndex = 3;
            this.databaseNameValue.Text = "-";
            // 
            // databaseTypeValue
            // 
            this.databaseTypeValue.AutoSize = true;
            this.databaseTypeValue.Location = new System.Drawing.Point(118, 19);
            this.databaseTypeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.databaseTypeValue.Name = "databaseTypeValue";
            this.databaseTypeValue.Size = new System.Drawing.Size(13, 13);
            this.databaseTypeValue.TabIndex = 2;
            this.databaseTypeValue.Text = "-";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(23, 42);
            this.lblDatabaseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(91, 13);
            this.lblDatabaseName.TabIndex = 1;
            this.lblDatabaseName.Text = "Database Name:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(23, 19);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(91, 13);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "Database Type:";
            // 
            // propertyTypesToolStripMenuItem
            // 
            this.propertyTypesToolStripMenuItem.Name = "propertyTypesToolStripMenuItem";
            this.propertyTypesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.propertyTypesToolStripMenuItem.Text = "Property Types";
            this.propertyTypesToolStripMenuItem.Click += new System.EventHandler(this.propertyTypesToolStripMenuItem_Click);
            // 
            // GeneratorMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 560);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeneratorMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label databaseNameValue;
        private System.Windows.Forms.Label databaseTypeValue;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TableList;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label PortNumber;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.ComboBox SchemaList;
        private System.Windows.Forms.Label columnLabel;
        private System.Windows.Forms.ListView ColumnList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button GenerateModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PropertyTypeList;
        private System.Windows.Forms.CheckBox ObjectLoaderCheck;
        private System.Windows.Forms.Label ModelSampleOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelSuffix;
        private System.Windows.Forms.Label ModelSuffixLabel;
        private System.Windows.Forms.ToolStripMenuItem propertyTypesToolStripMenuItem;
    }
}

