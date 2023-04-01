using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Pages
{
    public class Homepage
    {
        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Elements

        public IWebElement TopSearch => driver.FindElement(By.Id("header-search-structure"));
        public IWebElement TopSearchButton => driver.FindElement(By.XPath("//button[@class='search-submit']"));

        #endregion
    }
}
