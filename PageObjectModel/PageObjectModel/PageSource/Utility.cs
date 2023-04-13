using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace PageObjectModel.PageSource
{
    public  class Utility
    {
        public IWebDriver driver;
       public Utility(IWebDriver driver) 
        {
            this.driver = driver;
        }
        public static void WaitForElementClickable(IWebElement element, int timeoutInSeconds , IWebDriver driver)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
            }
        }
    }

    public class ActionScrollPage
    {
        public IWebDriver driver;

        public ActionScrollPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static void scrollPageDown(int count, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            for (int i = 0; i < count; i++)
            {
                action.SendKeys(Keys.ArrowDown).Perform();
            }
        }

        public static void scrollPageUp(int count, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            for (int i = 0; i < count; i++)
            {
                action.SendKeys(Keys.ArrowUp).Perform();
            }
        }

    }
}
