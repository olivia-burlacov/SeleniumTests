using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium1.PageObjectModel;
using System;

namespace Selenium1
{
    public class Hooks
    {
        private IWebDriver _driver;
        public  WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments(new string[3]{ "--start-maximized", "--incognito", "--also-emit-success-logs" });
            _driver = new ChromeDriver(options);
            _driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(100));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }

        public IWebDriver GetDriver()
        {
            return _driver;
        }

        public WebDriverWait GetWaiter()
        {
            return wait;
        }

        public void LoginProjectPlan()
        {
            WelcomePage welcomePage = new WelcomePage(GetDriver(), GetWaiter());
            welcomePage.ClickLoginButton();

            LoginEmail loginEmail = new LoginEmail(GetDriver(), GetWaiter());
            loginEmail.InsertEmail();
            loginEmail.SubmitEmail();

            LoginPassword loginPassword = new LoginPassword(GetDriver(), GetWaiter());
            loginPassword.InsertPassword();
            loginPassword.SubmitPassword();

            LoginRemember loginRemember = new LoginRemember(GetDriver(), GetWaiter());
            loginRemember.CheckDontShowAgain();
            loginRemember.SubmitAll();

        }
    }
}
