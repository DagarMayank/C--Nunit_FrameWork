using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.PageSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace PageObjectModel.TestClass
{

    //[Parallelizable(ParallelScope.All)]
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Basic Functionality")]
    [AllureFeature("Item Request")]
    public class test : BasePage
    {
        
        [Test(Description = "Search Item In search Box and open the First Link of Project")
            ,Order(-1),Category("Search")]
        [AllureStory("Searching Item and Opening in New Window")]
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
        
        [Test(Description = "Adding the Item to cart and Setting up the Quanity of item")
            ,Order(0),Category("QauntityOfItem")]
        [AllureStory("Changing the Qauntity")]
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
       
        [Test(Description = "Change the Search Category of item from dropdown aside of Search Bar.Check for Mulitple Item"),
            Order(0),Category("SearchDropDown")]
        [AllureStory("Searching Based On Category")]
        public void verify_searchCateogoryDropdown()
        {
           
            //Navigated to Homepage
            Homepage hp = new Homepage(driver);
            hp.expandSearchDropDownBox("Car & Motorbike");

        }
       
        [Test(Description = " To Change the Language of the Application "),
            Order(1),Category("LanguageChange")]
        [AllureStory("via Hovering over the Label, via Clicking on the Language Icon changing from the Radio Button ")]
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
