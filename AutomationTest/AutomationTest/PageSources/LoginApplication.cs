using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTest.PageSources
{
     class LoginApplication
    {
        [FindsBy(How = How.XPath, Using = "//a[@id='nav-link-accountList']")]
        private IWebElement lblSignIn;

        private IWebDriver driver;

        

        public LoginApplication(IWebDriver driver)
        {
            this.driver = driver;
            
           

        }

      

       

        public void clickSignIn() {
            Thread.Sleep(4000);
            lblSignIn.Click();
            Thread.Sleep(4000);
        }
    }
}
