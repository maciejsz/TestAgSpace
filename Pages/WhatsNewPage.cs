using System.Collections.Generic;
using BoDi;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestAgSpace.Pages
{
    public class WhatsNewPage
    {
        [FindsBy(How = How.Name, Using = "_sf_search[]")]
        public IWebElement EnterKeywordInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "wrapper")]
        public IWebElement GridContent { get; set; }

        [FindsBy(How = How.LinkText, Using = "Terms and Conditions")]
        public IWebElement TermsAndConditionsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]")]
        public IWebElement FullGrid { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='africa']")]
        public IWebElement AfricaCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='contour']")]
        public IWebElement ContourCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='global']")]
        public IWebElement GlobalCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='uk']")]
        public IWebElement UKCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='contour_product']")]
        public IWebElement ContourProductCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='general']")]
        public IWebElement GeneralCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='grid_product']")]
        public IWebElement GRIDCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='blog']")]
        public IWebElement BlogCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='case-study']")]
        public IWebElement CaseStudyCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='pr']")]
        public IWebElement PRCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='release_note']")]
        public IWebElement ReleaseNoteCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='uncategorised']")]
        public IWebElement UncategorisedCheckbox { get; set; }

        [FindsBy(How = How.ClassName, Using = "sf_date_field")]
        public IWebElement DateInput { get; set; }

        private IWebDriver driver;
        
        public WhatsNewPage(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            PageFactory.InitElements(driver, this);
        }
    }
}
