using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Elements

        public IWebElement DepositButton => driver.FindElement(By.XPath("//a[@title='Deposit']"));
        public IWebElement PayopButton => driver.FindElement(By.XPath("//div[@data-requisites='payop']"));
        public IWebElement DropDownMethodButton => driver.FindElement(By.XPath("//span[@title='Data for the deposit']"));
        public IWebElement VisaCardButton => driver.FindElement(By.XPath("//li[@class='select2-results__option select2-results__option--highlighted']"));
        public IWebElement AmountField => driver.FindElement(By.XPath("//input[@placeholder='Amount']"));
        public IWebElement DepositSubmit => driver.FindElement(By.XPath("//button[@class='btn-default']"));


        #endregion
    }
}
