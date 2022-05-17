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
    public class WelcomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public WelcomePage (IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement loginButton => _driver.FindElement(By.CssSelector("div .button > span"));

        public void ClickLoginButton()
        {
            loginButton.WaitAndClick(_wait);
        }
    }
}
