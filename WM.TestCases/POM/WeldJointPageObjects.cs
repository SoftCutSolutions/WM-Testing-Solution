using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class WeldJointPageObjects
    {
        private IWebDriver _driver;

        public WeldJointPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }



        #region Objects
        //Line
        [FindsBy(How = How.XPath, Using = "//*[@id='Line']")]
        public IWebElement txtLine { get; set; }

        //WPS
        [FindsBy(How = How.XPath, Using = "//*[@id='WPSID']")]
        public IWebElement selectWPS { get; set; }

        //Send Notification checkbox
        [FindsBy(How = How.XPath, Using = "//*[@id='SendNotification']")]
        public IWebElement cbSendNotifications { get; set; }

        //WeldJoints button
        [FindsBy(How = How.XPath, Using = "//*[@id='WeldJoints']")]
        public IWebElement btnWeldJoints { get; set; }

        //Request Report
        [FindsBy(How = How.XPath, Using = "//*[@id='RequestRptID']")]
        public IWebElement selectRequestReport { get; set; }

        //WeldDate
        [FindsBy(How = How.XPath, Using = "//*[@id='WeldDate']")]
        public IWebElement dpWeldDate { get; set; }

        //WelderID
        [FindsBy(How = How.XPath, Using = "//*[@id='WelderID']")]
        public IWebElement selectWelderID { get; set; }


        //Add Welder 
        [FindsBy(How = How.XPath, Using = "//*[@id='div_Weld']/div[2]/div[3]/div[2]/div[3]/button")]
        public IWebElement btnAddWelder { get; set; }


        //Select All Joints in Grid
        [FindsBy(How = How.XPath, Using = "//*[@id='cb_tblJointWelding']")]
        public IWebElement cbSelectAllJoints { get; set; }


        #endregion

        #region Methods
        public void NewWeldJoint(WeldJointObj g_WelJointObj)
        {
            txtLine.SendCheckKeys(testValues._g_LineNo);
            System.Threading.Thread.Sleep(2000);

            txtLine.SendKeys(Keys.Down);
            txtLine.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);


            selectWPS.ddlSelectByLabel(g_WelJointObj.WPS);
            System.Threading.Thread.Sleep(3000);

            dpWeldDate.SendCheckKeys(g_WelJointObj.WeldDate);
            System.Threading.Thread.Sleep(3000);

            selectWelderID.ddlSelectByLabel(g_WelJointObj.Welder1);
            btnAddWelder.Click();
            System.Threading.Thread.Sleep(3000);

            selectWelderID.Click();
            selectWelderID.ddlSelectByLabel(g_WelJointObj.Welder2);
            btnAddWelder.Click();
            System.Threading.Thread.Sleep(3000);


            cbSelectAllJoints.Click();
            btnWeldJoints.Click();
        }

        public void EditWeldJoint(object g_WelJointObj)
        {
            throw new NotImplementedException();
        }
        public void DeleteWeldJoint(object g_WelJointObj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}