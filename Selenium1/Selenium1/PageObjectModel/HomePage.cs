using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium1.Extensions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1.PageObjectModel
{
    class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private By logoutButton => By.XPath("//div[@class='log-out']");
        private By opportunitiesTab => By.Id("opportunities-tab");

        public void AssertLoggedIn()
        {
            bool actualResult = logoutButton.WaitTillDisplayed(_wait);
            Assert.IsTrue(actualResult);
        }

        public void ClickOpportunities()
        {
            opportunitiesTab.WaitAndClick(_wait);
        }
    }
}
