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
    public class _T_Area : Hooks
    {
        [Test]
        public void NewArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.newArea(testValues._g_Area);

            //Assert.IsTrue(area.alertN.Text.Contains("Successfully"));
        }

        [Test]
        public void EditArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.EditArea(testValues._g_Area);

            //Assert.IsTrue(area.alertN.Text.Contains("Successfully"));
        }

        [Test]
        public void DeleteArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.deleteArea(testValues._g_Area);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(area.alertD.Text.Contains("succesfully"));
        }


        //Sub Area -----------------------------------------------------------------------
        [Test]
        public void AddSubArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.AddSubArea(testValues._g_Area);

            //Assert.IsTrue(area.alertN.Text.Contains("Successfully"));
        }

        [Test]
        public void EditSubArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.EditSubArea(testValues._g_Area);

            //Assert.IsTrue(area.alertN.Text.Contains("Successfully"));
        }

        [Test]
        public void DeleteSubArea()
        {
            areasPageObjects area = Dash.openAreas();
            area.DeleteSubArea(testValues._g_Area);

            //Assert.IsTrue(area.alertN.Text.Contains("Successfully"));
        }
    }
}
