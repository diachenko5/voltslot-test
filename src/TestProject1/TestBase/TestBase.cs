using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Utilities;

namespace TestFramework.TestBase
{
    public class TestBase
    {
        public IWebDriver _driver;
        public TestBase(IWebDriver driver)
        {
            _driver = driver;
        }

        [Obsolete]
        public void GoToSite()
        {
            _driver.Navigate().GoToUrl(ConfigurationHandler.GetURL());
            _driver.Manage().Window.Maximize();
        }
    }
}
