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
        public IWebElement dpReporType { get; set; }

        //save
        [FindsBy(How = How.XPath, Using = "//*[@id='btn_SaveRequestReport']")]
        public IWebElement btnSaveRequestReport { get; set; }


        #endregion

        #region Methods

        public void NewRequestReport(RequestReportObj request)
        {
            btnNewRequestReport.Click();
            System.Threading.Thread.Sleep(3000);


            selectRequestType.ddlSelectByLabel(request.reportType);
            txtReportNumber.SendCheckKeys(request.reportNumber);
            dpReporType.SendCheckKeys(request.reportDate);
            System.Threading.Thread.Sleep(1000);

            btnSaveRequestReport.Click();
            System.Threading.Thread.Sleep(1000);

        }
        #endregion
    }
}