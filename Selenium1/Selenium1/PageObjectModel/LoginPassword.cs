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
    class LoginPassword
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        const string userPassword = "10704-observe-MODERN-products-STRAIGHT-69112";

        public LoginPassword(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private By passwordField => By.XPath("//input[@type='password']");
        private IWebElement submitButton => _driver.FindElement(By.XPath("//input[@type='submit']"));

        public void InsertPassword()
        {
            passwordField.WaitAndType(userPassword, _wait);
        }

        public void SubmitPassword()
        {
           submitButton.WaitAndClick(_wait);
        }
    }
}
