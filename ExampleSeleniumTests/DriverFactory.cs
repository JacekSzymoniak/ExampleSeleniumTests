using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSeleniumTests
{
    public enum EDriverType
    {
        Chrome,
        Firefox,
        Edge
    }
    public static class DriverFactory
    {
        public static IWebDriver ReturnDriver(EDriverType driverType)
        {
            IWebDriver driver;
            switch(driverType)
            {
                case EDriverType.Chrome:
                    driver = new ChromeDriver();
                    break;
                case EDriverType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case EDriverType.Edge:
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(driverType), driverType, null);
            }

            return driver;
        }
    }
}
