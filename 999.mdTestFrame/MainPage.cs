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
        // For title test
        [FindsBy(How = How.Id, Using = "js-search-input")]
        private IWebElement searchInput;

        //For login test
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/header/div[1]/nav/ul/li[2]/a")]
        private IWebElement loginButton;

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

        public LoginPage enterLoginPage()
        {
            loginButton.SendKeys(Keys.Enter);
            return new LoginPage();
        }

    }
}
