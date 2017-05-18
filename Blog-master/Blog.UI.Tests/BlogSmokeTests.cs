using Blog.UI.Tests.Pages.HomePage;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class BlogSmokeTests
    {
        [Test]
        public void BlogLogoDisplayedRightMessage()
        {
            var homePage = new HomePage(BrowserHost.Instance.Application.Browser);

            homePage.NavigateTo();

            homePage.AssertLogo();
        }


    }
}
