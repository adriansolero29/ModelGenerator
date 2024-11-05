
namespace ModelGenerator.UI.Views
{
    partial class GeneratedModelViewer
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
            this.TableLabel = new System.Windows.Forms.Label();
            this.ModelOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableLabel.Location = new System.Drawing.Point(12, 9);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(18, 19);
            this.TableLabel.TabIndex = 0;
            this.TableLabel.Text = "-";
            // 
            // ModelOutput
            // 
            this.ModelOutput.AcceptsTab = true;
            this.ModelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelOutput.Location = new System.Drawing.Point(12, 31);
            this.ModelOutput.Name = "ModelOutput";
            this.ModelOutput.Size = new System.Drawing.Size(560, 518);
            this.ModelOutput.TabIndex = 1;
            this.ModelOutput.Text = "";
            this.ModelOutput.WordWrap = false;
            // 
            // GeneratedModelViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ModelOutput);
            this.Controls.Add(this.TableLabel);
            this.Name = "GeneratedModelViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.RichTextBox ModelOutput;
    }
}