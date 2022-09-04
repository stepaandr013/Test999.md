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
        public AfterLoginPage()
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
