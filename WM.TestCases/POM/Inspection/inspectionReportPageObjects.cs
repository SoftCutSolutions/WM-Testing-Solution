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
        ////WPS Search value
        //[FindsBy(How = How.XPath, Using = "//*[@id='jqg2']")]
        //public IWebElement txtSearchValue { get; set; }
        #endregion

        #region Methods
        public void NewInspectionReport(InspectionReportObj InspectionReport)
        {

        }
        public void EditInspectionReport(InspectionReportObj InspectionReport)
        {

        }
        public void DeleteInspectionReport(InspectionReportObj InspectionReport)
        {

        }
        #endregion
    }
}