using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_999.md.core;

namespace Test_999.md._999.mdTestFrame
{
    internal class ResultPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "js-categories-toggle")]
        private IWebElement title;

        public ResultPage()
        {
            PageFactory.InitElements(driver, this);
        }

        /*public ResultPage ttt()
        {
            title.Click();
            Thread.Sleep(5000);
            *//*string test = title.Text;*//*
            return this;
        }*/

        public string getTitle()
        {
            return title.Text;
        }

    }
}
