

using NUnit.Framework;
using OfficeOpenXml;
using System;
using System.IO;

namespace Parababnk.Data_Engine
{
   public class ExcelApiTest
    {
      //  [Test]
        public  void boo()
        {
            using (var package = new ExcelPackage(new FileInfo(@"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\TestData.xlsx")))
            {
                var firstSheet = package.Workbook.Worksheets["Sheet1"];
                Console.WriteLine("Sheet 1 Data");
                Console.WriteLine($"Cell A2 Value   : {firstSheet.Cells["A2"].Text}");
                Console.WriteLine($"Cell A2 Color   : {firstSheet.Cells["A2"].Style.Font.Color.LookupColor()}");
                Console.WriteLine($"Cell B2 Formula : {firstSheet.Cells["B2"].Formula}");
                Console.WriteLine($"Cell B2 Value   : {firstSheet.Cells["B2"].Text}");
                Console.WriteLine($"Cell B2 Border  : {firstSheet.Cells["B2"].Style.Border.Top.Style}");
                Console.WriteLine("");

             }
        }
    }
}
