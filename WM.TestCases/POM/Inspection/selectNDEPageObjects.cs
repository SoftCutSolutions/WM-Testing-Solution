using System;
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

        //Line/Tank Details
        [FindsBy(How = How.XPath, Using = "//*[@id='tabs-9']/ul/li[2]")]
        public IWebElement btnLineTankDetails { get; set; }

        // Line No
        [FindsBy(How = How.XPath, Using = "//*[@id='Line']")]
        public IWebElement txtLineNo { get; set; }

        //select joint
        [FindsBy(How = How.XPath, Using = "//*[@id='tblJoints']/tbody/tr[2]")]
        public IWebElement selectJoint { get; set; }

        //Select/Deselect All
        [FindsBy(How = How.XPath, Using = "//*[@id='SelectAll']")]
        public IWebElement chbxSelectDelectAll { get; set; }

        //save
        [FindsBy(How = How.XPath, Using = "//*[@id='Save']")]
        public IWebElement btnSave { get; set; }

        //Pipe Class Details
        [FindsBy(How = How.XPath, Using = "//*[@id='tabs-9']/ul/li[4]")]
        public IWebElement TabPipeClassDetails { get; set; }

        //Pipe Class Details
        [FindsBy(How = How.XPath, Using = "//*[@id='PipeClass']")]
        public IWebElement txtPipeClass { get; set; }

        //AHM
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_0__Checked']")]
        public IWebElement AHM { get; set; }

        //DT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_1__Checked']")]
        public IWebElement DT { get; set; }

        //FT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_2__Checked']")]
        public IWebElement FT { get; set; }

        //HT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_3__Checked']")]
        public IWebElement HT { get; set; }

        //MT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_4__Checked']")]
        public IWebElement MT { get; set; }

        //PMI
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_5__Checked']")]
        public IWebElement PMI { get; set; }

        //PT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_6__Checked']")]
        public IWebElement PT { get; set; }

        //PWHT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_7__Checked']")]
        public IWebElement PWHT { get; set; }

        //RT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_8__Checked']")]
        public IWebElement RT { get; set; }

        //UT
        [FindsBy(How = How.XPath, Using = "//*[@id='lstReadyNDEReport_9__Checked']")]
        public IWebElement UT { get; set; }

        //Text AHM
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[1]/td[2]/input")]
        public IWebElement TextAHM { get; set; }

        //Text DT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[2]/td[2]/input")]
        public IWebElement TextDT { get; set; }

        //Text FT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[3]/td[2]/input")]
        public IWebElement TextFT { get; set; }


        //Text HT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[4]/td[2]/input")]
        public IWebElement TextHT { get; set; }


        //Text MT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[5]/td[2]/input")]
        public IWebElement TextMT { get; set; }


        //Text PMI
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[6]/td[2]/input")]
        public IWebElement TextPMI { get; set; }


        //Text PT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[7]/td[2]/input")]
        public IWebElement TextPT { get; set; }

        //Text PWHT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[8]/td[2]/input")]
        public IWebElement TextPWHT { get; set; }

        //Text RT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[9]/td[2]/input")]
        public IWebElement TextRT { get; set; }

        //Text UT
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipeClassReportTypePerc']/tbody/tr[10]/td[2]/input")]
        public IWebElement TextUT { get; set; }

        #endregion


        #region Methods
        public void EditLineReportPercentage(SelectNDEObj SelectNDE)
        {
        }

        public void EditPipingClassReportPercentage(SelectNDEObj g_sNDEObj)
        {
        }

        public void ValidatePercentage(SelectNDEObj g_sNDEObj)
        {
        }

        public void EditLineJointTypePercentage(SelectNDEObj g_sNDEObj)
        {
        }
        #endregion
    }
}