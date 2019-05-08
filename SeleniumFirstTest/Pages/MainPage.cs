using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirstTest.Pages
{
    class MainPage
    {
        private IWebDriver pageDriver;
        public MainPage(IWebDriver driver)
        {
            pageDriver = driver;
        }

        //"Search" button (with loop) - object
        public IWebElement SearchButton => pageDriver.FindElement(By.CssSelector("#search-button > svg"));

        //Click on "Search" button - method
        public void ClickSearch()
        {
            SearchButton.Click();
        }

        //"Search" Input field - object
        public IWebElement SearchInput => pageDriver.FindElement(By.Id("search-term"));

        // Input text for search - method
       
        public void SearchForText(string text)
        {
            SearchInput.SendKeys(text);
            SearchInput.SendKeys(Keys.Enter);
           
        }


    }
    }

