using NUnit.Framework;
using System;

namespace WM.TestCases
{

    [TestFixture]
    //[Parallelizable]
    public class _welders_T2 : Hooks
    {
        public _welders_T2()
        {

        }
        [Test]
        public void EditWelder()
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.EditWelder(testValues._g_Welder);
            System.Threading.Thread.Sleep(1000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class _welders_T1 : Hooks
    {
        public _welders_T1()
        {

        }
        [Test]
        public void NewWelder()
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.NewWelder(testValues._g_Welder, testValues._g_WelderProcessValues);
            System.Threading.Thread.Sleep(1000);
        }
    }


    [TestFixture]
    [Parallelizable]
    public class _definitions_T1 :Hooks
    {
        public _definitions_T1()
        {

        }
        [Test]
        public void NewPipingClass()
        {
            definitionsPageObjects defs = Dash.openDefinitions();
            defs.NewPipingClass(testValues._g_PipingClass);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }
    }

    [TestFixture]
    [Parallelizable]
    public class _area_T2 : Hooks
    {
        public _area_T2()
        {

        }
        //Edit Area
    }

    [TestFixture]
    [Parallelizable]
    public class _area_T1 : Hooks
    {
        public _area_T1()
        {

        }
        [Test]
        public void NewArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.newArea(testValues._g_Area);

            //Assert.IsTrue(area.alertN.Text.Contains("Successfully"));
        }
    }


    [TestFixture]
    [Parallelizable]
    public class _line_T2 : Hooks
    {
        //EditLine
    }

    [TestFixture]
    //[Parallelizable]
    public class _line_T1 : Hooks
    {
        public _line_T1()
        {

        }
        [Test]
        public void NewLine()
        {
            linePageObjects line = Dash.openLines();
            line.NewLine(testValues._g_Line);
            System.Threading.Thread.Sleep(1000);
        }
    }


    [TestFixture]
    //[Parallelizable]
    public class _joints_T1 : Hooks
    {
        public _joints_T1()
        {

        }
        [Test]
        public void NewJointPlusPlus()
        {
            jointsPageObjects jnts = Dash.openJoints();
            jnts.SelectLine(testValues._g_Line.LineNo);

            System.Threading.Thread.Sleep(2000);

            jnts.selectSheetId.waitforElement();

            //5 Joints with No WPS not FitupDate
            jnts.NewJointPlusPlus(testValues._g_Line.SheetNo1, testValues._g_Joint);
            System.Threading.Thread.Sleep(3000);

            for (int i = 0; i < 4; i++)
            {
                jnts.dtFitup.Clear();
                jnts.btnSavePlusPlus.Click();
                System.Threading.Thread.Sleep(3000);
            }

            //5 Joints with WPS1
            jnts.selectJointWPS.ddlSelectByLabel("WPS-01");
            System.Threading.Thread.Sleep(3000);


            for (int i = 0; i < 4; i++)
            {
                jnts.btnSavePlusPlus.Click();
                System.Threading.Thread.Sleep(3000);
            }


            jnts.btnSave.Click();

            System.Threading.Thread.Sleep(3000);


        }
    }



 [TestFixture]
    [Parallelizable]
    public class _WPS_T1 : Hooks
    {
        [Test]
        public void NewWPS()
        {
            wpsPageObjects wps = Dash.openWPS();

            wps.NewWPS(testValues._g_WPS);

            //System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }
    }


    //[TestFixture]
    //[Parallelizable]
    //public class _template_T1 : Hooks
    //{
    //    ctor

    //    [Test]
    //public void method()
    //    { }
    //}

}
