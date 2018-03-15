using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class inspectionReportPageObjects
    {
        private IWebDriver _driver;

        public inspectionReportPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        #region Objects

        //New Inspection report
        [FindsBy(How = How.XPath, Using = "//*[@id='NEWInspectionReport']")]
        public IWebElement btnNewInspectionReport { get; set; }

        //Select Report Type
        [FindsBy(How = How.XPath, Using = "//*[@id='ReportTypeID']")]
        public IWebElement btnSelectReportType { get; set; }

        //Report no
        [FindsBy(How = How.XPath, Using = "//*[@id='ReportNO']")]
        public IWebElement txtReportno { get; set; }

        //Report Date
        [FindsBy(How = How.XPath, Using = "//*[@id='ReportDate']")]
        public IWebElement txtreportDate { get; set; }

        //Remark
        [FindsBy(How = How.XPath, Using = "//*[@id='Remarks']")]
        public IWebElement txtRemark { get; set; }

        //select joint
        [FindsBy(How = How.XPath, Using = "//*[@id='tblNDEJoints']/tbody/tr[2]")]
        public IWebElement selectJoint { get; set; }

        //save
        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        public IWebElement btnSave { get; set; }

        //Report Number
        [FindsBy(How = How.XPath, Using = "//*[@id='gs_ReportName']")]
        public IWebElement TxtReportNumber { get; set; }

        //View Report Details
        [FindsBy(How = How.XPath, Using = "//*[@id='tblNDEReports']/tbody/tr[2]/td[14]/div/button[1]")]
        public IWebElement btnReportDetails { get; set; }

        //Accept Selected joints for VT
        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Accept')]")]
        public IWebElement btnAcceptSelectedJoint { get; set; }

        // Add joint.
        [FindsBy(How = How.XPath, Using = "//*[@id='tblReportJoints']/tbody/tr[2]")]
        public IWebElement chkbxjoint { get; set; }

        //Action By
        [FindsBy(How = How.XPath, Using = "//*[@id='OnBehalfUserID']")]
        public IWebElement dpActionBy { get; set; }

        // Assessment Report no
        [FindsBy(How = How.XPath, Using = "//*[@id='AssessmentReportNO']")]
        public IWebElement txtAssessmentReportno { get; set; }

        //Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='tblNDEReports']/tbody/tr[2]/td[14]/div/button[2]")]
        public IWebElement btnEdit { get; set; }

        //Edit Save 
        [FindsBy(How = How.XPath, Using = "//*[@id='btn_SaveReport']")]
        public IWebElement btnEditSave { get; set; }

        // Delete
        [FindsBy(How = How.XPath, Using = "//*[@id='tblNDEReports']/tbody/tr[2]/td[14]/div/button[6]")]
        public IWebElement btnDelete { get; set; }

        //ok
        [FindsBy(How = How.XPath, Using = "//button[2][@type='button']")]
        public IWebElement btnok { get; set; }


        //Reject first row joint
        [FindsBy(How = How.XPath, Using = "//*[@id='tblReportJoints']/tbody/tr[2]/*/*/button[3]")]
        public IWebElement btnRejectFirstRowJoint { get; set; }

        //Rejection Reason
        [FindsBy(How = How.XPath, Using = "//*[@id='RejectionReason']")]
        public IWebElement TxtRejectionReason { get; set; }

        //preparefor Checkbox RT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblReadyNDEReport']/tbody/tr/td[contains(.,'RT')]/input[1]")]
        public IWebElement chkPrepareforRT { get; set; }
        #endregion


        #region Methods
        public void NewInspectionReport(InspectionReportObj InspectionReport)
        {



            //New Inspection report
            btnNewInspectionReport.Click();
            System.Threading.Thread.Sleep(5000);

            btnSelectReportType.ddlSelectByLabel(InspectionReport.reportType);
            System.Threading.Thread.Sleep(2000);
            txtReportno.SendCheckKeys(InspectionReport.reportNumber);
            txtreportDate.SendCheckKeys(InspectionReport.reportDate);
            txtRemark.SendCheckKeys(InspectionReport.remark);
            System.Threading.Thread.Sleep(3000);
            /* _driver.Navigate().Refresh();
             System.Threading.Thread.Sleep(5000);*/

            selectJoint.Click();
            // selectJoint1.Click();
            // selectJoint2.Click();
            System.Threading.Thread.Sleep(2000);

            btnSave.Click();
            System.Threading.Thread.Sleep(5000);
        }

        public void AcceptRejectInspectionReport(InspectionReportObj InspectionReport)
        {
            TxtReportNumber.SendCheckKeys(InspectionReport.reportNumber);
            System.Threading.Thread.Sleep(2000);
            btnReportDetails.Click();
            System.Threading.Thread.Sleep(5000);
            chkbxjoint.Click();
            System.Threading.Thread.Sleep(2000);
            if (InspectionReport.mode == "accept")
            {
                btnAcceptSelectedJoint.Click();
                System.Threading.Thread.Sleep(8000);
                //dpActionBy.ddlSelectByLabel(InspectionReport.ActionBy);
                if (InspectionReport.reportType == "RT" & !string.IsNullOrEmpty(InspectionReport.AssessmentReportNo))
                {
                    txtAssessmentReportno.SendCheckKeys(InspectionReport.AssessmentReportNo);
                }
                if (!string.IsNullOrEmpty(InspectionReport.prepareFor) && InspectionReport.reportType == "VT" && InspectionReport.prepareFor == "RT")
                {
                    chkPrepareforRT.Click();
                }
                System.Threading.Thread.Sleep(2000);
                btnSave.Click();
                System.Threading.Thread.Sleep(5000);
            }
            else
            {
                btnRejectFirstRowJoint.Click();
                System.Threading.Thread.Sleep(2000);
                if (InspectionReport.reportType != "RT") { btnok.Click(); }
                System.Threading.Thread.Sleep(8000);
                dpActionBy.ddlSelectByLabel(InspectionReport.ActionBy);
                TxtRejectionReason.SendCheckKeys(InspectionReport.RejectionReason);
                if (InspectionReport.reportType == "RT") {
                    //Penalty
                }
                btnSave.Click();
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void EditInspectionReport(InspectionReportObj InspectionReport)
        {
            //Edit Inspection report
            TxtReportNumber.SendCheckKeys(InspectionReport.reportNumber);
            System.Threading.Thread.Sleep(3000);

            btnEdit.Click();
            System.Threading.Thread.Sleep(5000);

            txtreportDate.SendCheckKeys(InspectionReport.reportDate);
            txtRemark.SendCheckKeys(InspectionReport.remark);
            System.Threading.Thread.Sleep(2000);

            btnEditSave.Click();
            System.Threading.Thread.Sleep(2000);

        }

        public void DeleteInspectionReport(InspectionReportObj InspectionReport)
        {
            //Delete Inspection report
            TxtReportNumber.SendCheckKeys(InspectionReport.reportNumber);
            System.Threading.Thread.Sleep(2000);

            btnDelete.Click();
            System.Threading.Thread.Sleep(2000);

            btnok.Click();
            System.Threading.Thread.Sleep(2000);
        }
        #endregion
    }
}