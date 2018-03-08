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
        ////WPS Search value
        //[FindsBy(How = How.XPath, Using = "//*[@id='jqg2']")]
        //public IWebElement txtSearchValue { get; set; }
        #endregion

        #region Methods
        public void New(RequestReportObj Request)
        {

        }
        public void Edit(RequestReportObj Request)
        {

        }
        public void Delete(RequestReportObj Request)
        {

        }
        #endregion
    }
}