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
        public IWebDriver driver;
        Utility utils;

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        private IWebElement btnAddtoCart ;
        By loc_btnAddtoCart = By.Id("add-to-cart-button");

        [FindsBy(How = How.XPath, Using = "//span[@id='nav-cart-count']")]
        private IWebElement clickCARTIcon;
        By loc_clickCartIcon = By.XPath("//span[@id='nav-cart-count']");

        [FindsBy(How = How.Id, Using = "a-autoid-0-announce")]
        private IWebElement quanityDropDown;
        By loc_quanityDropDown = By.Id("a-autoid-0-announce");

        [FindsBy(How = How.Id, Using = "attach-sidesheet-view-cart-button-announce")]
        private IWebElement btnCart_sideSheetCart;
        By loc_btnCart_sideSheetCart = By.Id("attach-sidesheet-view-cart-button-announce");

        public OrderItem(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            utils = new Utility(driver);
        }
        
        public void addItemToCart()
        {
            
            
            utils.WaitForElementClickable(loc_btnAddtoCart);
            btnAddtoCart.Click();
            Homepage hp = new Homepage(driver);
            hp.driver.SwitchTo().Window(driver.WindowHandles[0]);
            
        }
        public void navigateToCart()
        {
            utils.WaitForElementClickable(loc_clickCartIcon);
            clickCARTIcon.Click();
        }

        public void setQuanity(int x)
        {
            utils.WaitForElementClickable(loc_quanityDropDown);
            quanityDropDown.Click();
            Thread.Sleep(2000);
            IWebElement quant =
                driver.FindElement(By.XPath("//ul[@role='listbox']//a[@id='quantity_" + x+"']"));
            quant.Click();

        }
    }
}
