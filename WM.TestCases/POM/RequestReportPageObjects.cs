
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

        #endregion

        #region Methods

        public void New(RequestReportObj Request)
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

        public void Edit(RequestReportObj Request)
        {
            //Find
            btnFindrecord.Click();
            System.Threading.Thread.Sleep(3000);

            txtbox.SendCheckKeys(Request.reportNumber);
            System.Threading.Thread.Sleep(1000);

            btnFind.Click();
            System.Threading.Thread.Sleep(3000);

            //Edit
            btnEdit.Click();
            System.Threading.Thread.Sleep(3000);

            //This should cover approvals later instead of changing dates 
            dpReportDate.SendCheckKeys(Request.reportDate);
            System.Threading.Thread.Sleep(1000);

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