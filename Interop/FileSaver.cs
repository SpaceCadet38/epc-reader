using System.IO;
using System.Windows.Forms;

namespace TestProject.Interop
{
    public static class FileSaver
    {
        public static string SaveToPath()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.csv"; saveFileDialog.FilterIndex = 1;
                saveFileDialog.Title = "Save as";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
