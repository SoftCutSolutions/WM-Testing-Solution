using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    class areasPageObjects
    {
        private IWebDriver _driver;
        public areasPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        //New Area
        [FindsBy(How = How.Id, Using = "NEWArea")]
        public IWebElement btnNewArea { get; set; }

        //Area Code
        [FindsBy(How = How.XPath, Using = "//*[@id='AreaCode']")]
        public IWebElement txtAreaCode { get; set; }

        //Save Area
        [FindsBy(How = How.Id, Using = "btn_SaveArea")]
        public IWebElement btnSave { get; set; }

        //Search
        [FindsBy(How = How.XPath, Using = "id('search_tblAreas_top')/div[@class='ui-pg-div']/span[@class='ui-icon ui-icon-search']")]
        public IWebElement btnSearch { get; set; }


        //Search Value
        [FindsBy(How = How.XPath, Using = "id('jqg1')")]
        public IWebElement txtsearchValue { get; set; }


        //Search button
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblAreas_search']")]
        public IWebElement btnFind { get; set; }


        //Delete Area
        [FindsBy(How = How.XPath, Using = "//*[@id='tblAreas']/tbody/tr[2]/td[7]/div/button[2]")]
        public IWebElement btnDelete { get; set; }

        //OK
        [FindsBy(How = How.XPath, Using = "/html[1]/body[@class='modal-open']/div[@class='bootbox modal fade bootbox-confirm in']/div[@class='modal-dialog']/div[@class='modal-content']/div[@class='modal-footer']/button[@class='btn btn-primary']")]
        public IWebElement btnOK { get; set; }

        //Alert D
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div")]
        public IWebElement alertD { get; set; }

        //Alert N
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div")]
        public IWebElement alertN { get; set; }



        public void newArea(string AreaCode)
        {
            btnNewArea.Click();
            // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            txtAreaCode.waitforElement();

            txtAreaCode.SendCheckKeys(AreaCode);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            btnSave.Click();
        }

        public void deleteArea(string AreaCode)
        {
            btnSearch.Click();
            txtsearchValue.SendCheckKeys(AreaCode);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            btnFind.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnDelete.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            btnOK.Click();
        }
    }
}
