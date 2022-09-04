using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_999.md.core;
using Test_999.md.settings;

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
            PersonalAreaPage personalAreaPage = new MainPage()
                .enterLoginPage()
                .login()
                .personalArea();

            Assert.AreEqual(PasswordLoginSettings.LOGIN, personalAreaPage.getUserName());
        }
    }
}
