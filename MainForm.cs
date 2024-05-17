using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using TestProject.Interop;
using static TestProject.SetExternalURL;
using static TestProject.SetDBInfo;
using TestProject.Connect;
using System.Threading.Tasks;

namespace TestProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Point mouseLocation;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private string DatabaseName;
        private string TableName;
        private void SetDBInfoCallbackFn(string dbName, string tableName)
        {
            if (string.IsNullOrEmpty(dbName) || string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Can't get database information");
            }
            else
            {
                DatabaseName = dbName;
                TableName = tableName;
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            string filePath = FileOpener.GetFilePath();
            if (filePath != null)
            {
                using (ExcelReader excelReader = new ExcelReader(filePath))
                {
                    // Connection string
                    SetDBInfo setDBInfo = new SetDBInfo();
                    setDBInfo.SetDBInfoCallback = new SetDBInfoDelegate(SetDBInfoCallbackFn);
                    setDBInfo.ShowDialog();
                    string server = @"(local)\SQLExpress";
                    string connectionString = $@"Server={server};Database={DatabaseName};Integrated Security=true;";
                    if (string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(TableName))
                    {
                        MessageBox.Show("You must enter server and table name!");
                        return;
                    }
                    excelReader.ConnectToDB(connectionString);
                    excelReader.StoreIntoDB(TableName);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (ExcelReader excelReader = new ExcelReader())
            {
                SetDBInfo setDBInfo = new SetDBInfo();
                setDBInfo.SetDBInfoCallback = new SetDBInfoDelegate(SetDBInfoCallbackFn);
                setDBInfo.ShowDialog();
                string server = @"(local)\SQLExpress";
                string connectionString = $@"Server={server};Database={DatabaseName};Integrated Security=true;";
                List<string> exportFieldList = new List<string>
                {
                    "ri_date",
                    "epc_code",
                };
                if (string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(TableName))
                {
                    MessageBox.Show("You must enter server and table name!");
                    return;
                }
                excelReader.ConnectToDB(connectionString);
                excelReader.ExportToExcel(TableName, exportFieldList);
            }
        }

        private void btnSendToURL_Click(object sender, EventArgs e)
        {
            SetExternalURL setURL = new SetExternalURL();
            setURL.SetURLCallBack = new SetURLDelegate(SetURLCallbackFn);
            setURL.ShowDialog();
        }

        private void SetURLCallbackFn(string url)
        {
            SrvConnection srvConnection = new SrvConnection();
            srvConnection.Upload(FileOpener.GetFilePath(), url);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool sideBarExpand = true;
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 45)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 205)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void langSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (langSelectBox.SelectedIndex)
            {
                case 0:
                    CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(currentCulture.ToString());
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                    break;
                default:
                    break;
            }
            Controls.Clear();
            InitializeComponent();
        }
    }
}

