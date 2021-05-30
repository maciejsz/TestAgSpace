using System.Collections.Generic;
using BoDi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestAgSpace.Pages
{
    public class ContactPage
    {
        [FindsBy(How = How.ClassName, Using = "contact-el")]
        public IWebElement ContactDetails { get; set; }

        [FindsBy(How = How.ClassName, Using = "location-text-block")]
        public IWebElement OxfordOffice { get; set; }

        private IWebDriver driver;

        public ContactPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            PageFactory.InitElements(driver, this);
        }
    }
}
