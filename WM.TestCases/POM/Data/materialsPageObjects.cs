using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class materialsPageObjects
    {
        private IWebDriver _driver;

        public materialsPageObjects(IWebDriver driver)
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
        public void New(materialObj mat)
        {

        }
        public void Edit(materialObj mat)
        {

        }
        public void Delete(materialObj mat)
        {

        }
        #endregion
    }
}