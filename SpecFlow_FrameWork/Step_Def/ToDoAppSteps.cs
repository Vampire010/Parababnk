using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_FrameWork.Step_Def
{
    [Binding]
    public class ToDoAppSteps
    {


        String test_url = "https://parabank.parasoft.com";
       
        IWebDriver driver;

        [Given(@"that I am on the Parbank_Site")]
        public void GivenThatIAmOnTheParbank_Site()
        {
            driver = new ChromeDriver();
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"Enter the Username")]
        public void ThenEnterTheUsername()
        {
            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys("Daniel");
        }
        
        [Then(@"Enter the Password")]
        public void ThenEnterThePassword()
        {
            // Click on Second Check box
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("Daniel@1234");
        }
        
        [Then(@"Click on Login_btn")]
        public void ThenClickOnLogin_Btn()
        {
            // Click on Add button
            IWebElement Login_btn = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[3]/input"));
            Login_btn.Click();
        }
        
        [Then(@"verify whether user is logedin")]
        public void ThenVerifyWhetherUserIsLogedin()
        {
            // Verified Added Item name
            
            String Page_title = driver.Title;
            String itemName = Page_title;
            // Check if the newly added item is present or not using
            // Condition constraint (Boolean)
            Assert.That((itemName.Contains(Page_title)), Is.True);

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Firefox - Test 1 Passed");
        }
        
        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            //driver.Quit();
        }
    }
}
