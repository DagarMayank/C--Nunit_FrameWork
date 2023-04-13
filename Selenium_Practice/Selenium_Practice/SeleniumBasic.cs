using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V109.SystemInfo;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace Selenium_Practice
{
    [TestClass]
    public class Selenium_Basic
    {
        [TestMethod]
        public void InvokeBrowser()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Home\Downloads\chromedriver_win32");
            driver.Navigate().GoToUrl("https://www.google.com/search?q=gmail&oq=gmail&aqs=chrome..35i39j69i57j0i433i512j0i131i433i512j69i65l2j69i61j69i65.3181j0j7&sourceid=chrome&ie=UTF-8");
            driver.Manage().Window.Maximize();

          IList<IWebElement> l =  driver.FindElements(By.XPath("//a/h3"));
           foreach(WebElement var in l)
            {
                Thread.Sleep(5000);
                var.Click();
                Thread.Sleep(2000);
                driver.Navigate().Back();
                
            }
            
            driver.Quit();
        }
        [TestMethod]
        public void getPageTitle() 
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Home\Downloads\chromedriver_win32");
                driver.Navigate().GoToUrl("https://www.FaceBook.com");
                 driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
            driver.Quit();
        }

    }
}
