using System.Linq;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using TestAgSpace.Helpers;
using TestAgSpace.Pages;
using TechTalk.SpecFlow;

namespace TestAgSpace.Steps
{
    [Binding]
    public class MenuCheckSteps
    {
        private IObjectContainer container;
        public IWebDriver Driver => container.Resolve<IWebDriver>();
        private AgSpacePage agSpacePage;
        private SeleniumHelper seleniumHelper;
        private WaitHelper waitHelper;
        private ScenarioContext scenarioContext;

        public MenuCheckSteps(IObjectContainer container, AgSpacePage agSpacePage, SeleniumHelper seleniumHelper, WaitHelper waitHelper, ScenarioContext scenarioContext)
        {
            this.container = container;
            this.agSpacePage = agSpacePage;
            this.seleniumHelper = seleniumHelper;
            this.waitHelper = waitHelper;
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I enter ag-space main page")]
        public void GivenIEnterAg_SpaceMainPage()
        {
            seleniumHelper.GoToPage(TestSettings.AgSpaceUrl);
        }
        
        [When(@"I click on innovation in menu")]
        public void WhenIClickOnInnovationInMenu()
        {
            waitHelper.WaitForClickable(agSpacePage.InnovationButton);
            agSpacePage.InnovationButton.Click();
        }

        [When(@"I click on big data in menu")]
        public void WhenIClickOnBigDataInMenu()
        {
            waitHelper.WaitForClickable(agSpacePage.BigDataButton);
            agSpacePage.BigDataButton.Click();
        }

        [When(@"I click on earth observation in menu")]
        public void WhenIClickOnEarthObservationInMenu()
        {
            waitHelper.WaitForClickable(agSpacePage.EarthObservationButton);
            agSpacePage.EarthObservationButton.Click();
        }

        [When(@"I click on contour in menu")]
        public void WhenIClickOnContourInMenu()
        {
            waitHelper.WaitForClickable(agSpacePage.ContourButton);
            agSpacePage.ContourButton.Click();
        }

        [When(@"I click on grid in menu")]
        public void WhenIClickOnGridInMenu()
        {
            waitHelper.WaitForClickable(agSpacePage.GridButton);
            agSpacePage.GridButton.Click();
        }

        [When(@"I click on contact in menu")]
        public void WhenIClickOnContactInMenu()
        {
            waitHelper.WaitForClickable(agSpacePage.ContactButton);
            agSpacePage.ContactButton.Click();
        }

        [When(@"I click on what's new in menu")]
        public void WhenIClickOnWhatsNewInMenu()
        {
            waitHelper.WaitForClickable(agSpacePage.WhatsNewButton);
            agSpacePage.WhatsNewButton.Click();
        }


        [Then(@"I should be on innovation page")]
        public void ThenIShouldBeOnInnovationPage()
        {
            Assert.AreEqual(Driver.Url, "https://ag-space.com/innovation/");
        }

        [Then(@"I should be on big data page")]
        public void ThenIShouldBeOnBigDataPage()
        {
            Assert.AreEqual(Driver.Url, "https://ag-space.com/bigdata/");
        }

        [Then(@"I should be on earth observation page")]
        public void ThenIShouldBeOnEarthObservationPage()
        {
            Assert.AreEqual(Driver.Url, "https://ag-space.com/earth-observation/");
        }

        [Then(@"I should be on contour page")]
        public void ThenIShouldBeOnContourPage()
        {
            Assert.AreEqual(Driver.Url, "https://ag-space.com/contour/");
        }

        [Then(@"I should be on grid page")]
        public void ThenIShouldBeOnGridPage()
        {
            Assert.AreEqual(Driver.Url, "https://ag-space.com/grid/");
        }

        [Then(@"I should be on contact page")]
        public void ThenIShouldBeOnContactPage()
        {
            Assert.AreEqual(Driver.Url, "https://ag-space.com/contact/");
        }

        [Then(@"I should be on what's new page")]
        public void ThenIShouldBeOnWhatsNewPage()
        {
            Assert.AreEqual(Driver.Url, "https://ag-space.com/whats-new/");
        }
    }
}
