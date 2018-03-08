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
    public class _Test_basicDataEntry_s1 :Hooks
    {
        private string username = "admin";
        private string password = "WMsoftcut!";
        private string PipingClass = "4CS01P";

        public _Test_basicDataEntry_s1() :base(Browser.Chrome, Mode.Docker)
        {
                
        }

        [Test]
        public void NewPipingClass()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login(username, password);
            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            definitionsPageObjects defs = dash.openDefinitions();
            defs.NewPipingClass(PipingClass);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }
        [Test]
        public void NewWPS()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login(username, password);
            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            wpsPageObjects wps = dash.openWPS();
            WPSObj w = new WPSObj
            {
                WPSCode= "ASME IX",
                WPSName="_WPS01",
                PQR="PQR01",
                ThickFrom= "0",
                ThickTo="12",
                DIAFrom="0",
                DIATo="24"
            };
            wps.NewWPS(w);

            System.Threading.Thread.Sleep(1000);
            //Assert.IsTrue(defs.alert.Text.Contains("Successfully"));
        }

    }

    [TestFixture]
    [Parallelizable]
    public class _Test_basicDataEntry_s2 : Hooks
    {
        private string username = "admin";
        private string password = "WMsoftcut!";
        private string Area = "Regression Area";

        private lineObj ln = new lineObj
        {
            AreaCode = "Regression Area",
            LineNo = "Line01",
            PipingClass = "4CS01P",
            MainSize = "12",
            revision = "A",
            DrawingNo1 = "Draw0123",
            DrawingNo2 = "Draw0124",
            SheetNo1 = "1/2",
            SheetNo2 = "2/2",
            Service = "Anti Foam"
        };

        public _Test_basicDataEntry_s2(): base(Browser.Chrome, Mode.Local)
        {
            
        }

        [Test]
        public void NewArea()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login(username, password);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            areasPageObjects area = dash.openAreas();
            area.newArea(Area);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(area.alertN.Text.Contains("Successfully"));
        }

        [Test]
        public void NewLine()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login(username, password);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            linePageObjects line = dash.openLines();

            line.NewLine(ln);

            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void NewJointPlusPlus()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login(username, password);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            jointsPageObjects jnts = dash.openJoints();
            jnts.SelectLine("Line01");

            System.Threading.Thread.Sleep(2000);

            jnts.selectSheetId.waitforElement();

            string sheet = "1/2";

            JointObj j = new JointObj
            {
                JointCategory = "FIELD",
                JointType = "BW",
                DIAM = "12",
                THICK = "2",
                JointWPS = "No WPS",
                DAL = "DAL-001",
                VI = "VI-12",
                ActivityNo = "1",
                Fitupdate = "12-2-2018"
            };

            //5 Joints with No WPS not FitupDate
            jnts.NewJointPlusPlus(sheet, j);
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
}
