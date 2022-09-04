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
    public class AfterLoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"m__user_panel\"]/div")]
        private IWebElement personalAreaButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"m__user_panel\"]/div/div/ul/li[6]/a")]
        private IWebElement profileButton;

        public AfterLoginPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public PersonalAreaPage personalArea()
        {
            personalAreaButton.Click();
            profileButton.Click();
            return new PersonalAreaPage();
        }

    }
}
