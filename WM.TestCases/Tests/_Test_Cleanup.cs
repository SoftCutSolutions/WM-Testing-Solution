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
    public class _Test_Cleanup_S1 : Hooks
    {
        public _Test_Cleanup_S1() : base(Browser.Chrome, Mode.Docker)
        {


        }
        [Test]
        public void DeletePipingClass()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login("admin", "WMsoftcut!");
            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            definitionsPageObjects defs = dash.openDefinitions();
            defs.DeletePipingClass("4CS01P");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(defs.alert.Text.ToLower().Contains("succesfully"));
        }

        [Test]
        public void DeleteWPS()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login("admin", "WMsoftcut!");
            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            WPSObj w = new WPSObj {WPSName = "_WPS01"};

            wpsPageObjects wps = dash.openWPS();
            System.Threading.Thread.Sleep(1000);

            wps.DeleteWPS(w);
            System.Threading.Thread.Sleep(1000);

        }
        [Test]
        public void NewArea2()
        {

        }


    }

    [TestFixture]
    [Parallelizable]
    public class _Test_Cleanup_S2 : Hooks
    {
        public _Test_Cleanup_S2(): base(Browser.Chrome, Mode.Docker)
        {

        }

        [Test]
        public void DeleteLine()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login("admin", "WMsoftcut!");
            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            linePageObjects line = dash.openLines();

            lineObj ln = new lineObj
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

            line.DeleteLine(ln);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(area.alertD.Text.Contains("succesfully"));
        }

        [Test]
        public void DeleteArea()
        {
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects dash = login.login("admin", "WMsoftcut!");
            Assert.IsTrue(dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));

            areasPageObjects area = dash.openAreas();
            area.deleteArea("Regression Area");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(area.alertD.Text.Contains("succesfully"));
        }

    }
}
