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
    public class PersonalAreaPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/section/div/div/div[1]/div[1]/div[2]/div")]
        private IWebElement userName;

        public PersonalAreaPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public string getUserName()
        {
            return userName.Text;
        }
    }
}
