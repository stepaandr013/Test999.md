using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Test_999.md.core;
using Test_999.md.settings;

namespace Test_999.md._999.mdTestFrame
{
    internal class MainPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "js-search-input")]
        private IWebElement searchInput;

        public MainPage()
        {
            driver.Navigate().GoToUrl(TestSettings.URL);
            PageFactory.InitElements(driver, this);
        }

        public SearchPage search()
        {
            searchInput.SendKeys(TestSettings.SEARCH_ITEM);
            searchInput.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            return new SearchPage();
        }
    }
}
