using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Selenium1.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Selenium1
{
    class OpportunitiesTest : Hooks
    {
        [Test]
        public void SuccessfulOpportunityCreation()
        {

            LoginProjectPlan();

            HomePage homePage = new HomePage(GetDriver(), GetWaiter());
            homePage.ClickOpportunities();

            OpportunitiesPage opportunitiesPage = new OpportunitiesPage(GetDriver(), GetWaiter());
            opportunitiesPage.ClickAddOpportunity();

            AddOpportunityPage addOpportunityPage = new AddOpportunityPage(GetDriver(), GetWaiter());
            addOpportunityPage.SelectRandomColor()
                              .InsertOpportunityName("AutomatedTest")
                              .ClickPipelineDropdown()
                              .SelectPipelineItem()
                              .ClickClientDropdown()
                              .SelectClient()
                              .RemoveOwner()
                              .ClickOwnerDropdown()
                              .InsertOwner()
                              .SelectOwner()
                              .ClickProjectDropdown()
                              .SelectProject()
                              .ClickDateDropdown()
                              .SelectNextMonth()
                              .SelectDate()
                              .ClickLikelyhoodDropdown()
                              .SelectLikelyhood()
                              .ClickSkillsDropdown()
                              .SelectSkill()
                              .ClickSaveButton();

            ViewOpportunityPage viewOpportunityPage = new ViewOpportunityPage(GetDriver(), GetWaiter());
            viewOpportunityPage.AssertOpportunityColor();
            viewOpportunityPage.AssertOpportunityTitle();
            viewOpportunityPage.DeleteOpportunity();
        }

        [Test]
        public void SuccessfulOpportunityEdit()
        {

            LoginProjectPlan();

            HomePage homePage = new HomePage(GetDriver(), GetWaiter());
            homePage.ClickOpportunities();

            OpportunitiesPage opportunitiesPage = new OpportunitiesPage(GetDriver(), GetWaiter());
            opportunitiesPage.ClickAddOpportunity();

            AddOpportunityPage addOpportunityPage = new AddOpportunityPage(GetDriver(), GetWaiter());
            addOpportunityPage.SelectRandomColor()
                              .InsertOpportunityName("AutomationTest")
                              .ClickPipelineDropdown()
                              .SelectPipelineItem()
                              .ClickClientDropdown()
                              .SelectClient()
                              .RemoveOwner()
                              .ClickOwnerDropdown()
                              .InsertOwner()
                              .SelectOwner()
                              .ClickProjectDropdown()
                              .SelectProject()
                              .ClickDateDropdown()
                              .SelectNextMonth()
                              .SelectDate()
                              .ClickLikelyhoodDropdown()
                              .SelectLikelyhood()
                              .ClickSkillsDropdown()
                              .SelectSkill()
                              .ClickSaveButton();

            ViewOpportunityPage viewOpportunityPage = new ViewOpportunityPage(GetDriver(), GetWaiter());
            viewOpportunityPage.EditOpportunity();

            EditOpportunityPage editOpportunityPage = new EditOpportunityPage(GetDriver(), GetWaiter());
            editOpportunityPage.EditOpportunityName("AutomatedTest 121")
                               .ClickPipelineDropdown()
                               .SelectPipelineItem()
                               .ClickClientDropdown()
                               .SelectClient()
                               .ClickLikelyhoodDropdown()
                               .SelectLikelyhood()
                               .ClickSkillsDropdown()
                               .SelectSkill()
                               .ClickStageDropdown()
                               .SelectStage()
                               .ClickProjectDropdown()
                               .SelectProject()
                               .ClickSaveButton();

            viewOpportunityPage.AssertEditedOpportunityTitle();
            viewOpportunityPage.DeleteOpportunity();


        }

        [Test]
        public void SuccessfulOpportunitySearchSelect()
        {

            LoginProjectPlan();

            HomePage homePage = new HomePage(GetDriver(), GetWaiter());
            homePage.ClickOpportunities();

            OpportunitiesPage opportunitiesPage = new OpportunitiesPage(GetDriver(), GetWaiter());
            opportunitiesPage.ClickOpportunityDropdown();
            opportunitiesPage.SelectOpportunity();

            ViewOpportunityPage viewOpportunityPage = new ViewOpportunityPage(GetDriver(), GetWaiter());
            viewOpportunityPage.AssertOpportunityRedirection();
        }

        [Test]
        public void SuccessfulOpportunitySearchInput()
        {

            LoginProjectPlan();

            HomePage homePage = new HomePage(GetDriver(), GetWaiter());
            homePage.ClickOpportunities();

            OpportunitiesPage opportunitiesPage = new OpportunitiesPage(GetDriver(), GetWaiter());
            opportunitiesPage.ClickAddOpportunity();

            AddOpportunityPage addOpportunityPage = new AddOpportunityPage(GetDriver(), GetWaiter());
            addOpportunityPage.SelectRandomColor()
                              .InsertOpportunityName("AutomationTest")
                              .ClickPipelineDropdown()
                              .SelectPipelineItem()
                              .ClickClientDropdown()
                              .SelectClient()
                              .RemoveOwner()
                              .ClickOwnerDropdown()
                              .InsertOwner()
                              .SelectOwner()
                              .ClickProjectDropdown()
                              .SelectProject()
                              .ClickDateDropdown()
                              .SelectNextMonth()
                              .SelectDate()
                              .ClickLikelyhoodDropdown()
                              .SelectLikelyhood()
                              .ClickSkillsDropdown()
                              .SelectSkill()
                              .ClickSaveButton();

            homePage.ClickOpportunities();

            opportunitiesPage.ClickOpportunityDropdown();
            opportunitiesPage.InsertOpportunity("AutomationTest");
            opportunitiesPage.AssertOpportunitySearchCount();

        }
    }
}
