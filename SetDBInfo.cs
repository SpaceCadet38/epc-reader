using System;
using System.Windows.Forms;

namespace TestProject
{
    public partial class SetDBInfo : Form
    {
        public SetDBInfo()
        {
            InitializeComponent();
        }
        public delegate void SetDBInfoDelegate(string dbName, string tableName);
        public SetDBInfoDelegate SetDBInfoCallback;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SetDBInfoCallback(dbNameTxtBox.Text.Trim(), tableNameTxtBox.Text.Trim());
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
