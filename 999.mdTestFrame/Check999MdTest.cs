using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_999.md.core;

namespace Test_999.md._999.mdTestFrame
{
    internal class Check999MdTest : BaseTest
    {
        [Test]
        public void testTitle()
        {
            ResultPage resultPage = new MainPage()
                .search()
                .clickToResult();

            string test = resultPage.getTitle();

            Assert.True(test.Contains("тег"));
        }

        [Test]
        public void testLogin()
        {
            new MainPage()
                .enterLoginPage()
                .login();
        }
    }
}
