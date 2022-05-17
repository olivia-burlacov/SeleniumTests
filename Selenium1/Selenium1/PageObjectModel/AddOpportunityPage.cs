using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    class AddOpportunityPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public AddOpportunityPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private By pickColorButton => By.ClassName("picker-button");
        ReadOnlyCollection<IWebElement> swatchList => _driver.FindElements(By.ClassName("swatch"));
        private By opportunityName => By.Id("name");
        private By pipelineDropdown => By.XPath("//mat-select[@aria-label='Pipeline']");
        private By pipelineItem => By.XPath("//div/mat-option[@tabindex='0'][1]");
        private By clientDropdown => By.XPath("//mat-select[@aria-label='Client']");
        private By clientItem => By.XPath("//div[@class='scrollable-content']/*[1]");
        private By ownerDropdown => By.XPath("//mat-select[@aria-label='Owner']");
        private By ownerRemove => By.XPath("//app-employee-select/button[@type='button']");
        private By ownerSearch => By.XPath("//input[@aria-label='dropdown search']");
        private By ownerItem => By.XPath("//span[@class='name']");
        private By projectDropdown => By.XPath("//mat-select[@aria-label='Project']");
        private IWebElement projectItem => _driver.FindElement(By.XPath("//div[@class='scrollable-content']/*[1]"));
        private By estimatedClosingDate => By.XPath("//mat-datepicker-toggle/button[@type='button']");
        private By nextMonthButton => By.XPath("//button[@aria-label='Next month']");
        private By dateSelect => By.XPath("//tbody/tr[@role='row'][1]/td[@role='button'][last()]");
        private By likelyhoodDropdown => By.XPath("//mat-select[@aria-label='Likelihood']");
        private By mediumLikelyhood => By.XPath("//mat-option/span[contains(text(), 'Medium')]");
        private By skillsDropdown => By.XPath("//mat-chip-list[@aria-label='Skills selection']");
        private By skillsItem => By.XPath("//div[@role = 'listbox']/mat-option[1]");
        private By saveOpportunity => By.XPath("//button[@type = 'submit']");
        public static string selectedColor;
        public static string title;

        public AddOpportunityPage SelectRandomColor()
        {
            pickColorButton.WaitAndClick(_wait);
            swatchList.WaitTillElementsVisible(_wait);

            var random = new Random();
            int index = random.Next(swatchList.Count);
            IWebElement webElement = swatchList.ElementAt(index);
            selectedColor = webElement.GetCssValue("background-color");
            webElement.Click();
            return this;
        }

        public AddOpportunityPage InsertOpportunityName(string name)
        {
            opportunityName.WaitAndType(name, _wait);
            title = name;
            return this;
        }

        public AddOpportunityPage ClickPipelineDropdown()
        {
            pipelineDropdown.WaitAndClick(_wait);
            return this;
        }

        public AddOpportunityPage SelectPipelineItem()
        {
            pipelineItem.WaitAndClick(_wait);
            return this;
        }

        //Client methods

        public AddOpportunityPage ClickClientDropdown()
        {
            clientDropdown.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage SelectClient()
        {
            Thread.Sleep(1000);
            clientItem.WaitAndClick(_wait);
            return this;
        }

        //Owner methods
        public AddOpportunityPage RemoveOwner()
        {
            ownerRemove.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage ClickOwnerDropdown()
        {
            ownerDropdown.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage InsertOwner()
        {
            ownerSearch.WaitAndType("Automation tests V", _wait);
            return this;
        }
        public AddOpportunityPage SelectOwner()
        {
            ownerItem.WaitAndClick(_wait);
            return this;
        }

        //Project methods
        public AddOpportunityPage ClickProjectDropdown()
        {
            projectDropdown.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage SelectProject()
        {
            projectItem.WaitAndClick(_wait);
            return this;
        }

        //Closing Date methods
        public AddOpportunityPage ClickDateDropdown()
        {
            estimatedClosingDate.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage SelectNextMonth()
        {
            nextMonthButton.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage SelectDate()
        {
            dateSelect.WaitAndClick(_wait);
            return this;
        }

        //Likelyhood methods
        public AddOpportunityPage ClickLikelyhoodDropdown()
        {
            likelyhoodDropdown.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage SelectLikelyhood()
        {
            mediumLikelyhood.WaitAndClick(_wait);
            return this;
        }

        //Skills methods
        public AddOpportunityPage ClickSkillsDropdown()
        {
            skillsDropdown.WaitAndClick(_wait);
            return this;
        }
        public AddOpportunityPage SelectSkill()
        {
            skillsItem.WaitAndClick(_wait);
            return this;
        }

        //Save methods
        public AddOpportunityPage ClickSaveButton()
        {
            saveOpportunity.WaitAndClick(_wait);
            Thread.Sleep(1000);
            return this;
        }
        


    }
}
