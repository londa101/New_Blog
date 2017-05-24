using OpenQA.Selenium;

namespace Blog.Pages.Article
{
    public partial class ArticlePage : BasePage
    {
        public ArticlePage(IWebDriver driver) : base(driver)
        {
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Article/List");
        }

        public void FillArticle()
        {

        }
    }
}