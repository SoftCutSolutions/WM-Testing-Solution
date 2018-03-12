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
        [Test, TestCaseSource(typeof(MyFactoryClass), "Lines")]
        public void NewLine(lineObj Line)
        {
            linePageObjects line = Dash.openLines();
            line.NewLine(Line);
            System.Threading.Thread.Sleep(1000);
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "Lines")]
        public void EditLine(lineObj Line)
        {
            linePageObjects line = Dash.openLines();
            line.EditLine(Line);
            System.Threading.Thread.Sleep(1000);
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "Lines")]
        public void DeleteLine(lineObj Line)
        {
            linePageObjects line = Dash.openLines();
            line.DeleteLine(Line);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //Assert.IsTrue(area.alertD.Text.Contains("succesfully"));
        }
    }
}
