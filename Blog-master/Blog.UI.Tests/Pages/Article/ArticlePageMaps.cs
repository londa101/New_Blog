using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Blog.UI.Tests.Pages.Article
{
    public partial class ArticlePage
    {
        public IWebElement RegisterLink
        {
            get
            {
                return this.Driver.FindElement(By.Id("registerLink"));
            }
        }
        public IWebElement LoginLink
        {
            get
            {
                return this.Driver.FindElement(By.Id("loginLink"));
            }
        }
        public IWebElement CreateLink
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector(".nav > li:nth-child(1) > a:nth-child(1)"));
            }
        }

        public IWebElement ManageLink
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector(".nav > li:nth-child(2) > a:nth-child(1)"));
            }
        }

        public IWebElement LogoffLink
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector(".nav > li:nth-child(3) > a:nth-child(1)"));
            }
        }
        
        public IWebElement CreateArticle
        {
            get
            {
                return this.Driver.FindElement(By.Id(".well > h2:nth-child(1)"));
            }
        }

        public IWebElement TitleField
        {
            get
            {
                return this.Driver.FindElement(By.Id("Title"));
            }
        }

        public IWebElement ContentField
        {
            get
            {
                return this.Driver.FindElement(By.Id("Content"));
            }
        }
        public IWebElement CancelButton
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector("a.btn"));
            }
        }

        public IWebElement CreateButton
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector("input.btn"));
            }
        }

        public IWebElement HelloWorldArticle
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector("div.col-sm-6:nth-child(1) > article:nth-child(1) > header:nth-child(1) > h2:nth-child(1) > a:nth-child(1)"));
            }
        }

        public IWebElement MyArticle
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector("div.col-sm-6:nth-child(4) > article:nth-child(1) > header:nth-child(1) > h2:nth-child(1) > a:nth-child(1)"));
            }
        }

        public IWebElement EditButton
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector("a.btn:nth-child(1)"));
            }
        }
        public IWebElement DeleteButton
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector("a.btn:nth-child(2)"));
            }
        }
        public IWebElement BackButton
        {
            get
            {
                return this.Driver.FindElement(By.CssSelector("a.btn:nth-child(3)"));
            }
        }

        public IWebElement ErrorMessagesTitle
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"post-49\"]/div/p")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"post-49\"]/div/p"));
            }
        }

        public IWebElement ErrorMessagesTitleLength
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"post-49\"]/div/p")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"post-49\"]/div/p"));
            }
        }

        public IWebElement ErrorMessagesContent
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"post-49\"]/div/p")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"post-49\"]/div/p"));
            }
        }

        //public IWebElement ErrorMessagesArticleAlreadyExists
        //{
        //    get
        //    {
        //        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"post-49\"]/div/p")));
        //        return this.Driver.FindElement(By.XPath("//*[@id=\"post-49\"]/div/p"));
        //    }
        //}



    }
}