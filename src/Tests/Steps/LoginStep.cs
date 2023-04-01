using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Pages;

[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace Tests.Steps
{
    public class LoginStep
    {
        private LoginPage LoginPage { get; }
        private Homepage Homepage { get; }

        private readonly IWebDriver _driver;
        public LoginStep(IWebDriver driver) 
        {
            _driver = driver;
            LoginPage = new LoginPage(_driver);
            Homepage = new Homepage(_driver);
        }
    }
}
