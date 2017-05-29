using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace Blog.UI.Tests
{
    public class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private string url = @"http://localhost:60634/Article/List";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(60));
        }

        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }

        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }
        }

        public string URL
        {
            get
            {
                return this.url;
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }
    }
}

//{
//    public class BasePage
//    {
//        protected string url = ConfigurationManager.AppSettings["URL"];
//        private IWebDriver driver;
//        private WebDriverWait wait;

//        public BasePage(IWebDriver driver)
//        {

//            this.driver = driver;
//            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
//        }

//        public IWebDriver Driver
//        {
//            get
//            {
//                return this.driver;
//            }
//        }

//        public WebDriverWait Wait
//        {
//            get
//            {
//                return this.wait;
//            }
//        }
//    }
//}
