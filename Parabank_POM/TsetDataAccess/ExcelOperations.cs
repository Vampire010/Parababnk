
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Parabank_POM.TsetDataAccess
{
    public  class ExcelOperations
    { 
        private  DataTable ExcelToDataTable(string filename)
        {
           
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);


             DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                      UseHeaderRow = true
                }
            } );

            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;
        }

         List<DataCollectionss> dataCol = new List<DataCollectionss>();

        public  void PopulateCollection(string filename)
        {    
                DataTable table = ExcelToDataTable(filename);

                for (int row = 0; row < table.Rows.Count; row++)
                {

                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        DataCollectionss dtTable = new DataCollectionss()
                        {
                            rowNumber = row,
                            colName = table.Columns[col].ColumnName,
                            colValue = table.Rows[row - 1][col].ToString()
                        };
                    dataCol.Add(dtTable);
                    }
                }            
        }

        public  string ReadData(int rowNumber, string columnName)
        {
            try
            {
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                return data.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problum in ReadingData");
                return null;
            }
        }
    }
}
