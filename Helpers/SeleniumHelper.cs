using BoDi;
using OpenQA.Selenium;

namespace TestAgSpace.Helpers
{
    public class SeleniumHelper
    {
        private IWebDriver driver => container.Resolve<IWebDriver>();
        private IObjectContainer container;

        public SeleniumHelper(IObjectContainer container)
        {
            this.container = container;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public void ScrollDownPage()
        {
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.PageDown);
        }

        public static void ScrollToEndOfPage(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        public void BrowserBack()
        {
            driver.Navigate().Back();
        }

        public int HeightOfPage()
        {
            return(int)(long) ((IJavaScriptExecutor)driver).ExecuteScript("return document.body.scrollHeight");
        }

        public int CurrentHeightOfPage()
        {
            return (int)(long)((IJavaScriptExecutor)driver).ExecuteScript("return window.innerHeight");
        }
    }
}
