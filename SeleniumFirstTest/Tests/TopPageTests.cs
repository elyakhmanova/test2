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
    public class TopPageTests
    {
        [Test]
        public void SelectMostPopularTopics()
        {

            IWebDriver driver = Settings.OpenBrowser();
            driver.Navigate().GoToUrl("https://automated-testing.info/top");
            new TopPage(driver).ClickAllTheTime();
            String url = driver.Url;
            Assert.True(url.Contains("all"));
            driver.Quit();

        }
    }
}
