using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_999.md.core;

namespace Test_999.md._999.mdTestFrame
{
    internal class SearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/section/div/section/div/div/div[1]/div/ul[1]/li[8]/div[2]/a")]
        private IWebElement firstSearchResult;

        public SearchPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public ResultPage clickToResult()
        {
            Thread.Sleep(2000);
            firstSearchResult.Click();
            Thread.Sleep(2000);
            return new ResultPage();
        }

    }
}
