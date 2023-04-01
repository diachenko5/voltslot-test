using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestFramework.Pages;
using TestFramework.TestBase;

[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace Tests.Steps
{
    [Binding]
    public class LoginStep
    {
        private LoginPage LoginPage { get; }
        private HomePage HomePage { get; }
        private TestBase TestBase { get; }

        private readonly IWebDriver _driver;
        public LoginStep(IWebDriver driver) 
        {
            _driver = driver;
            LoginPage = new LoginPage(_driver);
            HomePage = new HomePage(_driver);
            TestBase = new TestBase(_driver);
        }

        [Given(@"Authorize with client ""([^""]*)"" ""([^""]*)""")]
        public void GivenAuthorizeWithClient(string login, string password)
        {
            TestBase.GoToSite();
            LoginPage.LoginButton.Click();
            Thread.Sleep(2000);
            LoginPage.LoginField.SendKeys(login);
            LoginPage.PasswordField.SendKeys(password);
            LoginPage.SubmitButton.Click();
        }


        [When(@"Navigate to Deposit")]
        public void WhenNavigateToDeposit()
        {
            Thread.Sleep(4000);
            HomePage.DepositButton.Click();
            Thread.Sleep(4000);
        }

        [When(@"Navigate to Payop")]
        public void WhenNavigateToPayop()
        {
            Thread.Sleep(4000);
            HomePage.PayopButton.Click();
            Thread.Sleep(2000);
            HomePage.DropDownMethodButton.Click();
            HomePage.VisaCardButton.Click();
            Thread.Sleep(1000);
            HomePage.AmountField.Clear();
            HomePage.AmountField.SendKeys("200");
            HomePage.DepositSubmit.Click();
            Thread.Sleep(3000);
        }



    }
}
