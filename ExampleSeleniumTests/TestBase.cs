using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSeleniumTests
{
    class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        protected void Setup()
        {
            driver = DriverFactory.ReturnDriver(EDriverType.Chrome);
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(TestSettings.SauceDemoURL);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
    }
}
