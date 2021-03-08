using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Reports
{
    class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;

        public static ExtentReports extent;

        public static ExtentReports getInstance()
        {
            if (extent == null)
            { 
                string reportpath = @"C:\Users\91973\source\repos\Parababnk\Parababnk\Tests\Test.html";
              
                htmlReporter = new ExtentHtmlReporter(reportpath );
                extent = new ExtentReports();
                
                extent.AttachReporter(htmlReporter);
              
                extent.AddSystemInfo("OS","WINDOWS");
                extent.AddSystemInfo("HOST NAME", "GIRISH");
                extent.AddSystemInfo("ENV", "ALPHA");
                extent.AddSystemInfo("USERNAME", "GIRISH_RATHODE");

                string extentconfigpath = @"C:\Users\91973\source\repos\Parababnk\Parababnk\Reports\MyOwnReport.html";
                htmlReporter.LoadConfig(extentconfigpath);
            }
            return extent;
        }
    }
}
