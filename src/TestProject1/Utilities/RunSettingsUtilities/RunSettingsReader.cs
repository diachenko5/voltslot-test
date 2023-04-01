using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Utilities.RunSettingsUtilities
{
    public class RunSettingsReader
    {
        public string ReadHierarchyRunSettings(string propertyname)
        {
            return TestContext.Parameters[propertyname];
        }
    }
}
