using BoDi;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProject1.Utilities;

namespace Tests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private static IWebDriver driver;

        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        [Obsolete]
        public void BeforeScenario()
        {
            if (ConfigurationHandler.GetUseRemoteWebDriver())
            {
                ChromeOptions driverOptions = new ChromeOptions();

                driverOptions.BrowserVersion = ConfigurationHandler.GetBrowserVersion();
                var cloudOptions = new Dictionary<string, object>();
                cloudOptions.Add("enableVNC", true);
                cloudOptions.Add("screenResolution", ConfigurationHandler.GetRemoteWebDriverResolution() + "x24");
                driverOptions.AddAdditionalOption("selenoid:options", cloudOptions);

                driver = new RemoteWebDriver(new Uri(ConfigurationHandler.GetRemoteWebDriverURL()), driverOptions);
                _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            }
            else
            {
                driver = new ChromeDriver();
                _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            }

            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IWebDriver driver = _objectContainer.Resolve<IWebDriver>();
            driver.Quit();
        }
    }
}