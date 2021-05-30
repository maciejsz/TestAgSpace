using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestAgSpace.Helpers
{
    public class WaitHelper
    {
        private IWebDriver driver;
        public WaitHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public WebDriverWait Wait() => new WebDriverWait(driver, TestSettings.TimeSpan);

        public void WaitForClickable(IWebElement element)
        {
            Wait().Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
