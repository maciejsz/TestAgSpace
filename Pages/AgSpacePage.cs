using BoDi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestAgSpace.Pages
{
    public class AgSpacePage
    {
        [FindsBy(How = How.Id, Using = "menu-item-28")]
        public IWebElement InnovationButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-31")]
        public IWebElement BigDataButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-34")]
        public IWebElement EarthObservationButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-37")]
        public IWebElement ContourButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-40")]
        public IWebElement GridButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-43")]
        public IWebElement ContactButton { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-120")]
        public IWebElement WhatsNewButton { get; set; }

        private IWebDriver driver;

        public AgSpacePage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            PageFactory.InitElements(driver, this);
        }
    }
}
