using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace PageObjectModel.PageSource
{
    public  class Utility
    {
        public IWebDriver driver;
         WebDriverWait wait;
       public Utility(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        public  void WaitForElementClickable(By locator)        {
            
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                
        }
    }

    public class ActionScrollPage
    {
        public IWebDriver driver;
        Actions action;
        public ActionScrollPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            action = new Actions(driver);
        }

        public  void scrollPageDown(int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                action.SendKeys(Keys.ArrowDown).Perform();
            }
        }

        public  void scrollPageUp(int count)
        {
            for (int i = 0; i < count; i++)
            {
                action.SendKeys(Keys.ArrowUp).Perform();
            }
        }

    }
}
