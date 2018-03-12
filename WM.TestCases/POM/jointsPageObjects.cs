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

        //Joint Number
        [FindsBy(How = How.XPath, Using = "//*[@id='JointNo']")]
        public IWebElement txtJointNumber { get; set; }

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

        //Weld Panel ----------------------------------------------------------
        //Panel
        [FindsBy(How = How.XPath, Using = "//*[@id='div_WeldJoint']/div/div[1]")]
        public IWebElement pnlWeld { get; set; }

        //Weld Date
        [FindsBy(How = How.XPath, Using = "//*[@id='strWeldDate']")]
        public IWebElement dpWeldDate { get; set; }

        //Welder
        [FindsBy(How = How.XPath, Using = "//*[@id='WelderID']")]
        public IWebElement selectWelderId { get; set; }

        //Add Welder Btn
        [FindsBy(How = How.XPath, Using = "//*[@id='collapse1']/div/div[2]/div[2]/div[5]/button")]
        public IWebElement btnAddWelder { get; set; }
        //---------------------------------------------------------------------

        //VT Panel ------------------------------------------------------------
        //VT panel Header
        [FindsBy(How = How.XPath, Using = "//*[@id='div_VTRptJoint']/div/div[1]")]
        public IWebElement pnlVT { get; set; }

        //VT report
        [FindsBy(How = How.XPath, Using = "//*[@id='VTReportID']")]
        public IWebElement selectVTReport { get; set; }

        //VT report no
        [FindsBy(How = How.XPath, Using = "//*[@id='ReportNO']")]
        public IWebElement txtVTReportNo { get; set; }

        //VT report date
        [FindsBy(How = How.XPath, Using = "//*[@id='ReportDate']")]
        public IWebElement dpVTReportDate { get; set; }

        //VT report save
        [FindsBy(How = How.XPath, Using = "//*[@id='btn_SaveReport']")]
        public IWebElement btnSaveVT { get; set; }
        //---------------------------------------------------------------------

        public void SelectLine(string lineNo)
        {
            txtLineNoSearch.Click();
            txtLineNoSearch.SendCheckKeys(lineNo);
            System.Threading.Thread.Sleep(2000);

            txtLineNoSearch.SendKeys(Keys.Down);
            txtLineNoSearch.SendKeys(Keys.Enter);
        }


        public void NewJoint(JointObj joint)
        {
            try
            {
                btnNewJoint.Click();
            }
            catch (Exception)
            {

            }


            System.Threading.Thread.Sleep(1000);

            selectSheetId.ddlSelectByLabel(joint.JointSheet);

            selectJointType.ddlSelectByLabel(joint.JointType);
            selectJointCategory.ddlSelectByLabel(joint.JointCategory);

            if (!string.IsNullOrEmpty(joint.JointNo))
            {
                txtJointNumber.SendCheckKeys(joint.JointNo);
            }

            if (string.IsNullOrEmpty(joint.Fitupdate))
            {
                dtFitup.Clear();
            }
            else
            {
                dtFitup.SendCheckKeys(joint.Fitupdate);
            }

            txtJointDIAM.SendCheckKeys(joint.DIAM);
            txtJointTHICK.SendCheckKeys(joint.THICK);

            System.Threading.Thread.Sleep(3000);

            selectJointWPS.SendKeys(Keys.Down);

            System.Threading.Thread.Sleep(3000);

            selectJointWPS.ddlSelectByLabel(joint.JointWPS);

            selectJointVI.ddlSelectByLabel(joint.VI);
            selectJointDAL.ddlSelectByLabel(joint.DAL);
            txtActivityNumber.SendCheckKeys(joint.ActivityNo);

            if (!string.IsNullOrEmpty(joint.WeldDate))
            {
                pnlWeld.Click();
                System.Threading.Thread.Sleep(1000);
                dpWeldDate.SendCheckKeys(joint.WeldDate);
                System.Threading.Thread.Sleep(1000);
                selectWelderId.Click();
                System.Threading.Thread.Sleep(1000);
                if (!string.IsNullOrEmpty(joint.Welder1))
                {
                    selectWelderId.ddlSelectByLabel(joint.Welder1);
                    System.Threading.Thread.Sleep(1000);
                    btnAddWelder.Click();
                }
                if (!string.IsNullOrEmpty(joint.Welder2))
                {
                    selectWelderId.ddlSelectByLabel(joint.Welder2);
                    System.Threading.Thread.Sleep(1000);
                    btnAddWelder.Click();
                }
                if (!string.IsNullOrEmpty(joint.Welder3))
                {
                    selectWelderId.ddlSelectByLabel(joint.Welder3);
                    System.Threading.Thread.Sleep(1000);
                    btnAddWelder.Click();
                }
                if (!string.IsNullOrEmpty(joint.Welder4))
                {
                    selectWelderId.ddlSelectByLabel(joint.Welder4);
                    System.Threading.Thread.Sleep(1000);
                    btnAddWelder.Click();
                }

            }

            if (!string.IsNullOrEmpty(joint.VTReportNumber))
            {
                //VT
                pnlVT.Click();
                System.Threading.Thread.Sleep(1000);

                try
                {
                    selectVTReport.ddlSelectByLabel(joint.VTReportNumber);
                }
                catch (Exception)
                {
                    selectVTReport.ddlSelectByLabel("Add New ...");
                    System.Threading.Thread.Sleep(3000);

                    txtVTReportNo.SendCheckKeys(joint.VTReportNumber);
                    dpVTReportDate.SendCheckKeys(joint.VTReportDate);
                    System.Threading.Thread.Sleep(1000);

                    btnSaveVT.Click();

                }
            }
            System.Threading.Thread.Sleep(3000);
        }
    }
}
