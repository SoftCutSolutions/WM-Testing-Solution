using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    class jointsPageObjects
    {
        private IWebDriver _driver;
        public jointsPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        //Line Search
        [FindsBy(How = How.XPath, Using = "//*[@id='Line']")]
        public IWebElement txtLineNoSearch { get; set; }

        //Joint New btn
        [FindsBy(How = How.XPath, Using = "//*[@id='btn_AddNewJoint']")]
        public IWebElement btnNewJoint { get; set; }

        //Sheet Id
        [FindsBy(How = How.XPath, Using = "//*[@id='SheetID']")]
        public IWebElement selectSheetId { get; set; }

        //Joint Type
        [FindsBy(How = How.XPath, Using = "//*[@id='JointType']")]
        public IWebElement selectJointType { get; set; }

        //Joint Category
        [FindsBy(How = How.XPath, Using = "//*[@id='JointCategory']")]
        public IWebElement selectJointCategory { get; set; }

        //Joint DIAM
        [FindsBy(How = How.XPath, Using = "//*[@id='DIAM']")]
        public IWebElement txtJointDIAM { get; set; }

        //Joint THICK
        [FindsBy(How = How.XPath, Using = "//*[@id='THICK']")]
        public IWebElement txtJointTHICK { get; set; }

        //Joint WPS
        [FindsBy(How = How.XPath, Using = "//*[@id='WPSID']")]
        public IWebElement selectJointWPS { get; set; }

        //Joint VI
        [FindsBy(How = How.XPath, Using = "//*[@id='VIRequestRptID']")]
        public IWebElement selectJointVI { get; set; }

        //Joint DAL
        [FindsBy(How = How.XPath, Using = "//*[@id='DALRequestRptID']")]
        public IWebElement selectJointDAL { get; set; }

        //Joint ActivityNumber
        [FindsBy(How = How.XPath, Using = "//*[@id='ActivityNumber']")]
        public IWebElement txtActivityNumber { get; set; }

        //Joint Save btn
        [FindsBy(How = How.XPath, Using = "//*[@id='Save']")]
        public IWebElement btnSave { get; set; }

        //Joint Fitupdate Date
        [FindsBy(How = How.XPath, Using = "//*[@id='FitupDate']")]
        public IWebElement dtFitup { get; set; }

        //Joint Save++ btn
        [FindsBy(How = How.XPath, Using = "//*[@id='SaveAndNew']")]
        public IWebElement btnSavePlusPlus { get; set; }

        public void SelectLine(string lineNo)
        {
            txtLineNoSearch.Click();
            txtLineNoSearch.SendCheckKeys(lineNo);
            System.Threading.Thread.Sleep(2000);

            txtLineNoSearch.SendKeys(Keys.Down);
            txtLineNoSearch.SendKeys(Keys.Enter);
        }

        public void NewJointPlusPlus(string sheetId, JointObj joint)
        {
            btnNewJoint.Click();
            System.Threading.Thread.Sleep(1000);

            selectSheetId.ddlSelectByLabel(sheetId);

            selectJointType.ddlSelectByLabel(joint.JointType);
            selectJointCategory.ddlSelectByLabel(joint.JointCategory);

            dtFitup.Clear();

            txtJointDIAM.SendCheckKeys(joint.DIAM);
            txtJointTHICK.SendCheckKeys(joint.THICK);

            selectJointWPS.SendKeys(Keys.Down);
            selectJointWPS.SendKeys(Keys.Down);

            System.Threading.Thread.Sleep(5000);

            selectJointWPS.ddlSelectByLabel(joint.JointWPS);

            selectJointVI.ddlSelectByLabel(joint.VI);
            selectJointDAL.ddlSelectByLabel(joint.DAL);
            txtActivityNumber.SendCheckKeys(joint.ActivityNo);

            btnSavePlusPlus.Click();
        }
    }
}
