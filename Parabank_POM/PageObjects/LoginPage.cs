using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Parabank_POM.TsetDataAccess;


namespace Parabank_POM.TestCases
{
  public  class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "log")]
        [CacheLookup]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "pwd")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        [CacheLookup]
        private IWebElement Submit { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        public void LoginToApplication(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);
            UserName.SendKeys(userData.Username);
            Password.SendKeys(userData.Password);
            Submit.Submit();
        }


    }
}
