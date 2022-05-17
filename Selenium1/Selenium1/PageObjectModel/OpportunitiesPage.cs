using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium1.Extensions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium1.PageObjectModel
{
    class OpportunitiesPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public OpportunitiesPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private By addOpportunityButton => By.Id("addOpportunityButton");
        private By opportunityDropdown => By.XPath("//mat-select[@aria-label='Select Opportunity']");
        private By opportunityItem => By.XPath("//virtual-scroller/div/mat-option[1]");
        private IWebElement opportunitySearchField => _driver.FindElement(By.XPath("//input[@aria-label='dropdown search']"));
        private By searchOpportunityItems => By.XPath("//div[@class='scrollable-content']/mat-option");

        public void ClickAddOpportunity()
        {
            addOpportunityButton.WaitAndClick(_wait);
        }

        public void ClickOpportunityDropdown()
        {
            opportunityDropdown.WaitAndClick(_wait);
        }

        public void SelectOpportunity()
        {
            opportunityItem.WaitAndClick(_wait);
        }

        public void InsertOpportunity(string title)
        {
            opportunitySearchField.WaitAndType(title, _wait);
        }

        public void AssertOpportunitySearchCount()
        {
            ReadOnlyCollection<IWebElement> list = _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(_driver.FindElements(searchOpportunityItems)));
            Assert.LessOrEqual(list.Count, 1);
        }
    }
}
