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
    class _T_Welder:Hooks
    {
        [Test, TestCaseSource(typeof(MyFactoryClass), "Welders")]
        public void NewWelder(WelderObj welder)
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.NewWelder(welder);
            System.Threading.Thread.Sleep(2000);

            Assert.That(driver.PageSource.Contains("Successfully"));
            //driver.Dispose();

        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "Welders")]
        public void EditWelder(WelderObj welder)
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.EditWelder(welder);
            System.Threading.Thread.Sleep(1000);

            //Assert.That(driver.PageSource.Contains("Successfully"));
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "Welders")]
        public void DeleteWelder(WelderObj welder)
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.DeleteWelder(welder);
            System.Threading.Thread.Sleep(2000);

            Assert.That(driver.PageSource.Contains("Successfully"));
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WelderWPS")]
        public void NewWelderWPS(WelderWPSObj WW)
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.NewWelderWPS(WW);
            System.Threading.Thread.Sleep(1000);
            
        }

        [Test]
        public void ActivateDeactivateWelder()
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.WelderDeactivate(testValues._g_Welder);
            System.Threading.Thread.Sleep(1000);

        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WelderWPS")]
        public void RenewWelderWPS(WelderWPSObj WW)
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.RenewWelderWPS(WW);
            System.Threading.Thread.Sleep(1000);
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "WelderWPS")]
        public void DeleteWelderWPS(WelderWPSObj WW)
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.DeleteWelderWPS(WW);
            System.Threading.Thread.Sleep(1000);
        }
    }



    }
