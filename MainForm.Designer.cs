namespace TestProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRead = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSendToURL = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.langSelectBox = new System.Windows.Forms.ComboBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.btnMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMinimized, "btnMinimized");
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel8);
            resources.ApplyResources(this.sideBar, "sideBar");
            this.sideBar.Name = "sideBar";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRead);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnRead
            // 
            resources.ApplyResources(this.btnRead, "btnRead");
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.Name = "btnRead";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExport);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStop);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSendToURL);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // btnSendToURL
            // 
            resources.ApplyResources(this.btnSendToURL, "btnSendToURL");
            this.btnSendToURL.FlatAppearance.BorderSize = 0;
            this.btnSendToURL.Name = "btnSendToURL";
            this.btnSendToURL.UseVisualStyleBackColor = true;
            this.btnSendToURL.Click += new System.EventHandler(this.btnSendToURL_Click);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // langSelectBox
            // 
            resources.ApplyResources(this.langSelectBox, "langSelectBox");
            this.langSelectBox.FormattingEnabled = true;
            this.langSelectBox.Items.AddRange(new object[] {
            resources.GetString("langSelectBox.Items"),
            resources.GetString("langSelectBox.Items1")});
            this.langSelectBox.Name = "langSelectBox";
            this.langSelectBox.SelectedIndexChanged += new System.EventHandler(this.langSelectBox_SelectedIndexChanged);
            // 
            // langLabel
            // 
            resources.ApplyResources(this.langLabel, "langLabel");
            this.langLabel.Name = "langLabel";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.langSelectBox);
            this.panel7.Controls.Add(this.langLabel);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.panel1.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.ComboBox langSelectBox;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSendToURL;
    }
}

