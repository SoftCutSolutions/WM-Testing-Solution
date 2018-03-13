
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
        ////TestPackage xxxx
        //[FindsBy(How = How.XPath, Using = "//*[@id='jqg2']")]
        //public IWebElement btnNewXxxxx { get; set; }
        #endregion

        #region Methods

        public void NewTestPack(TestPackObj testPack)
        {
            //Fill in mandator Details
        }
        public void EditTestPack(TestPackObj testPack)
        {
            //fill in optional details

            //assign Joints from a Line01
            
        }

        public void AssignTestPackJoints(TestPackObj testPack)
        {
            //assign joints from Line04

        }

        public void DeleteTestPack(TestPackObj testPack)
        {
            //delete tp
        }
        public void AcceptTestPack(TestPackObj testPack)
        {
            //handle first accept

            //handle second accept

            //handle third accept
        }
        public void RejectTestPack(TestPackObj testPack)
        {
            //handle first reject

            //handle second reject

            //handle third reject
        }

        #endregion
    }
}