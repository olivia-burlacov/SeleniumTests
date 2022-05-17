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
    class LoginEmail
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        const string userEmail = "automation.pp@amdaris.com";

        public LoginEmail(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private By emailField => By.XPath("//input[@type='email']");
        private IWebElement submitButton => _driver.FindElement(By.XPath("//input[@type='submit']"));

        public void InsertEmail()
        {
          emailField.WaitAndType(userEmail, _wait);
        }

        public void SubmitEmail()
        {
            submitButton.WaitAndClick(_wait);
        }
    }
}
