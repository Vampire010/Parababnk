
using NUnit.Framework;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace Parababnk.POM
{
    public class UserData
    {
    //    [Test]
        public void Credentials(string usrnam , string usrpsw , string res )
        {

            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("User_Credntials_Testing_Report");
               

                var headerRow = new List<string[]>()
                {
                    new string[] { "Username", "Password", "Result" }
                };


                // Determine the header range (e.g. A1:D1)
                string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";     

                // Target a worksheet
                var worksheet = excel.Workbook.Worksheets["User_Credntials_Testing_Report"];

                
                    for (int i = 1; i <= 5; i++)
                    {
                        worksheet.Cells["A"+i ].Value = usrnam;
                        worksheet.Cells["B"+i ].Value = usrpsw;
                        worksheet.Cells["C"+ i].Value = res;
                    // Popular header row data
                    worksheet.Cells[headerRange].LoadFromArrays(headerRow);
                    FileInfo excelFile = new FileInfo(@"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\TestData.xlsx");
                    excel.SaveAs(excelFile);
                }
                
            }
         
        }
    }
}
