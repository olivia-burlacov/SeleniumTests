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
    public class LoginTest : Selenium1.Hooks
    {
        /*const string userEmail = "automation.pp@amdaris.com";
        const string userPassword = "10704-observe-MODERN-products-STRAIGHT-69112";
        private Actions action;*/

        [Test]
        public void SuccessfulLogin()
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

            HomePage homePage = new HomePage(GetDriver(), GetWaiter());
            homePage.AssertLoggedIn();

        }

        
    }

}