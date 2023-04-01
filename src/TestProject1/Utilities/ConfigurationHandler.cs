using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Utilities.Extension;
using TestProject1.Utilities.RunSettingsUtilities;

namespace TestProject1.Utilities
{
    public class ConfigurationHandler
    {
        public static readonly RunSettingsReader RunSettingsReader = new RunSettingsReader();
        public static string GetURL() => RunSettingsReader.ReadHierarchyRunSettings("Url");
        public static bool GetUseRemoteWebDriver() => RunSettingsReader.ReadHierarchyRunSettings("UseRemoteWebDriver").AsBoolean();
        public static string GetRemoteWebDriverURL() => RunSettingsReader.ReadHierarchyRunSettings("RemoteWebDriverURL");
        public static string GetBrowserVersion() => RunSettingsReader.ReadHierarchyRunSettings("BrowserVersion");
        public static string GetRemoteWebDriverResolution() => RunSettingsReader.ReadHierarchyRunSettings("RemoteWebDriverResolution");
        public static string GetTestDataPath() => RunSettingsReader.ReadHierarchyRunSettings("TestDataPath");
        public static string GetEnvironment() => RunSettingsReader.ReadHierarchyRunSettings("Environment");
        public static int GetWaitForElementsTimeout() => RunSettingsReader.ReadHierarchyRunSettings("WaitForElementsTimeout").AsInt();
        public static int GetWaitForPageTimeout() => RunSettingsReader.ReadHierarchyRunSettings("WaitForPageTimeout").AsInt();
    }
}
