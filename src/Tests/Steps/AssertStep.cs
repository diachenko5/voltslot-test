using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Assertion;
using TestFramework.Pages;

namespace Tests.Steps
{
    [Binding]
    public class AssertStep
    {
        private CheckoutPayopPage CheckoutPayopPage { get; }
        private Assertion Assertion { get; }


        private readonly IWebDriver _driver;
        public AssertStep(IWebDriver driver)
        {
            _driver = driver;
            CheckoutPayopPage = new CheckoutPayopPage(_driver);
            Assertion = new Assertion(_driver);

        }

        [Then(@"Checkout page loaded")]
        public void ThenCheckoutPageLoaded()
        {
            CheckoutPayopPage.ElementPresnt();
        }

        [Then(@"Payop payment absent for the user")]
        public void ThenPayopPaymentAbsentForTheUser()
        {
            Assertion.PayopAbsent();
        }

    }
}
