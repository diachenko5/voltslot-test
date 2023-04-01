using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Pages
{
    public class PayopPage
    {
        private IWebDriver driver;

        public PayopPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Elements

        public IWebElement FullNameField => driver.FindElement(By.XPath("//input[@placeholder='Enter full name']"));
        public IWebElement ConfirmButton => driver.FindElement(By.XPath("//div[@class='checkout-confirm-payment-buttons__buttons']/button"));

        #endregion 
    }
}