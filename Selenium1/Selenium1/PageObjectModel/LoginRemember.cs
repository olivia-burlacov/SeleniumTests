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
    class LoginRemember
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public LoginRemember(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement dontShowAgainCheckbox => _driver.FindElement(By.XPath("//input[@name='DontShowAgain']"));
        private IWebElement submitButton => _driver.FindElement(By.XPath("//input[@type='submit']"));

        public void CheckDontShowAgain()
        {
            dontShowAgainCheckbox.WaitAndClick(_wait);

        }

        public void SubmitAll()
        {
            submitButton.WaitAndClick(_wait);

        }
    }
}
