using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Pages;

namespace TestFramework.Assertion
{
    public class Assertion
    {
        private HomePage HomePage { get; }

        private IWebDriver driver;

        public Assertion(IWebDriver driver)
        {
            this.driver = driver;
            HomePage = new HomePage(driver);

        }
        public void PayopAbsent()
        {

            Assert.True(!IsPresent(), "Payop should be absent");
        }

        public bool IsPresent()
        {
            try
            {
                var isPresent = HomePage.PayopButton.Displayed;
                return isPresent;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
