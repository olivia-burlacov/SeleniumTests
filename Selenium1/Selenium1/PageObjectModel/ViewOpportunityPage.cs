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
    class ViewOpportunityPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public ViewOpportunityPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement projectIcon => _driver.FindElement(By.ClassName("ava"));
        private IWebElement opportunityDeleteButton => _driver.FindElement(By.XPath("//mat-icon[.='delete']"));
        private IWebElement confirmationDeleteButton => _driver.FindElement(By.XPath("//button[@attr.ui-automation-id='confirmationPopUpYesButton']"));
        private By opportunityEditButton => By.XPath("//span[.='Edit']");
        private IWebElement opportunityTitle => _driver.FindElement(By.XPath("//ul[@class='breadcrumbs']/*[2]/*[1]"));
        private IWebElement likelyhoodDropdown => _driver.FindElement(By.XPath("//div/span/span[contains(text(), 'Best Case')]"));
        private IWebElement opportunityDetails => _driver.FindElement(By.XPath("//div/a[contains(text(), 'Opportunity Details')]"));

        public void AssertOpportunityColor()
        {
            String actual = projectIcon.GetCssValue("background-color");
            Assert.AreEqual(AddOpportunityPage.selectedColor, actual);
        }

        public void AssertOpportunityTitle()
        {
            Thread.Sleep(1000);
            String actual = opportunityTitle.Text;
            Assert.AreEqual(AddOpportunityPage.title, actual);
        }

        public void DeleteOpportunity()
        {
            opportunityDeleteButton.WaitAndClick(_wait);
            confirmationDeleteButton.WaitAndClick(_wait);

        }

        public void EditOpportunity()
        {
            opportunityEditButton.WaitAndClick(_wait);
        }

        public void AssertEditedOpportunityTitle()
        {
            Thread.Sleep(1000);
            String actual = opportunityTitle.Text;
            Assert.That(actual, Is.EqualTo("AutomatedTest 121"));
        }

        public void AssertOpportunityRedirection()
        {
            Thread.Sleep(1000);
            bool actual = opportunityDetails.Displayed;
            Assert.IsTrue(actual);
        }
             
    }
}
