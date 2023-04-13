﻿using NUnit.Framework;
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
            Assert.IsTrue(hp.IsIconAvatorVisible(),"User is Successfully logined to the Application");
            hp.searchBar();
            Thread.Sleep(2000);
             hp.viewSearchedItem(); 
        }
        [Test]
        public void verify_OrderTheAddToCartItem()
        {
            Homepage hp = new Homepage(driver);
            Assert.IsTrue(hp.IsIconAvatorVisible(), "User is Successfully logined to the Application");
            hp.searchBar();
            Thread.Sleep(2000);
            String currentWindow = hp.viewSearchedItem();
            OrderItem orderItem = new OrderItem(driver);
            orderItem.addItemToCart("currentWindow");
          //  orderItem.navigateToCart();
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
            Thread.Sleep(2000);
            hp.hoverOnLanguageIcon();
            hp.chooseLanguageFromHoveredIcon("English");

        }
    }
}