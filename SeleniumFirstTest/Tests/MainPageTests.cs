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



namespace SeleniumFirstTest
{

        class MainPageTests
    {
        [Test]
        public void SearchTest()
        {

            IWebDriver driver = Settings.OpenBrowser();
            driver.Navigate().GoToUrl("https://automated-testing.info/");

            new MainPage(driver).ClickSearch();
            new MainPage(driver).SearchForText("test");
            String url = driver.Url;
            Assert.True(url.Contains("test"));
            driver.Quit();
            
        }


    }
}
