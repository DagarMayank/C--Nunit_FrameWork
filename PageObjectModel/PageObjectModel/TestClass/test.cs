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
        [AllureTag("SmokeTestCase")]
        [AllureSubSuite("Searchitem")]
        [TestCase("Iphone 12")]
        [TestCase("Panasonic AC")]
        [TestCase("Car Accessories")]
        public void verify_SearchFuncationality(String item)
        {
            
            //Navigated to Homepage
            Homepage hp = new Homepage(driver);
         /***Login Functionality is Commented Out because of Restriction from Amazon **/
            //   Assert.IsTrue(hp.IsIconAvatorVisible(),"User is Successfully logined to the Application");
            hp.searchBar(item);
            Thread.Sleep(2000);
             hp.viewSearchedItem(); 
        }
        
        [Test(Description = "Adding the Item to cart and Setting up the Quanity of item")
            ,Order(0),Category("QauntityOfItem")]
        [AllureStory("Changing the Qauntity")]
        [AllureTag("SmokeTestCase")]
        [TestCase("Iphone 12")]
        public void verify_OrderTheAddToCartItem(String item)
        {
            Homepage hp = new Homepage(driver);
            hp.searchBar(item);
            hp.viewSearchedItem();
            OrderItem orderItem = new OrderItem(driver);
            orderItem.addItemToCart();
            orderItem= new OrderItem(driver);
            ActionScrollPage actionScrollPage = new ActionScrollPage(driver);
            actionScrollPage.scrollPageUp(8);
            orderItem.navigateToCart();
            Random random = new Random();
            int value = random.Next(1, 9);
            Console.WriteLine("Random value is "+value);
            orderItem.setQuanity(value);
            Thread.Sleep(7000);
        }
       
        [Test(Description = "Change the Search Category of item from dropdown aside of Search Bar.Check for Mulitple Item"),
            Order(0),Category("SearchDropDown")]        
        [AllureStory("Searching Based On Category")]
        [AllureTag("SanityTestCase")]
        [TestCase("Books")]
        [TestCase("Beauty")]
        [TestCase("Amazon Fresh")]
        public void verify_searchCateogoryDropdown(String category)
        {
           
            //Navigated to Homepage
            Homepage hp = new Homepage(driver);
            hp.expandSearchDropDownBox(category);

        }
       
        [Test(Description = " To Change the Language of the Application "),
            Order(1),Category("LanguageChange")]
        [AllureStory("via Hovering over the Label, via Clicking on the Language Icon changing from the Radio Button ")]
        [AllureTag("SmokeTestCase")]
        [TestCase("हिन्दी", "English")]
        public void verify_LanguageChangeOfApplication(String lang1, String lang2)
        {
           
            //Navigated to Homepage
            Homepage hp = new Homepage(driver);
            hp.hoverOnLanguageIcon();
            hp.chooseLanguageFromHoveredIcon(lang1);
            hp.hoverOnLanguageIcon();
            hp.chooseLanguageFromHoveredIcon(lang2);

        }
    }
}
