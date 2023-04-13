using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.PageSources
{
    public class Baseclass
    {
        public  IWebDriver driver;


        
       
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\Home\Downloads\chromedriver_win32");
            driver.Navigate().GoToUrl("https://www.amazon.in");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

       

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
