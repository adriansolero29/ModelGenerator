﻿
namespace ModelGenerator.UI.Views
{
    partial class PropertyModelSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyModelSetup));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FieldPanel = new System.Windows.Forms.Panel();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.ModelFormatLabel = new System.Windows.Forms.Label();
            this.ModelNameLabel = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.TextBox();
            this.ModelList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.FieldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FieldPanel
            // 
            this.FieldPanel.Controls.Add(this.TextPanel);
            this.FieldPanel.Controls.Add(this.NoteLabel);
            this.FieldPanel.Controls.Add(this.ModelFormatLabel);
            this.FieldPanel.Controls.Add(this.ModelNameLabel);
            this.FieldPanel.Controls.Add(this.ModelName);
            this.FieldPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FieldPanel.Location = new System.Drawing.Point(220, 24);
            this.FieldPanel.Name = "FieldPanel";
            this.FieldPanel.Size = new System.Drawing.Size(404, 384);
            this.FieldPanel.TabIndex = 3;
            // 
            // TextPanel
            // 
            this.TextPanel.Location = new System.Drawing.Point(7, 80);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(385, 253);
            this.TextPanel.TabIndex = 11;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NoteLabel.ForeColor = System.Drawing.Color.Blue;
            this.NoteLabel.Location = new System.Drawing.Point(7, 336);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(343, 39);
            this.NoteLabel.TabIndex = 10;
            this.NoteLabel.Text = "Note: \'DataTypeValue\' for data type text\r\n\'PropertyNameValue\' for the property na" +
    "me text\r\nEx: public DataTypeValue PropertyNameValue { get; set; }";
            // 
            // ModelFormatLabel
            // 
            this.ModelFormatLabel.AutoSize = true;
            this.ModelFormatLabel.Location = new System.Drawing.Point(6, 62);
            this.ModelFormatLabel.Name = "ModelFormatLabel";
            this.ModelFormatLabel.Size = new System.Drawing.Size(91, 15);
            this.ModelFormatLabel.TabIndex = 9;
            this.ModelFormatLabel.Text = "Model Format";
            // 
            // ModelNameLabel
            // 
            this.ModelNameLabel.AutoSize = true;
            this.ModelNameLabel.Location = new System.Drawing.Point(7, 15);
            this.ModelNameLabel.Name = "ModelNameLabel";
            this.ModelNameLabel.Size = new System.Drawing.Size(77, 15);
            this.ModelNameLabel.TabIndex = 8;
            this.ModelNameLabel.Text = "Model Name";
            // 
            // ModelName
            // 
            this.ModelName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelName.Location = new System.Drawing.Point(6, 33);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(262, 23);
            this.ModelName.TabIndex = 6;
            this.ModelName.TextChanged += new System.EventHandler(this.ModelName_TextChanged);
            // 
            // ModelList
            // 
            this.ModelList.FormattingEnabled = true;
            this.ModelList.ItemHeight = 15;
            this.ModelList.Location = new System.Drawing.Point(12, 39);
            this.ModelList.Name = "ModelList";
            this.ModelList.Size = new System.Drawing.Size(202, 364);
            this.ModelList.TabIndex = 4;
            this.ModelList.SelectedValueChanged += new System.EventHandler(this.ModelList_SelectedValueChanged);
            // 
            // PropertyModelSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 408);
            this.Controls.Add(this.ModelList);
            this.Controls.Add(this.FieldPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PropertyModelSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PropertyModelSetup_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FieldPanel.ResumeLayout(false);
            this.FieldPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel FieldPanel;
        private System.Windows.Forms.Label ModelFormatLabel;
        private System.Windows.Forms.Label ModelNameLabel;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.ListBox ModelList;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Panel TextPanel;
    }
}