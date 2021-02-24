using System;

public class ReportingManager
{

	private static readonly ExtentReports _instance = new ExtentReports(TestContext.CurrentContext.TestDirectory + "\\TestResults.html");

	static ReportingManager() { }
	private ReportingManager() { }
    public static ExtentReports Instance
    {
        get
        {
            return _instance;
        }
    }
}
