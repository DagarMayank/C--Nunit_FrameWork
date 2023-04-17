using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.PageSource
{
    public class Homepage
    {
        public IWebDriver driver;
        Actions ac;
        public Utility utils;

       [FindsBy(How = How.XPath, Using = "//div[@id='glow-ingress-block']")]
        private IWebElement iconAvatar;
        By loc_iconAvatar = By.XPath("//div[@id='glow-ingress-block']");

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement txtsearchBar;
        By loc_txtsearchBar = By.Id("twotabsearchtextbox");

        [FindsBy(How = How.XPath, Using = "//h2/a/span")]
        private IList<IWebElement> lnKOfAllItem;
        By loc_lnKOfAllItem = By.XPath("//h2/a/span");

        [FindsBy(How = How.Id, Using = "searchDropdownBox")]
        private IWebElement searchDropDownBox;
        By loc_searchDropDownBox = By.Id("searchDropdownBox");

        [FindsBy(How = How.XPath, Using = "//span[@class='icp-nav-link-inner']")]
        private IWebElement lblLanguageIcon;
        By loc_lblLanguageIcon = By.XPath("//span[@class='icp-nav-link-inner']");

        [FindsBy(How = How.Id, Using = "nav-logo-sprites")]
        private  IWebElement homepageNavigation;
        By loc_homepageNavigation = By.Id("nav-logo-sprites");

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            utils = new Utility(driver);
        }
        public  void navigateToHomePage()
        {
            utils.WaitForElementClickable(loc_homepageNavigation);
            homepageNavigation.Click();
        }
        public bool IsIconAvatorVisible()
        {
            utils.WaitForElementClickable(loc_iconAvatar);
            return iconAvatar.Displayed;
        }
        public void searchBar()
        {
             ac = new Actions(driver);
            ac.MoveToElement(txtsearchBar).Click().SendKeys("Iphone 12" + Keys.Enter).Build().Perform();
        }

        public void viewSearchedItem()
        {
            String currentWindow = driver.CurrentWindowHandle.ToString();
            utils.WaitForElementClickable(loc_lnKOfAllItem);
            lnKOfAllItem[0].Click();
            var newWindowHandle = driver.WindowHandles[1];
            driver.SwitchTo().Window(newWindowHandle);
            
        }
       

        public void expandSearchDropDownBox(String var)
        {
            utils.WaitForElementClickable(loc_searchDropDownBox);
            searchDropDownBox.Click();
            SelectElement sel = new SelectElement(searchDropDownBox);
            sel.SelectByText(var);
        }

        public void hoverOnLanguageIcon()
        {
            ac = new Actions(driver);
            utils.WaitForElementClickable(loc_homepageNavigation);
            homepageNavigation.Click();
            Thread.Sleep(2000);
            ac.MoveToElement(lblLanguageIcon).Perform();
            Thread.Sleep(2000);
        }

        public void chooseLanguageFromHoveredIcon(String var)
        {
            ac = new Actions(driver);
            Thread.Sleep(2000);
            IWebElement lanuage = 
            driver.FindElement(By.XPath("//div[@id='nav-flyout-icp']//a//span[@dir='ltr' and text()='" + var + "']/../i"));
            Thread.Sleep(2000);
            ac.Click(lanuage).Perform();              
        }
     }
}
