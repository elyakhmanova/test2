using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Pages
{
    class TopPage
    {
        private IWebDriver pageDriver;
        public TopPage(IWebDriver driver)
        {
            pageDriver = driver;
        }

        // Period Menu - object 

        public IWebElement PeriodMenu => pageDriver.FindElement(By.CssSelector("h2.selected-name > span:nth-child(1)"));

        //Click on Period Menu - method
        public void ClickAllPeriods()
        {
            PeriodMenu.Click();
        }

        //Dropdown Menu - object
        public IWebElement AllTheTime => pageDriver.FindElement(By.CssSelector("#ember154 > span:nth-child(2)"));

        //Click on Period Menu - method
        public void ClickAllTheTime()
        {
            PeriodMenu.Click();
            AllTheTime.Click();
        }




    }
}
