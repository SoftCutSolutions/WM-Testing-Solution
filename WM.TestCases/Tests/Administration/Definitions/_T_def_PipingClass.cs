using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class _T_def_PipingClass :Hooks
    {
        [Test]
        public void NewPipingClass()
        {
            definitionsPageObjects defs = Dash.openDefinitions();
            defs.NewPipingClass(testValues._g_PipingClass);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }

        [Test]
        public void DeletePipingClass()
        {
            definitionsPageObjects defs = Dash.openDefinitions();
            defs.DeletePipingClass(testValues._g_PipingClass);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(defs.alert.Text.ToLower().Contains("succesfully"));
        }
    }
}
