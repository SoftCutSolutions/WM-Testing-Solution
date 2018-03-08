using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{

    class wpsPageObjects
    {
        private IWebDriver _driver;
        public wpsPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        //New WPS btn
        [FindsBy(How = How.XPath, Using = "//*[@id='NewWPS']")]
        public IWebElement btnNewWPS { get; set; }

        //WPS Code
        [FindsBy(How = How.XPath, Using = "//*[@id='WPSCode']")]
        public IWebElement selectWPSCode { get; set; }


        //WPS Name
        [FindsBy(How = How.XPath, Using = "//*[@id='WPSName']")]
        public IWebElement txtWPSName { get; set; }

        //PQR 
        [FindsBy(How = How.XPath, Using = "//*[@id='SupportingPQR']")]
        public IWebElement txtPQR { get; set; }

        //Thick From 
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[5]/td[2]/input[@id='ThickFrom']")]
        public IWebElement thickFrom { get; set; }

        //Thick To 
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[5]/td[3]/input[@id='ThickTo']")]
        public IWebElement thickTo { get; set; }

        //DIA From 
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[5]/td[5]/input[@id='DiamFrom']")]
        public IWebElement diaFrom { get; set; }

        //DIA To 
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[5]/td[6]/input[@id='DiamTo']")]
        public IWebElement diaTo { get; set; }

        //Save WPS btn
        [FindsBy(How = How.XPath, Using = "//*[@id='Save']")]
        public IWebElement btnSaveWPS { get; set; }

        //Search WPS btn
        [FindsBy(How = How.XPath, Using = "id('search_tblWPS_top')/div[@class='ui-pg-div']/span[@class='ui-icon ui-icon-search']")]
        public IWebElement btnSearchWPS { get; set; }

        //WPS Search Criteria
        [FindsBy(How = How.XPath, Using = "id('fbox_tblWPS')/table[@class='group ui-widget ui-widget-content']/tbody[1]/tr[3]/td[@class='columns']/select[1]")]
        public IWebElement selectSearchBy { get; set; }

        //WPS Search value
        [FindsBy(How = How.XPath, Using = "//*[@id='jqg2']")]
        public IWebElement txtSearchValue { get; set; }

        //WPS find btn
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblWPS_search']")]
        public IWebElement btnFind { get; set; }

        //WPS Delete btn
        [FindsBy(How = How.XPath, Using = "//*[@id='tblWPS']/tbody/tr[2]/td[10]/div/button[3]")]
        public IWebElement btnDelete { get; set; }

        //WPS DeleteOK btn
        [FindsBy(How = How.XPath, Using = "/html[1]/body[@class='modal-open']/div[@class='bootbox modal fade bootbox-confirm in']/div[@class='modal-dialog']/div[@class='modal-content']/div[@class='modal-footer']/button[@class='btn btn-primary']")]
        public IWebElement btnDeleteOK { get; set; }

        public void NewWPS(WPSObj WPS)
        {
            btnNewWPS.Click();
            System.Threading.Thread.Sleep(1000);

            selectWPSCode.ddlSelectByLabel(WPS.WPSCode);
            txtWPSName.SendCheckKeys(WPS.WPSName);
            txtPQR.SendCheckKeys(WPS.PQR);

            thickFrom.SendCheckKeys(WPS.ThickFrom);
            thickTo.SendCheckKeys(WPS.ThickTo);

            diaFrom.SendCheckKeys(WPS.DIAFrom);
            diaTo.SendCheckKeys(WPS.DIATo);

            btnSaveWPS.Click();

        }
        public void DeleteWPS(WPSObj wps)
        {
            btnSearchWPS.Click();
            selectSearchBy.ddlSelectByLabel("WPS No");
            txtSearchValue.SendCheckKeys(wps.WPSName);
            btnFind.Click();
            System.Threading.Thread.Sleep(2000);
            btnDelete.Click();
            System.Threading.Thread.Sleep(1000);
            btnDeleteOK.Click();
        }
    }
}
