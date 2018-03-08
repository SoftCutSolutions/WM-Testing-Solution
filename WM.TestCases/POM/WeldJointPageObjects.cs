using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class WeldJointPageObjects
    {
        private IWebDriver _driver;

        public WeldJointPageObjects(IWebDriver driver)
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
        public void New(WeldJointObj weldJnt)
        {

        }
        public void Edit(WeldJointObj weldJnt)
        {

        }
        public void Delete(WeldJointObj weldJnt)
        {

        }
        #endregion
    }
}