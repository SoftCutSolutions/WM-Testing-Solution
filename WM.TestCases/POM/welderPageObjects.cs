using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    class welderPageObjects
    {
        private IWebDriver _driver;
        public welderPageObjects(IWebDriver driver)
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
        public void New(WelderObj welder)
        {

        }
        public void Edit(WelderObj welder)
        {

        }
        public void Delete(WelderObj welder)
        {

        }
        #endregion

    }
}
