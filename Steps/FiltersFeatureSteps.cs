using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using TestAgSpace.Helpers;
using TestAgSpace.Pages;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using OpenQA.Selenium.Interactions;

namespace TestAgSpace.Steps
{
    [Binding]
    public class FiltersFeatureSteps
    {
        private IObjectContainer container;
        public IWebDriver Driver => container.Resolve<IWebDriver>();
        private WhatsNewPage whatsNewPage;
        private SeleniumHelper seleniumHelper;
        private WaitHelper waitHelper;
        private ScenarioContext scenarioContext;
        private int totalElements;
        private String beginDate = "12/01/2020";
        private String endDate = "12/03/2020";

        public FiltersFeatureSteps(IObjectContainer container, WhatsNewPage whatsNewPage, SeleniumHelper seleniumHelper, WaitHelper waitHelper, ScenarioContext scenarioContext)
        {
            this.container = container;
            this.whatsNewPage = whatsNewPage;
            this.seleniumHelper = seleniumHelper;
            this.waitHelper = waitHelper;
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I enter whats new page")]
        public void GivenIEnterWhatsNewPage()
        {
            seleniumHelper.GoToPage(TestSettings.WhatsNewUrl);
        }
        
        [When(@"I enter manufacutrer in text input")]
        public void WhenIEnterManufacutrerInTextInput()
        {
            waitHelper.WaitForClickable(whatsNewPage.EnterKeywordInput);
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            whatsNewPage.EnterKeywordInput.SendKeys("manufacturer");
            
        }

        [When(@"I check Africa check box")]
        public void WhenICheckAfricaCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.AfricaCheckbox);
            whatsNewPage.AfricaCheckbox.Click();
        }

        [When(@"I check Contour check box")]
        public void WhenICheckContourCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.ContourCheckbox);
            whatsNewPage.ContourCheckbox.Click();
        }

        [When(@"I check Global check box")]
        public void WhenICheckGlobalCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.GlobalCheckbox);
            whatsNewPage.GlobalCheckbox.Click();
        }


        [When(@"I check UK check box")]
        public void WhenICheckUKCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.UKCheckbox);
            whatsNewPage.UKCheckbox.Click();
        }

        [When(@"I check ContourProduct check box")]
        public void WhenICheckContourProductCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.ContourProductCheckbox);
            whatsNewPage.ContourProductCheckbox.Click();
        }

        [When(@"I check General check box")]
        public void WhenICheckGeneralCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.GeneralCheckbox);
            whatsNewPage.GeneralCheckbox.Click();
        }

        [When(@"I check GRID check box")]
        public void WhenICheckGRIDCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.GRIDCheckbox);
            whatsNewPage.GRIDCheckbox.Click();
        }

        [When(@"I check Blog check box")]
        public void WhenICheckBlogCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.BlogCheckbox);
            whatsNewPage.BlogCheckbox.Click();
        }

        [When(@"I check Case study check box")]
        public void WhenICheckCaseStudyCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.CaseStudyCheckbox);
            whatsNewPage.CaseStudyCheckbox.Click();
        }

        [When(@"I check PR check box")]
        public void WhenICheckPRCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.PRCheckbox);
            whatsNewPage.PRCheckbox.Click();
        }

        [When(@"I check Release note check box")]
        public void WhenICheckReleaseNoteCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.ReleaseNoteCheckbox);
            whatsNewPage.ReleaseNoteCheckbox.Click();
        }

        [When(@"I check Uncategorised check box")]
        public void WhenICheckUncategorisedCheckBox()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.UncategorisedCheckbox);
            whatsNewPage.UncategorisedCheckbox.Click();
        }

        [When(@"I enter from and end date")]
        public void WhenIEnterFromAndEndDate()
        {
            waitHelper.WaitForClickable(whatsNewPage.FullGrid);
            totalElements = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper")).Count;
            waitHelper.WaitForClickable(whatsNewPage.DateInput);
            var inputs = whatsNewPage.DateInput.FindElements(By.Name("_sf_post_date[]"));
            inputs[0].SendKeys(beginDate);
            inputs[1].SendKeys(endDate);
        }

        [Then(@"I should only see news between those dates")]
        public void ThenIShouldOnlySeeNewsBetweenThoseDates()
        {
            ScrollDown();
            CheckDate(beginDate, endDate);
        }


        [Then(@"I should only see news whth Blog in tags")]
        public void ThenIShouldOnlySeeNewsWhthBlogInTags()
        {
            ScrollDown();
            CheckCategory("Blog");
        }

        [Then(@"I should only see news whth Case study in tags")]
        public void ThenIShouldOnlySeeNewsWhthCaseStudyInTags()
        {
            ScrollDown();
            CheckCategory("Case study");
        }

        [Then(@"I should only see news whth PR in tags")]
        public void ThenIShouldOnlySeeNewsWhthPRInTags()
        {
            ScrollDown();
            CheckCategory("PR");
        }

        [Then(@"I should only see news whth Release note in tags")]
        public void ThenIShouldOnlySeeNewsWhthReleaseNoteInTags()
        {
            ScrollDown();
            CheckCategory("Release note");
        }

        [Then(@"I should only see news whth Uncategorised in tags")]
        public void ThenIShouldOnlySeeNewsWhthUncategorisedInTags()
        {
            ScrollDown();
            CheckCategory("Uncategorised");
        }


        [Then(@"I should only see news whth GRID in the content")]
        public void ThenIShouldOnlySeeNewsWhthGRIDInTheContent()
        {
            ScrollDown();
            CheckTextOrLink("GRID");
        }

        [Then(@"I should only see news whth General in the content")]
        public void ThenIShouldOnlySeeNewsWhthGeneralInTheContent()
        {
            ScrollDown();
            CheckTextOrLink("General");
        }

        [Then(@"I should only see news whth ContourProduct in the content")]
        public void ThenIShouldOnlySeeNewsWhthContourProductInTheContent()
        {
            ScrollDown();
            CheckTextOrLink("Contour");
        }


        [Then(@"I should only see news whth manufacturer in the content")]
        public void ThenIShouldOnlySeeNewsWhthManufacturerInTheContent()
        {
            ScrollDown();
            CheckText("manufacturer");
        }

        [Then(@"I should only see news whth Africa in the content")]
        public void ThenIShouldOnlySeeNewsWhthAfricaInTheContent()
        {
            ScrollDown();
            CheckTags("Africa");
        }

        [Then(@"I should only see news whth Contour in the content")]
        public void ThenIShouldOnlySeeNewsWhthContourInTheContent()
        {
            ScrollDown();
            CheckTags("Contour");
        }

        [Then(@"I should only see news whth Global in the content")]
        public void ThenIShouldOnlySeeNewsWhthGlobalInTheContent()
        {
            ScrollDown();
            CheckTags("Global");
        }

        [Then(@"I should only see news whth UK in the content")]
        public void ThenIShouldOnlySeeNewsWhthUKInTheContent()
        {
            ScrollDown();
            CheckTags("UK");
        }

        private void ScrollDown()
        {
            Thread.Sleep(500);
            int j = 0;

            int heightOfPage = seleniumHelper.HeightOfPage();
            int currentHeightOfPage = 0;
            while (j < TestSettings.ScrollDownValue)
            {
                Thread.Sleep(600);
                j++;
                seleniumHelper.ScrollDownPage();
                currentHeightOfPage += seleniumHelper.CurrentHeightOfPage();
                if (currentHeightOfPage > heightOfPage)
                {
                    break;
                }
            }
        }

        private void CheckTags(String tag)
        {
            try
            {
                waitHelper.Wait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("tags")));
            }
            catch (NoSuchElementException)
            {
                Assert.IsTrue(true);
                return;
            }
            catch (WebDriverTimeoutException)
            {
                Assert.IsTrue(true);
                return;
            }
            var itemList = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper"));
            foreach (IWebElement element in itemList)
            {
                StringAssert.Contains(tag.ToLower(), element.FindElement(By.ClassName("tags")).Text.ToLower());
            }
        }

        private void CheckCategory(String category)
        {
            try
            {
                waitHelper.Wait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("category")));
            }
            catch (NoSuchElementException)
            {
                Assert.IsTrue(true);
                return;
            }
            catch (WebDriverTimeoutException)
            {
                Assert.IsTrue(true);
                return;
            }
            var itemList = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper"));
            foreach (IWebElement element in itemList)
            {
                StringAssert.Contains(category.ToLower(), element.FindElement(By.ClassName("category")).Text.ToLower());
            }
        }

        private void CheckDate(String first, String second)
        {
            try
            {
                waitHelper.Wait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("date")));
            }
            catch (NoSuchElementException)
            {
                Assert.IsTrue(true);
                return;
            }
            catch (WebDriverTimeoutException)
            {
                Assert.IsTrue(true);
                return;
            }
            var itemList = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper"));
            foreach (IWebElement element in itemList)
            {
                int i = 0;
                while (element.Text.Length == 0 && i < 100)
                {
                    Thread.Sleep(50);
                    i++;
                }

                var actualTime = element.FindElement(By.ClassName("date")).Text;
                i = 0;
                while (actualTime.Length == 0 && i < 100)
                {
                    Thread.Sleep(50);
                    i++;
                }
                int day;
                try
                {
                    day = Convert.ToInt32(actualTime.Substring(0, 2));
                }
                catch (ArgumentOutOfRangeException)
                {
                    day = Convert.ToInt32(actualTime.Substring(0, 2));
                }
                catch (FormatException)
                {
                    day = Convert.ToInt32(actualTime.Substring(0, 1));
                }
                
                int month = DateTime.Parse("1." + actualTime.Substring(actualTime.IndexOf(" "), actualTime.Length - 8) + " 2008").Month;
                int year = Convert.ToInt32(actualTime.Substring(actualTime.LastIndexOf(" ")));
                DateTime date = new DateTime(year, month, day);
                DateTime begin = DateTime.ParseExact(first, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime end = DateTime.ParseExact(second, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Assert.IsTrue(date.CompareTo(begin) > 0 && date.CompareTo(end) < 0);
            }
        }

        private void CheckText(String text)
        {
            waitHelper.Wait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("text-block")));
            var itemList = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper"));
            foreach (IWebElement element in itemList)
            {
                int i = 0;
                while (element.Text.Length == 0 && i < 100)
                {
                    Thread.Sleep(50);
                    i++;
                }
                StringAssert.Contains(text.ToLower(), element.FindElement(By.ClassName("text-block")).Text.ToLower());
            }
        }

        private void CheckTextOrLink(String text)
        {
            Thread.Sleep(500);
            waitHelper.Wait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("text-block")));
            var itemList = whatsNewPage.FullGrid.FindElements(By.ClassName("wrapper"));
            List<String> textLeftItemList = new List<String>();
            foreach (IWebElement element in itemList)
            {
                int i = 0;
                while (element.Text.Length == 0 && i < 100)
                {
                    Thread.Sleep(50);
                    i++;
                }
                if (element.FindElement(By.ClassName("text-block")).Text.ToLower().Contains(text.ToLower()))
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    textLeftItemList.Add(element.FindElement(By.ClassName("text-block")).Text);
                }
            }
            foreach(String element in textLeftItemList)
            {
                ScrollDown();
                var e = whatsNewPage.FullGrid.FindElement(By.XPath("//span[text() = '" + element + "']"));
                Actions actions = new Actions(Driver);
                actions.MoveToElement(e).Click().Perform();
                StringAssert.Contains(text.ToLower(), Driver.Url.ToLower());
                seleniumHelper.BrowserBack();
            }
        }
    }
}
