using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace PageObjectModel.PageSource
{
    internal class LoginPage 
    {
        private IWebDriver driver;

        WebDriverWait wait;
        

        [FindsBy(How =How.XPath , Using = "//a[@id='nav-link-accountList']")]
        private IWebElement lblSignIn;

        [FindsBy(How = How.XPath, Using = "//input[@id='ap_email']")]
        private IWebElement txtUsername;

        [FindsBy(How =How.XPath, Using = "//input[@id='continue']")]
        private IWebElement btnContinue;

        [FindsBy(How = How.XPath, Using = "//input[@id='ap_password']")]
        private IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        private IWebElement btnSignin;


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            // wait for page to finish loading
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            

        }
        

        public void clickSignInLabel()
        {
            //           WaitDriver.WaitForElementVisible(lblSignIn, 4, driver);
            Thread.Sleep(4000); 
            lblSignIn.Click();
        }

        public void sendUserName(string userName , string password)
        { 
            //          WaitDriver.WaitForElementVisible(txtUsername, 20 , driver);  
            txtUsername.SendKeys(userName);
            btnContinue.Click();
            txtPassword.SendKeys(password);
            btnSignin.Click();

        }
    }
}
