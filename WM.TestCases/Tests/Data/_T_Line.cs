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
    public class _T_Line :Hooks
    {
        [Test]
        public void NewLine()
        {
            linePageObjects line = Dash.openLines();
            line.NewLine(testValues._g_Line);
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void EditLine()
        {
            linePageObjects line = Dash.openLines();
            line.EditLine(testValues._g_Line);
            System.Threading.Thread.Sleep(1000);
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
