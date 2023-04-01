using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Elements

        public IWebElement LoginButton => driver.FindElement(By.XPath("//a[@class=\"btn-default btn-gray header__btn_login\"]"));
        public IWebElement LoginField => driver.FindElement(By.XPath("//input[@name=\"email\"]"));
        public IWebElement PasswordField => driver.FindElement(By.XPath("//input[@name=\"password\"]"));
        public IWebElement SubmitButton => driver.FindElement(By.XPath("(//button[@type=\"submit\"])[2]"));


        #endregion
    }
}
