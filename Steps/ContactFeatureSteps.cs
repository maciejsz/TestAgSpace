using System.Linq;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using TestAgSpace.Helpers;
using TestAgSpace.Pages;
using TechTalk.SpecFlow;
using System;

namespace TestAgSpace.Steps
{
    [Binding]
    public class ContactFeatureSteps
    {
        private IObjectContainer container;
        public IWebDriver Driver => container.Resolve<IWebDriver>();
        private ContactPage contactPage;
        private SeleniumHelper seleniumHelper;
        private WaitHelper waitHelper;
        private ScenarioContext scenarioContext;

        public ContactFeatureSteps(IObjectContainer container, ContactPage contactPage, SeleniumHelper seleniumHelper, WaitHelper waitHelper, ScenarioContext scenarioContext)
        {
            this.container = container;
            this.contactPage = contactPage;
            this.seleniumHelper = seleniumHelper;
            this.waitHelper = waitHelper;
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I enter contact page")]
        public void GivenIEnterContactPage()
        {
            seleniumHelper.GoToPage(TestSettings.ContactUrl);
        }
        
        [When(@"I check contact details")]
        public void WhenICheckContactDetails()
        {
            
        }
        
        [Then(@"Contact details are up to date")]
        public void ThenContactDetailsAreUpToDate()
        {
            waitHelper.WaitForClickable(contactPage.ContactDetails);
            Assert.AreEqual("Call AgSpace:\r\n(+44) 01793 437999", contactPage.ContactDetails.Text);
            Assert.AreEqual("Oxford Office:\r\nHQ Building 329 F Wing\r\nThompson Avenue\r\nHarwell Campus\r\nDidcot\r\nOX11 0GD", contactPage.OxfordOffice.Text);
        }
    }
}
