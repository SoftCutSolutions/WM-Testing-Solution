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
    class _T_TestPackage:Hooks
    {
        [Test]
        public void NewTestPackage()
        {
            testpackPageObjects tp = Dash.openTestPackage();
            tp.NewTestPack(testValues._g_TestPackage);
            //Assert later
        }

        [Test]
        public void AssignTestPackJoints()
        {
            testpackPageObjects tp = Dash.openTestPackage();
            tp.AssignTestPackJoints(testValues._g_TestPackage);
            //Assert later

        }

        [Test]
        public void EditTestPackage()
        {
            testpackPageObjects tp = Dash.openTestPackage();
            tp.EditTestPack(testValues._g_TestPackage);
            //Assert later

        }

        [Test]
        public void DeleteTestPack()
        {
            testpackPageObjects tp = Dash.openTestPackage();
            tp.DeleteTestPack(testValues._g_TestPackage);
            //Assert later

        }

        [Test]
        public void AcceptTestPack()
        {
            testpackPageObjects tp = Dash.openTestPackage();
            tp.AcceptTestPack(testValues._g_TestPackage);
            //Assert later

        }

        [Test]
        public void RejectTestPack()
        {
            testpackPageObjects tp = Dash.openTestPackage();
            tp.RejectTestPack(testValues._g_TestPackage);
            //Assert later

        }
    }
}
