using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSeleniumTests.PageObjects
{
    class LoginPage : Page
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        private readonly By loginInput = By.Id("user-name");
        private readonly By passwordInput = By.Id("password");
        private readonly By loginButton = By.Id("login-button");

        public LoginPage InsertLogin(string login)
        {
            Driver.FindElement(loginInput).SendKeys(login);
            return this;
        }
        public LoginPage InsertPassword(string password)
        {
            Driver.FindElement(passwordInput).SendKeys(password);
            return this;
        }
        public HomePage ClickLoginButton()
        {
            Driver.FindElement(loginButton).Click();
            return new HomePage(Driver);
        }
    }
}
