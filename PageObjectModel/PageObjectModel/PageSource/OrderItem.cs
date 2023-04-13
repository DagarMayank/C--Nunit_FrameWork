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

        [FindsBy(How = How.Id, Using = "a-autoid-0-announce")]
        private IWebElement quanityDropDown;

        [FindsBy(How = How.Id, Using = "attach-sidesheet-view-cart-button-announce")]
        private IWebElement btnCart_sideSheetCart;

        public OrderItem(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public void addItemToCart()
        {
            
            Thread.Sleep(2000);
            btnAddtoCart.Click();
            Thread.Sleep(3000);
            Homepage hp = new Homepage(driver);
            hp.driver.SwitchTo().Window(driver.WindowHandles[0]);
            
        }
        public void navigateToCart()
        {
            Thread.Sleep(2000);
            clickCARTIcon.Click();
        }

        public void setQuanity(int x)
        {
            Thread.Sleep(3000);
            quanityDropDown.Click();
            Thread.Sleep(2000);
            IWebElement quant =
                driver.FindElement(By.XPath("//ul[@role='listbox']//a[@id='quantity_" + x+"']"));
            quant.Click();

        }
    }
}
