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
    public class _T_WPS:Hooks
    {
        [Test]
        public void DeleteWPS()
        {
            wpsPageObjects wps = Dash.openWPS();
            System.Threading.Thread.Sleep(1000);

            wps.DeleteWPS(testValues._g_WPS);
            System.Threading.Thread.Sleep(1000);

        }

        [Test]
        public void EditWPS()
        {
            wpsPageObjects wps = Dash.openWPS();

            wps.EditWPS(testValues._g_WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }

        [Test]
        public void NewWPS()
        {
            wpsPageObjects wps = Dash.openWPS();

            wps.NewWPS(testValues._g_WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }
    }
}
