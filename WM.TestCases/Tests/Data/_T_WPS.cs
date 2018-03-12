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
    public class _T_WPS : Hooks
    {
        [Test, TestCaseSource(typeof(MyFactoryClass), "WPSs")]
        public void DeleteWPS(WPSObj WPS)
        {
            wpsPageObjects wps = Dash.openWPS();
            System.Threading.Thread.Sleep(1000);

            wps.DeleteWPS(WPS);
            System.Threading.Thread.Sleep(1000);

        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WPSs")]
        public void EditWPS(WPSObj WPS)
        {
            wpsPageObjects wps = Dash.openWPS();

            wps.EditWPS(WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WPSs")]
        public void NewWPS(WPSObj WPS)
        {
            wpsPageObjects wps = Dash.openWPS();
            wps.NewWPS(WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }

        [Test]
        public void AddWPStoArea()
        {
            wpsPageObjects wps = Dash.openWPS();
            wps.AddWPStoArea(new WPSObj { });
            //missing logic
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WelderWPS")]
        public void NewWPSWelder(WelderWPSObj WPS)
        {
            wpsPageObjects wps = Dash.openWPS();
            wps.AddWelderToWPS(WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WelderWPS")]
        public void RenewWPSWelder(WelderWPSObj WPS)
        {
            wpsPageObjects wps = Dash.openWPS();
            wps.RenewWPSWelder(WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WelderWPS")]
        public void DeleteWPSWelder(WelderWPSObj WPS)
        {
            wpsPageObjects wps = Dash.openWPS();
            wps.DeleteWPSWelder(WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }
    }

}
