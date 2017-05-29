using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.Article;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace Blog.UI.Tests
{
    [TestFixture] 
    public class UITests
    {
        private ChromeDriver driver;

        [SetUp]
        public void Init()
        {
            //this.driver = new InternetExplorerDriver();
            this.driver = new ChromeDriver();
        }

        [Test]
        public void CheckSiteLoad()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));


         //driver.Navigate().GoToUrl("@http://localhost:60634/Article/List");
            driver.Navigate().GoToUrl(BrowserHost.RootUrl);


            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
        [Test]

        public void CreateArticle()
        {
            var data = AccessExcelData<ArticleData>.GetTestData("ArticleData", "CreateArticle", "AddArticle");
            //asd.FillRegistrationForm(data);
        }
    }//в setup da si dobavia naviirane do site i logvane
}
