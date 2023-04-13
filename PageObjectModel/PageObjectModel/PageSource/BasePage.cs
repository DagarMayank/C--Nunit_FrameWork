using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModel.PageSource
{
    public class BasePage
    {
        public IWebDriver driver;

        [SetUp]
        public void invokeBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            driver = new ChromeDriver(@"C:\Users\Home\Downloads\chromedriver_win32", options);
            driver.Url = "https://www.amazon.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

         //   LoginPage lp = new LoginPage(driver);
         //   lp.clickSignInLabel();
         //   lp.sendUserName("dagarmayank9728@gmail.com", "India@1234");
        }

        [TearDown]
        public void closeBrowser() 
        {
               driver.Quit();
        }

       
    }
}