using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class selectNDEPageObjects
    {
        private IWebDriver _driver;

        public selectNDEPageObjects(IWebDriver driver)
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
        public void NewInspectionReport(SelectNDEObj SelectNDE)
        {

        }
        public void EditInspectionReport(SelectNDEObj SelectNDE)
        {

        }
        public void DeleteInspectionReport(SelectNDEObj SelectNDE)
        {

        }
        #endregion
    }
}