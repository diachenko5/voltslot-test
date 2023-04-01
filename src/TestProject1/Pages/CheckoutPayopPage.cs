using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Pages
{
    public class CheckoutPayopPage
    {
        private IWebDriver driver;

        public CheckoutPayopPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Elements

        public IWebElement PayDoImg => driver.FindElement(By.XPath("//img[@alt='PayDo.com']"));

        #endregion

        public void ElementPresnt()
        {
            Thread.Sleep(7000);
            Assert.True(PayDoImg.Displayed, "Checkout page didn't load");
        }
    }
}
