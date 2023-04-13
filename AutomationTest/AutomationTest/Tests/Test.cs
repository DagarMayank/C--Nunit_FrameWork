using AutomationTest.PageSources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationTest.Tests
{
    public class Tests : Baseclass
    {

        
        [Test]
        public void Test1()
        {
            LoginApplication loginApplication = new LoginApplication(driver);
            loginApplication.clickSignIn();
        }

        
    }
}