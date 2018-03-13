using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class _T_Joints:Hooks
    {
        [Test, TestCaseSource(typeof(MyFactoryClass), "JointsPP")]
        public void NewJointPlusPlus(JointObj joint)
        {
            jointsPageObjects jnts = Dash.openJoints();
            jnts.SelectLine(testValues._g_LineNo);

            System.Threading.Thread.Sleep(2000);

            jnts.NewJoint(joint);
            System.Threading.Thread.Sleep(3000);
            TestContext.WriteLine("Processing Case "  + joint.ToString() );

            for (int i = 0; i < 4; i++)
            {
                jnts.btnSavePlusPlus.Click();
                System.Threading.Thread.Sleep(3000);
                Assert.AreEqual(jnts.alertSucess.Text, "Joint Added Successfully.");              
            }
            jnts.btnSave.Click();
            System.Threading.Thread.Sleep(3000);
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "Joints")]
        public void NewJoint(JointObj joint)
        {
            jointsPageObjects jnts = Dash.openJoints();
            jnts.SelectLine(testValues._g_LineNo);
            System.Threading.Thread.Sleep(2000);

            jnts.NewJoint(joint);
            jnts.btnSave.Click();
            System.Threading.Thread.Sleep(3000);
        }


        [Test,  Category("non-admin")]
        public void DeleteOpenJointsSUCESS()
        {
            jointsPageObjects jnts = Dash.openJoints();
            jnts.SelectLine(testValues._g_LineNo);
            System.Threading.Thread.Sleep(2000);

            jnts.DeleteOpenJoints();
        }


        [Test, Property("user", "qa1"), Property("password", "123456")]
        public void DeleteWeldedJointsFAILS()
        {
            jointsPageObjects jnts = Dash.openJoints();
            jnts.SelectLine(testValues._g_LineNo);
            System.Threading.Thread.Sleep(2000);

            jnts.DeleteWeldedJointsFAILS();
        }
    }
}
