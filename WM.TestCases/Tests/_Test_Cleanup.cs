using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WM.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class _WPS_T3 : Hooks
    {
        public _WPS_T3()
        {

        }
        [Test]
        public void DeleteWPS()
        {
            wpsPageObjects wps = Dash.openWPS();
            System.Threading.Thread.Sleep(1000);

            wps.DeleteWPS(testValues._g_WPS);
            System.Threading.Thread.Sleep(1000);

        }
    }

    [TestFixture]
    [Parallelizable]
    public class _welders_T3 : Hooks
    {
        public _welders_T3()
        {

        }
        [Test]
        public void DeleteWelder()
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.DeleteWelder(testValues._g_Welder);
            System.Threading.Thread.Sleep(1000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class _definitions_T3 : Hooks
    {
        public _definitions_T3()
        {

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

    [TestFixture]
    [Parallelizable]
    public class _area_T3 : Hooks
    {
        public _area_T3()
        {

        }
        [Test]
        public void DeleteArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.deleteArea(testValues._g_Area);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(area.alertD.Text.Contains("succesfully"));
        }
    }

    [TestFixture]
    [Parallelizable]
    public class _line_T3 : Hooks
    {
        public _line_T3()
        {

        }
        [Test]
        public void DeleteLine()
        {
            linePageObjects line = Dash.openLines();
            line.DeleteLine(testValues._g_Line);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(area.alertD.Text.Contains("succesfully"));
        }
    }
}
