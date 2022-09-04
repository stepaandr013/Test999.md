using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V102.WebAuthn;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_999.md.core;
using Test_999.md.settings;

namespace Test_999.md._999.mdTestFrame
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='login']")]
        private IWebElement loginInput;

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement passwordInput;
        
        [FindsBy(How = How.XPath, Using = "//button[@class='login__form__footer__submit']")]
        private IWebElement submitLogin;


        public LoginPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public AfterLoginPage login()
        {
            loginInput.SendKeys(PasswordLoginSettings.LOGIN);
            passwordInput.SendKeys(PasswordLoginSettings.PASSWORD);
            submitLogin.Click();
            return new AfterLoginPage();
        }

    }
}
