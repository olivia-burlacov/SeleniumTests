using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium1.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium1.PageObjectModel
{
    class EditOpportunityPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public EditOpportunityPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement opportunityName => _driver.FindElement(By.Id("name"));
        private By opportunityStage => By.XPath("//mat-select[@formcontrolname='pipelineStageId']");
        private By stageItem => By.XPath("//div/mat-option/span[contains(text(),'Needs Analysis')]");
        private By opportunityPipeline => By.XPath("//mat-select[@formcontrolname='pipelineId']");
        private By pipelineItem => By.XPath("//div/mat-option[@tabindex='0'][3]");
        private By projectDropdown => By.XPath("//mat-select[@aria-label='Project']");
        private IWebElement projectItem => _driver.FindElement(By.XPath("//div[@class='scrollable-content']/*[2]"));
        private By clientDropdown => By.XPath("//mat-select[@aria-label='Client']");
        private By clientItem => By.XPath("//div[@class='scrollable-content']/*[3]");
        private By ownerDropdown => By.XPath("//mat-select[@aria-label='Opportunity Owner']");
        private By likelyhoodDropdown => By.XPath("//mat-select[@aria-label='Likelihood']");
        private By bestLikelyhood => By.XPath("//mat-option/span[contains(text(), 'Best Case')]");
        private By estimatedClosingDate => By.XPath("//mat-datepicker-toggle/button[@type='button']");
        private By skillsDropdown => By.XPath("//mat-chip-list[@aria-label='Skills selection']");
        private By skillsItem => By.XPath("//div[@role = 'listbox']/mat-option[2]");
        private By saveOpportunity => By.XPath("//button[@type = 'submit']");

        public static string editedTitle;

        public EditOpportunityPage EditOpportunityName(string name)
        {
            opportunityName.Clear();
            opportunityName.WaitAndType(name, _wait);
            editedTitle = name;
            return this;
        }

        public EditOpportunityPage ClickPipelineDropdown()
        {
            opportunityPipeline.WaitAndClick(_wait);
            return this;
        }

        public EditOpportunityPage SelectPipelineItem()
        {
            pipelineItem.WaitAndClick(_wait);
            return this;
        }

        //Client methods

        public EditOpportunityPage ClickClientDropdown()
        {
            clientDropdown.WaitAndClick(_wait);
            return this;
        }
        public EditOpportunityPage SelectClient()
        {
            Thread.Sleep(1000);
            clientItem.WaitAndClick(_wait);
            return this;
        }

        //Likelyhood methods
        public EditOpportunityPage ClickLikelyhoodDropdown()
        {
            likelyhoodDropdown.WaitAndClick(_wait);
            return this;
        }
        public EditOpportunityPage SelectLikelyhood()
        {
            bestLikelyhood.WaitAndClick(_wait);
            return this;
        }

        //Skills methods
        public EditOpportunityPage ClickSkillsDropdown()
        {
            skillsDropdown.WaitAndClick(_wait);
            return this;
        }
        public EditOpportunityPage SelectSkill()
        {
            skillsItem.WaitAndClick(_wait);
            return this;
        }

        //Stage methods
        public EditOpportunityPage ClickStageDropdown()
        {
            opportunityStage.WaitAndClick(_wait);
            return this;
        }
        public EditOpportunityPage SelectStage()
        {
            Thread.Sleep(1000);
            stageItem.WaitAndClick(_wait);
            return this;
        }

        //Project methods
        public EditOpportunityPage ClickProjectDropdown()
        {
            projectDropdown.WaitAndClick(_wait);
            return this;
        }
        public EditOpportunityPage SelectProject()
        {
            projectItem.WaitAndClick(_wait);
            return this;
        }

        //Save methods
        public EditOpportunityPage ClickSaveButton()
        {
            saveOpportunity.WaitAndClick(_wait);
            return this;
        }
    }
}
