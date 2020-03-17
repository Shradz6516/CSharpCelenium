using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit.DataDriverTesting
{
    class ExcelUtil
    {
        public DataTable ExcelToDataTable(string fileName)
        {
            FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet dataSet = excelReader.AsDataSet();
            DataTableCollection dataTableCollection = dataSet.Tables;
            DataTable dataTable = dataTableCollection["Sheet1"];
            return dataTable;
        }

        List<DataCollection> dataCollection = new List<DataCollection>();
        public void DataTableToCollection(string fileName)
        {
            DataTable dataTable = ExcelToDataTable(fileName);
            for(int row = 1;row <= dataTable.Rows.Count;row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    DataCollection dc = new DataCollection()
                    {
                        rowNum = row,
                        colName = dataTable.Columns[col].ColumnName,
                        colValue = dataTable.Rows[row - 1][col].ToString()
                    };
                    dataCollection.Add(dc);
                }
            }
        }

        public string ReadDataFromCollection(int row, string colName)
        {
            string res = (from dc in dataCollection
                          where dc.colName == colName && dc.rowNum == row
                          select dc.colValue).SingleOrDefault();

            return res.ToString();

        }
    }

    public class DataCollection
    {
        public int rowNum { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }
}
