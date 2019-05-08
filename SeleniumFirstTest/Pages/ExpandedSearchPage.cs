using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Pages
{
    class ExpandedSearchPage
    {
        private IWebDriver pageDriver;
        public ExpandedSearchPage(IWebDriver driver)
        {
            pageDriver = driver;
        }

        // field to input tags - object
        public IWebElement InputTags => pageDriver.FindElement(By.CssSelector("#ember30"));

        // input text into tags field - method
        public void ClicSearchForTags(string text)
        {
            InputTags.SendKeys(text);
            InputTags.SendKeys(Keys.Enter);
        }

        // button to show search result (button placed under right block with expanded serch parameters) - object
        public IWebElement ShowButton => pageDriver.FindElement(By.CssSelector("#ember42"));

        // click on the button to search - method
        public void ClickShowButton()
        {
            ShowButton.Click();
        }
    }
}
