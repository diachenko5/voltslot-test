using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Pages;
using TestFramework.TestBase;

namespace Tests.Steps
{
    [Binding]
    public class DepositPayop
    {
        private PayopPage PayopPage { get; }


        private readonly IWebDriver _driver;
        public DepositPayop(IWebDriver driver)
        {
            _driver = driver;
            PayopPage = new PayopPage(_driver);

        }

        [When(@"Try to make a deposit")]
        public void WhenTryToMakeADeposit()
        {

            PayopPage.FullNameField.SendKeys("test test");
            Thread.Sleep(6000);
            PayopPage.ConfirmButton.Click();

        }

    }
}
