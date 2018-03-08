using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class impexpPageObjects
    {
        private IWebDriver _driver;

        public impexpPageObjects(IWebDriver driver)
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
        public void New(ImpExpObj impexp)
        {

        }
        public void Edit(ImpExpObj impexp)
        {

        }
        public void Delete(ImpExpObj impexp)
        {

        }
        #endregion
    }
}