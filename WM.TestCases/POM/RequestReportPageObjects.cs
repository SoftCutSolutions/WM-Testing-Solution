
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class RequestReportPageObjects
    {
        private IWebDriver _driver;
        public RequestReportPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        #region Objects

        //New Request Report
        [FindsBy(How = How.XPath, Using = "//*[@id='addNewRequest']")]
        public IWebElement btnNewRequestReport { get; set; }

        //Request Report Type
        [FindsBy(How = How.XPath, Using = "//*[@id='RequestReportType']")]
        public IWebElement selectRequestType { get; set; }

        //Report Number
        [FindsBy(How = How.XPath, Using = "//*[@id='RequestNumber']")]
        public IWebElement txtReportNumber { get; set; }

        //Report Date
        [FindsBy(How = How.XPath, Using = "//*[@id='strRequestDate']")]
        public IWebElement dpReportDate { get; set; }

        //save
        [FindsBy(How = How.XPath, Using = "//*[@id='btn_SaveRequestReport']")]
        public IWebElement btnSaveRequestReport { get; set; }



        //Find Record
        [FindsBy(How = How.XPath, Using = "//*[@id='search_tblRequestList_top']/div/span")]
        public IWebElement btnFindrecord { get; set; }

        //SelectTop - conditions
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblRequestList']/table/tbody/tr[3]/td[3]/select")]
        public IWebElement dpselectTop { get; set; }

        //SelectTop
        [FindsBy(How = How.XPath, Using = "//*[@id='jqg1']")]
        public IWebElement txtbox { get; set; }

        // Find
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblRequestList_search']")]
        public IWebElement btnFind { get; set; }


        //Edit
        [FindsBy(How = How.XPath, Using = " //*[@id='tblRequestList']/tbody/tr[2]/td[12]/div/button[2]/span")]
        public IWebElement btnEdit { get; set; }

        //Delete
        [FindsBy(How = How.XPath, Using = "//*[@id='tblRequestList']/tbody/tr[2]/td[12]/div/button[3]/span")]
        public IWebElement btndelete { get; set; }

        //ok
        [FindsBy(How = How.XPath, Using = "//button[2][@type='button']")]
        public IWebElement btnok { get; set; }

        //Approvals --------------------------------------------
        //Aprv1
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[1]/td[2]/div")]
        public IWebElement selectApproval1 { get; set; }

        //Aprv1box
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[1]/td[2]/div/div/div/input")]
        public IWebElement selectApprovalBox1 { get; set; }

        //Aprv1boxfr
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[1]/td[2]/div/div/ul/li[1]")]
        public IWebElement optAprfr1 { get; set; }

        

        //Aprv2
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[2]/td[2]/div")]
        public IWebElement selectApproval2 { get; set; }

        //Aprvbox2
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[2]/td[2]/div/div/div/input")]
        public IWebElement selectApprovalBox2 { get; set; }

        //Aprv2boxfr
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[2]/td[2]/div/div/ul/li[1]")]
        public IWebElement optAprfr2 { get; set; }

        //Aprv3
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[3]/td[2]/div")]
        public IWebElement selectApproval3 { get; set; }

        //Aprvbox3
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[3]/td[2]/div/div/div/input")]
        public IWebElement selectApprovalBox3 { get; set; }

        //Aprv3boxfr
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[3]/td[2]/div/div/ul/li[1]")]
        public IWebElement optAprfr3 { get; set; }

        //Aprv4
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[4]/td[2]/div/a")]
        public IWebElement selectApproval4 { get; set; }

        //Aprvbox4
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[4]/td[2]/div/div/div/input")]
        public IWebElement selectApprovalBox4 { get; set; }

        //Aprv4boxfr
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJointWelders']/tbody/tr[4]/td[2]/div/div/ul/li[1]")]
        public IWebElement optAprfr4 { get; set; }
        //---------------------------------------------------------

        #endregion

        #region Methods

        public void NewRequestReport(RequestReportObj Request)
        {

            btnNewRequestReport.Click();
            System.Threading.Thread.Sleep(3000);


            selectRequestType.ddlSelectByLabel(Request.reportType);
            System.Threading.Thread.Sleep(1000);

            txtReportNumber.SendCheckKeys(Request.reportNumber);
            dpReportDate.SendCheckKeys(Request.reportDate);
            System.Threading.Thread.Sleep(1000);

            btnSaveRequestReport.Click();
            System.Threading.Thread.Sleep(1000);

        }

        public void EditRequestApprovals(RequestReportObj Request)
        {
            //Find
            btnFindrecord.Click();
            System.Threading.Thread.Sleep(3000);

            txtbox.SendCheckKeys(Request.reportNumber);
            System.Threading.Thread.Sleep(2000);

            btnFind.Click();
            System.Threading.Thread.Sleep(3000);

            //Edit
            btnEdit.Click();
            System.Threading.Thread.Sleep(4000);

            if (!string.IsNullOrEmpty(Request.Approver1))
            {
                selectApproval1.Click();
                selectApprovalBox1.SendCheckKeys(Request.Approver1);
                optAprfr1.Click();
                System.Threading.Thread.Sleep(3000);
            }
            if (!string.IsNullOrEmpty(Request.Approver2))
            {
                selectApproval2.Click();
                selectApprovalBox2.SendCheckKeys(Request.Approver2);
                optAprfr2.Click();
                System.Threading.Thread.Sleep(3000);
            }
            if (!string.IsNullOrEmpty(Request.Approver3))
            {
                selectApproval3.Click();
                selectApprovalBox3.SendCheckKeys(Request.Approver3);
                optAprfr3.Click();
                System.Threading.Thread.Sleep(3000);
            }
            if (!string.IsNullOrEmpty(Request.Approver4))
            {
                selectApproval4.Click();
                selectApprovalBox4.SendCheckKeys(Request.Approver4);
                optAprfr4.Click();
                System.Threading.Thread.Sleep(3000);
            }


            btnSaveRequestReport.Click();
            System.Threading.Thread.Sleep(3000);

        }


        public void Delete(RequestReportObj Request)
        {

            //Find
            btnFindrecord.Click();
            System.Threading.Thread.Sleep(3000);

            txtbox.SendCheckKeys(Request.reportNumber);
            System.Threading.Thread.Sleep(1000);

            btnFind.Click();
            System.Threading.Thread.Sleep(3000);

            //Delete
            btndelete.Click();
            System.Threading.Thread.Sleep(1000);

            btnok.Click();
            System.Threading.Thread.Sleep(2000);

        }


        #endregion
    }
}