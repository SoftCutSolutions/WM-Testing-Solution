using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases.Tests.Inspection
{
    [TestFixture]
    [Parallelizable]
    class _T_SelectNDE:Hooks
    {
        [Test]
        public void EditLineReportPercentage()
        {
            selectNDEPageObjects sNDE = Dash.OpenSelectNDE();
            sNDE.EditLineReportPercentage(testValues._g_sNDEObj);
            //Assert later
        }

        [Test]
        public void EditPipingClassReportPercentage()
        {
            selectNDEPageObjects sNDE = Dash.OpenSelectNDE();
            sNDE.EditPipingClassReportPercentage(testValues._g_sNDEObj);
            //Assert later
        }

        [Test]
        public void EditLineJointTypePercentage()
        {
            selectNDEPageObjects sNDE = Dash.OpenSelectNDE();
            sNDE.EditLineJointTypePercentage(testValues._g_sNDEObj);
            //Assert later
        }

        [Test]
        public void ValidatePercentage()
        {
            selectNDEPageObjects sNDE = Dash.OpenSelectNDE();
            sNDE.ValidatePercentage(testValues._g_sNDEObj);
            //Assert later
        }
    }
}
