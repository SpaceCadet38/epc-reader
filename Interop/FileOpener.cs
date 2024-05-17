using System;
using System.Windows.Forms;

namespace TestProject.Interop
{
    public static class FileOpener
    {
        public static string GetFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.csv";
                openFileDialog.FilterIndex = 1;
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}


