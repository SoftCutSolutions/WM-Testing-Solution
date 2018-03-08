using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    class definitionsPageObjects
    {
        private IWebDriver _driver;
        public definitionsPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "id('tabSets')/div[2]/li[4]")]
        public IWebElement tabPipingClass { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='NEWPipingClass']")]
        public IWebElement btnNewPipingClass { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Value']")]
        public IWebElement txtValue { get; set; }

        //Save
        [FindsBy(How = How.XPath, Using = "id('Save')")]
        public IWebElement btnSave { get; set; }

        //Alert New
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div")]
        public IWebElement alert { get; set; }

        //Alert
        [FindsBy(How = How.XPath, Using = "/html/body/div[9]/div")]
        public IWebElement alertD { get; set; }

        //Search
        [FindsBy(How = How.XPath, Using = "id('search_tblPipingClass_top')/div[@class='ui-pg-div']/span[@class='ui-icon ui-icon-search']")]
        public IWebElement btnsearch { get; set; }

        //Search Value
        [FindsBy(How = How.XPath, Using = "id('jqg1')")]
        public IWebElement txtsearchValue { get; set; }


        //Search button
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblPipingClass_search']")]
        public IWebElement btnFind { get; set; }

        //Delete PipingClass
        [FindsBy(How = How.XPath, Using = "//*[@id='tblPipingClass']/tbody/tr[2]/td[3]/div/button[2]")]
        public IWebElement btnDelete { get; set; }

        //OK
        [FindsBy(How = How.XPath, Using = "/html[1]/body[@class='modal-open']/div[@class='bootbox modal fade bootbox-confirm in']/div[@class='modal-dialog']/div[@class='modal-content']/div[@class='modal-footer']/button[@class='btn btn-primary']")]
        public IWebElement btnOK { get; set; }


        public void NewPipingClass(string pipingClass)
        {
            tabPipingClass.Click();
            btnNewPipingClass.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            txtValue.waitforElement();
            txtValue.SendCheckKeys(pipingClass);

            btnSave.Click();
        }

        public void DeletePipingClass(string pipingClass)
        {
            tabPipingClass.Click();
            btnsearch.Click();
            txtsearchValue.SendCheckKeys(pipingClass);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            btnFind.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            btnDelete.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            btnOK.Click();
        }
    }
}
