using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProject1
{
    public class ProjectPlanTests
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("div .button > span")).Click();

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("automation.pp@amdaris.com");

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("10704-observe-MODERN-products-STRAIGHT-69112");

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

            Thread.Sleep(3000);
            string actualResult = driver.FindElement(By.Id("//div[@id='displayName']")).Text;
            Assert.AreEqual()
        }
    }
}