using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_999.md.core
{
    abstract public class BasePage
    {
        protected static IWebDriver driver;

        public static void setDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
