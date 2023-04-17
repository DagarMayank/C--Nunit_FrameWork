using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.PageSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.TestClass
{

    // [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class test : BasePage
    {
        /**
         * Search Item In search Box and open the First Link of Project
         */
        [Test,Order(-1),Category("Search")]
        public void verify_SearchFuncationality()
        {
            
            //Navigated to Homepage
            Homepage hp = new Homepage(driver);
         /***Login Functionality is Commented Out because of Restriction from Amazon **/
            //   Assert.IsTrue(hp.IsIconAvatorVisible(),"User is Successfully logined to the Application");
            hp.searchBar();
            Thread.Sleep(2000);
             hp.viewSearchedItem(); 
        }
        [Test,Order(0),Category("QauntityOfItem")]
        /**
         * Adding the Item to cart and Setting up the Quanity of item 
         */
        public void verify_OrderTheAddToCartItem()
        {
            Homepage hp = new Homepage(driver);
            hp.searchBar();
            hp.viewSearchedItem();
            OrderItem orderItem = new OrderItem(driver);
            orderItem.addItemToCart();
            orderItem= new OrderItem(driver);
            ActionScrollPage actionScrollPage = new ActionScrollPage(driver);
            actionScrollPage.scrollPageUp(8);
            orderItem.navigateToCart();
            orderItem.setQuanity(2);
        }
        /**
         * Change the Search Category of item from dropdown aside of Search Bar. 
         * Check for Mulitple Item
         */
        [Test,Order(0),Category("SearchDropDown")]
        public void verify_searchCateogoryDropdown()
        {
           
            //Navigated to Homepage
            Homepage hp = new Homepage(driver);
            hp.expandSearchDropDownBox("Car & Motorbike");

        }
        /**
         * To Change the Language of the Application  
         * i>  via Hovering over the Label  
         * ii> via Clicking on the Language Icon changing from the Radio Button
         */
        [Test,Order(1),Category("LanguageChange")]
        public void verify_LanguageChangeOfApplication()
        {
           
            //Navigated to Homepage
            Homepage hp = new Homepage(driver);
            hp.hoverOnLanguageIcon();
            hp.chooseLanguageFromHoveredIcon("हिन्दी");
            hp.hoverOnLanguageIcon();
            hp.chooseLanguageFromHoveredIcon("English");

        }
    }
}
