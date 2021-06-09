using ExampleSeleniumTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSeleniumTests.Tests
{
    [TestFixture]
    class SaucePageTest : TestBase
    {
        private LoginPage loginPage;
        [Test]
        public void TestPossibilityLoginToPage()
        {
            string login = "standard_user";
            string password = "secret_sauce";
            Uri entryUrl = new Uri("https://www.saucedemo.com/inventory.html");

            loginPage = new LoginPage(driver);

            loginPage.InsertLogin(login)
                .InsertPassword(password)
                .ClickLoginButton();

            Assert.AreEqual(entryUrl, driver.Url, "The expected result is not equal to the actual result");
        }

    }
}
