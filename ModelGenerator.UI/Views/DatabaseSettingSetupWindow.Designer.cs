
namespace ModelGenerator.UI.Views
{
    partial class DatabaseSettingSetupWindow
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
            this.ServerName = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.portNumberLabel = new System.Windows.Forms.Label();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.userIdLable = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.DatabaseTypes = new System.Windows.Forms.ComboBox();
            this.databaseTypeLabel = new System.Windows.Forms.Label();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(12, 124);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(226, 23);
            this.ServerName.TabIndex = 0;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(12, 107);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(84, 15);
            this.serverNameLabel.TabIndex = 1;
            this.serverNameLabel.Text = "Server Name";
            // 
            // portNumberLabel
            // 
            this.portNumberLabel.AutoSize = true;
            this.portNumberLabel.Location = new System.Drawing.Point(12, 150);
            this.portNumberLabel.Name = "portNumberLabel";
            this.portNumberLabel.Size = new System.Drawing.Size(84, 15);
            this.portNumberLabel.TabIndex = 3;
            this.portNumberLabel.Text = "Port Number";
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(12, 167);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(226, 23);
            this.PortNumber.TabIndex = 2;
            // 
            // userIdLable
            // 
            this.userIdLable.AutoSize = true;
            this.userIdLable.Location = new System.Drawing.Point(12, 193);
            this.userIdLable.Name = "userIdLable";
            this.userIdLable.Size = new System.Drawing.Size(56, 15);
            this.userIdLable.TabIndex = 5;
            this.userIdLable.Text = "User Id";
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(12, 210);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(226, 23);
            this.UserId.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 236);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 15);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 253);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(226, 23);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Save
            // 
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Location = new System.Drawing.Point(22, 291);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 36);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Location = new System.Drawing.Point(128, 291);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 36);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DatabaseTypes
            // 
            this.DatabaseTypes.FormattingEnabled = true;
            this.DatabaseTypes.Location = new System.Drawing.Point(12, 36);
            this.DatabaseTypes.Name = "DatabaseTypes";
            this.DatabaseTypes.Size = new System.Drawing.Size(226, 23);
            this.DatabaseTypes.TabIndex = 10;
            this.DatabaseTypes.SelectedIndexChanged += new System.EventHandler(this.DatabaseTypes_SelectedIndexChanged);
            // 
            // databaseTypeLabel
            // 
            this.databaseTypeLabel.AutoSize = true;
            this.databaseTypeLabel.Location = new System.Drawing.Point(12, 18);
            this.databaseTypeLabel.Name = "databaseTypeLabel";
            this.databaseTypeLabel.Size = new System.Drawing.Size(98, 15);
            this.databaseTypeLabel.TabIndex = 11;
            this.databaseTypeLabel.Text = "Database Type";
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Location = new System.Drawing.Point(12, 62);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(98, 15);
            this.databaseNameLabel.TabIndex = 13;
            this.databaseNameLabel.Text = "Database Name";
            // 
            // DatabaseName
            // 
            this.DatabaseName.Location = new System.Drawing.Point(12, 80);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(226, 23);
            this.DatabaseName.TabIndex = 12;
            // 
            // DatabaseSettingSetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 333);
            this.ControlBox = false;
            this.Controls.Add(this.databaseNameLabel);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.DatabaseTypes);
            this.Controls.Add(this.databaseTypeLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.userIdLable);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.portNumberLabel);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.ServerName);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DatabaseSettingSetupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label portNumberLabel;
        private System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.Label userIdLable;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox DatabaseTypes;
        private System.Windows.Forms.Label databaseTypeLabel;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.TextBox DatabaseName;
    }
}