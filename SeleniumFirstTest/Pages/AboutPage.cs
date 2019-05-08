using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Pages
{
    class AboutPage
    {
        private IWebDriver pageDriver;
        public AboutPage(IWebDriver driver)
        {
            pageDriver = driver;
        }


        //Admin's avatar - object
        public IWebElement AdminUserpic => pageDriver.FindElement(By.CssSelector("#ember73 > div.user-image > div > a > img"));

        // Click on Admin's avatar - method
        public void ClickAvatar() 
        {
            AdminUserpic.Click();
        }

        //UserCard frame - object
        public IWebElement UserCardFrame => pageDriver.FindElement(By.CssSelector("#user-card"));

        //Find UserCard - method
        public void FindUserCard()
        {
            UserCardFrame.Click();
        }

    }
}
