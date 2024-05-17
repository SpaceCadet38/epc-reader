using System;
using System.Windows.Forms;

namespace TestProject
{
    public partial class SetExternalURL : Form
    {
        public delegate void SetURLDelegate(string URL);
        public SetURLDelegate SetURLCallBack;
        public SetExternalURL()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SetURLCallBack(urlTextBox.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
