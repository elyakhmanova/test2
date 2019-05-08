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
    class ExpandedSearchTests
    {
        [Test]
        public void SearchTag()
        {
            IWebDriver driver = Settings.OpenBrowser();
            driver.Navigate().GoToUrl("https://automated-testing.info/search?expanded=true");

            new ExpandedSearchPage(driver).ClicSearchForTags("java");
            new ExpandedSearchPage(driver).ClickShowButton();
            String url = driver.Url;
            Assert.False(url.Contains("java"));
            driver.Quit();
        }
    
    }
}
