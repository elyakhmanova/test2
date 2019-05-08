using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Pages
{
    class BadgesPage
    {
        private IWebDriver pageDriver;
        public BadgesPage(IWebDriver driver)
        {
            pageDriver = driver;
        }

        // "Troubleshooter" element
        public IWebElement TroubleShooterElement => pageDriver.FindElement(By.CssSelector("#ember17 > div:nth-child(2) > a:nth-child(1)"));

        // Click on "Troubleshooter" element
        public void ClickTroubleshooter()
        {
            TroubleShooterElement.Click();
        }
    }
}
