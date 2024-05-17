namespace TestProject
{
    partial class SetDBInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetDBInfo));
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.dbNameTxtBox = new System.Windows.Forms.TextBox();
            this.tableNameTxtBox = new System.Windows.Forms.TextBox();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverNameLabel
            // 
            resources.ApplyResources(this.serverNameLabel, "serverNameLabel");
            this.serverNameLabel.Name = "serverNameLabel";
            // 
            // dbNameTxtBox
            // 
            resources.ApplyResources(this.dbNameTxtBox, "dbNameTxtBox");
            this.dbNameTxtBox.Name = "dbNameTxtBox";
            // 
            // tableNameTxtBox
            // 
            resources.ApplyResources(this.tableNameTxtBox, "tableNameTxtBox");
            this.tableNameTxtBox.Name = "tableNameTxtBox";
            // 
            // tableNameLabel
            // 
            resources.ApplyResources(this.tableNameLabel, "tableNameLabel");
            this.tableNameLabel.Name = "tableNameLabel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.serverNameLabel);
            this.panel1.Controls.Add(this.tableNameTxtBox);
            this.panel1.Controls.Add(this.dbNameTxtBox);
            this.panel1.Controls.Add(this.tableNameLabel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SetDBInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetDBInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.TextBox dbNameTxtBox;
        private System.Windows.Forms.TextBox tableNameTxtBox;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}