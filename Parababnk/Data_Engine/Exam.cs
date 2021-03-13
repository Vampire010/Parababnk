using ExcelDataReader;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parababnk.Data_Engine
{
    class Exam
    {
        string fileName = @"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\TestData.xlsx";
       // [Test]
        public void Open_Excel()
        {

            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
           
            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            //Get all the Tables
            DataTableCollection table = result.Tables;

            //Store it in DataTable
            DataTable resultTable = table["Sheet1"];

            //Loop through the rows in datatable
            foreach (DataRow dr in resultTable.Rows)
            {
                var name = dr["USERNAME"];
                Console.WriteLine(name);
                var age = dr["PASSWORD"];
                Console.WriteLine(age);
            }

        }
    }
}
