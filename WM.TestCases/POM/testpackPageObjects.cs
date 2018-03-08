
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class testpackPageObjects
    {
        private IWebDriver _driver;

        public testpackPageObjects(IWebDriver driver)
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
        public void NewTestPack(TestPackObj testPack)
        {

        }
        public void EditTestPack(TestPackObj testPack)
        {

        }
        public void DeleteTestPack(TestPackObj testPack)
        {

        }
        #endregion
    }
}