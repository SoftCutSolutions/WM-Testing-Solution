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
    public class _T_Joints:Hooks
    {
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
            jnts.selectJointWPS.ddlSelectByLabel(testValues._g_WPS.WPSName);
            System.Threading.Thread.Sleep(3000);


            for (int i = 0; i < 4; i++)
            {
                //jnts.dtFitup.SendCheckKeys(DateTime.Today.ToShortDateString());
                jnts.btnSavePlusPlus.Click();
                System.Threading.Thread.Sleep(3000);
            }

            for (int i = 0; i < 4; i++)
            {
                jnts.dtFitup.SendCheckKeys(DateTime.Today.ToShortDateString());
                jnts.selectJointType.ddlSelectByLabel("SW");
                jnts.btnSavePlusPlus.Click();
                System.Threading.Thread.Sleep(3000);
            }


            jnts.btnSave.Click();

            System.Threading.Thread.Sleep(3000);


        }
    }
}
