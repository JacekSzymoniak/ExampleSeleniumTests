using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSeleniumTests.PageObjects
{
    class HomePage : Page
    {
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        private readonly By twitterButton = By.XPath("/html/body/div/div/footer/ul/li[1]/a");
        private readonly By facebookButton = By.ClassName("social_facebook");
        private readonly By linkedinButton = By.ClassName("social_linkedin");

        public HomePage ClickTwitterButton()
        {
            Driver.FindElement(twitterButton).Click();
            return this;
        }

        public HomePage ClickFacebookButton()
        {
            Driver.FindElement(facebookButton).Click();
            return this;
        }

        public HomePage ClickLinkedinButton()
        {
            Driver.FindElement(linkedinButton).Click();
            return this;
        }
    }
}
