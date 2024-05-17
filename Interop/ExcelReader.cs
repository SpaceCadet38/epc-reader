using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using TestProject.Connect;
using System.Linq;
using System.Windows.Forms;

namespace TestProject.Interop
{
    public class ExcelReader : IDisposable
    {
        // Declare Microsoft Excel COM object
        private Excel.Application excelApp;
        private Excel.Workbook excelWorkbook;
        private Excel._Worksheet excelWorksheet;
        private Excel.Range excelRange;
        // Declare creation, modification time
        private DateTime lastCreated;
        private DateTime lastModified;
        private DateTime today = DateTime.Today;
        // Connector to Database
        private DBConnection dbConnection;
        // Create ExcelReader object with specified excel file path
        public ExcelReader(string path)
        {
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(path);
            excelWorksheet = excelWorkbook.Sheets[1];
            excelRange = excelWorksheet.UsedRange;
            lastCreated = File.GetCreationTime(path);
            lastModified = File.GetLastWriteTime(path);
        }
        // Create ExcelReader object with non file path specify
        public ExcelReader()
        {
            excelApp = new Excel.Application();
            excelWorkbook = excelApp.Workbooks.Add();
            excelWorksheet = (Excel.Worksheet)excelWorkbook.Worksheets[1];
        }
        public void ConnectToDB(string connectionString)
        {
            dbConnection = new DBConnection(connectionString);
        }
        public void ExportToExcel(string tableName, List<string> parameters)
        {
            using (dbConnection)
            {
                dbConnection.Open();
                string query = $@"SELECT {string.Join(", ", parameters)} FROM {tableName}";
                DataTable dataTable = dbConnection.GetDataTable(query);
                object[,] dataArr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
                int rowCount = dataTable.Rows.Count;
                int columnCount = dataTable.Columns.Count;
                for (int row = 0; row < rowCount; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];
                    for (int col = 0; col < columnCount; col++)
                    {
                        dataArr[row, col] = dataRow[col];
                    }
                }
                int rowStart = 1;
                int columnStart = 1;
                Excel.Range c1 = excelWorksheet.Cells[rowStart, columnStart];
                Excel.Range c2 = excelWorksheet.Cells[rowCount, columnCount];
                excelRange = excelWorksheet.Range[c1, c2];
                excelRange.Value2 = dataArr;
                excelWorkbook.SaveAs(FileSaver.SaveToPath());
            }
        }
        public void StoreIntoDB(string tableName)
        {
            using (dbConnection)
            {
                dbConnection.Open();
                List<string> fieldNames = dbConnection.GetFieldNames(tableName);
                string fieldNamesStr = string.Join(", ", fieldNames);
                string primaryKey = fieldNames.First().Trim();
                string duplicatableField = fieldNames.Last().Trim();
                string query = $@"
IF EXISTS (SELECT 1 FROM {tableName} WHERE {duplicatableField} = @value5)
    UPDATE {tableName}
    SET updated_at = @value3
    WHERE {duplicatableField} = @value5
ELSE
    INSERT INTO {tableName} ({fieldNamesStr})
    SELECT ISNULL (MAX({primaryKey}), 0) + 1, @value2, @value3, @value4, @value5 FROM {tableName}";

                int index = 1;
                foreach (Excel.Range cell in excelRange)
                {
                    if (cell.Row == 1 && cell.Column == 1)
                        continue;

                    List<SqlParameter> parameters = new List<SqlParameter>
                        {
                            new SqlParameter("@value1",SqlDbType.Int){Value=index },
                            new SqlParameter("@value2",SqlDbType.DateTime){Value=lastCreated },
                            new SqlParameter("@value3",SqlDbType.DateTime){Value=lastModified },
                            new SqlParameter("@value4",SqlDbType.DateTime){Value=today },
                            new SqlParameter("@value5",SqlDbType.NVarChar){Value=cell.Value2.ToString() },
                        };
                    dbConnection.Query(query, parameters);
                }
            }
        }

        public void Dispose()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (excelRange == null || excelWorkbook == null || excelWorksheet == null)
            {
                return;
            }
            Marshal.ReleaseComObject(excelRange);
            Marshal.ReleaseComObject(excelWorksheet);
            excelWorkbook.Close();
            Marshal.ReleaseComObject(excelWorkbook);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
    }
}
