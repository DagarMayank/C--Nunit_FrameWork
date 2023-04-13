using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.PageSource
{
    public class OrderItem
    {
        IWebDriver driver;

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        private IWebElement btnAddtoCart;

        [FindsBy(How = How.XPath, Using = "//span[@id='nav-cart-count']")]
        private IWebElement clickCARTIcon;

        [FindsBy(How = How.XPath, Using = "//i[@class='a-icon a-icon-dropdown']")]
        private IWebElement quanityDropDown;

        [FindsBy(How = How.Id, Using = "attach-sidesheet-view-cart-button-announce")]
        private IWebElement btnCart_sideSheetCart;

        public OrderItem(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public void addItemToCart(String var)
        {
            
            Thread.Sleep(2000);
            btnAddtoCart.Click();
            var newWindowHandle = driver.WindowHandles[1];
            driver.SwitchTo().Window(newWindowHandle).Close();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(var);
            
        }
        public void navigateToCart()
        {
            Thread.Sleep(2000);
            clickCARTIcon.Click();
        }

        public void setQuanity(int x)
        {
            quanityDropDown.Click();
            Thread.Sleep(2000);
            IWebElement quant =
                driver.FindElement(By.XPath("//div[@id='a-popover-2']//a[@id='quantity_"+x+"']"));
            quant.Click();

        }
    }
}
