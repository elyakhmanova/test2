using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFirstTest.Framework;
using SeleniumFirstTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Tests
{
        class AboutPageTests
    {
        [Test]
        public void OpenAdminCard()

        {
            IWebDriver driver = Settings.OpenBrowser();
            driver.Navigate().GoToUrl("https://automated-testing.info/about");
            
            // need method and assertion to verify that user card appears
            

            driver.Quit();
        }
    }
}
