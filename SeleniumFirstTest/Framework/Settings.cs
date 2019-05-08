using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Framework
{
    class Settings
    {
        public static IWebDriver OpenBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
          
            return driver;

        }
    }
}
