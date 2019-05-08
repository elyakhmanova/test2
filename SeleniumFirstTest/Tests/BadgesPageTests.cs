using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumFirstTest.Framework;
using SeleniumFirstTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Tests
{
    class BadgesPageTests
    {
        [Test]

        public void GoingToSeparateBadgePageTest()
        {

            IWebDriver driver = Settings.OpenBrowser();
            driver.Navigate().GoToUrl("https://automated-testing.info/badges");

            new BadgesPage(driver).ClickTroubleshooter();
            String url = driver.Url;
            Assert.True(url.Contains("troubleshooter"));
            driver.Quit();
        }
    }
}
