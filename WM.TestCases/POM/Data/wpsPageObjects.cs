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
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[3]/td[2]/input[@id='ThickFrom']")]
        public IWebElement thickFrom { get; set; }

        //Thick To 
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[3]/td[3]/input[@id='ThickTo']")]
        public IWebElement thickTo { get; set; }

        //DIA From 
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[3]/td[5]/input[@id='DiamFrom']")]
        public IWebElement diaFrom { get; set; }

        //DIA To 
        [FindsBy(How = How.XPath, Using = "id('MyTable')/tbody[1]/tr[3]/td[6]/input[@id='DiamTo']")]
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


        //WPS Edit btn
        [FindsBy(How = How.XPath, Using = "//*[@id='tblWPS']/tbody/tr[2]/td[10]/div/button[2]")]
        public IWebElement btnEdit { get; set; }

        //WPS Delete btn
        [FindsBy(How = How.XPath, Using = "//*[@id='tblWPS']/tbody/tr[2]/td[10]/div/button[3]")]
        public IWebElement btnDelete { get; set; }

        //WPS Welders btn
        [FindsBy(How = How.XPath, Using = "//*[@id='tblWPS']/tbody/tr[2]/td[10]/div/button[4]")]
        public IWebElement btnWPSWelders { get; set; }

        //WPS Areas btn
        [FindsBy(How = How.XPath, Using = "//*[@id='tblWPS']/tbody/tr[2]/td[10]/div/button[5]")]
        public IWebElement btnWPSAreas { get; set; }

        //WPS DeleteOK btn
        [FindsBy(How = How.XPath, Using = "/html[1]/body[@class='modal-open']/div[@class='bootbox modal fade bootbox-confirm in']/div[@class='modal-dialog']/div[@class='modal-content']/div[@class='modal-footer']/button[@class='btn btn-primary']")]
        public IWebElement btnDeleteOK { get; set; }

        //PWHT
        [FindsBy(How = How.XPath, Using = "//*[@id='PWHT']")]
        public IWebElement chkPWHT { get; set; }

        //WPS Welders -----------------------------
        //WelderID
        [FindsBy(How = How.XPath, Using = "//*[@id='SelectedWelder']")]
        public IWebElement selectWelderID { get; set; }

        //From
        [FindsBy(How = How.XPath, Using = "//*[@id='QualificationDate']")]
        public IWebElement dpFrom { get; set; }

        //To
        [FindsBy(How = How.XPath, Using = "//*[@id='ExpiredDate']")]
        public IWebElement dpTo { get; set; }

        //Add
        [FindsBy(How = How.XPath, Using = "//*[@id='SaveWPSWelder']")]
        public IWebElement btnAddWPSWelder { get; set; }

        //Renew
        [FindsBy(How = How.XPath, Using = "//*[@id='jq_QualifiedWelders']/tbody/tr[2]/td[1]/div/input")]
        public IWebElement btnRenewWPSWelder { get; set; }


        //Delete
        [FindsBy(How = How.XPath, Using = "//*[@id='jq_QualifiedWelders']/tbody/tr[2]/td[1]/div/input")]
        public IWebElement btnDeleteWPSWelder { get; set; }
        
        //--------------------------------------------------------

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

        public void EditWPS(WPSObj WPS)
        {
            btnSearchWPS.Click();
            selectSearchBy.ddlSelectByLabel("WPS No");
            txtSearchValue.SendCheckKeys(WPS.WPSName);
            btnFind.Click();
            System.Threading.Thread.Sleep(2000);

            btnEdit.Click();
            System.Threading.Thread.Sleep(3000);

            chkPWHT.Click();

            txtPQR.SendCheckKeys(WPS.PQR + " - x123");
            System.Threading.Thread.Sleep(1000);


            btnSaveWPS.Click();
            System.Threading.Thread.Sleep(3000);

        }

        public void AddWPStoArea(WPSObj WPS)
        {
            btnSearchWPS.Click();
            selectSearchBy.ddlSelectByLabel("WPS No");
            txtSearchValue.SendCheckKeys(WPS.WPSName);
            btnFind.Click();
            System.Threading.Thread.Sleep(2000);

            btnWPSAreas.Click();
            System.Threading.Thread.Sleep(2000);
            
            //Missing Logic to Search the Grid for Areas


        }

        public void AddWelderToWPS(WelderWPSObj wWPS)
        {
            btnSearchWPS.Click();
            selectSearchBy.ddlSelectByLabel("WPS No");
            txtSearchValue.SendCheckKeys(wWPS.WPS);
            btnFind.Click();
            System.Threading.Thread.Sleep(2000);

            btnWPSWelders.Click();
            System.Threading.Thread.Sleep(3000);

            selectWelderID.ddlSelectByLabel(wWPS.Welder);
            dpFrom.SendCheckKeys(wWPS.From);
            dpTo.SendCheckKeys(wWPS.To);

            btnAddWPSWelder.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void RenewWPSWelder(WelderWPSObj wWPS)
        {
            btnSearchWPS.Click();
            selectSearchBy.ddlSelectByLabel("WPS No");
            txtSearchValue.SendCheckKeys(wWPS.WPS);
            btnFind.Click();
            System.Threading.Thread.Sleep(2000);

            btnWPSWelders.Click();
            System.Threading.Thread.Sleep(2000);

            //Missing Logic to Search the Grid for Areas

            btnRenewWPSWelder.Click();
            System.Threading.Thread.Sleep(2000);
            btnDeleteOK.Click();
        }

        public void DeleteWPSWelder(WelderWPSObj wWPS)
        {
            btnSearchWPS.Click();
            selectSearchBy.ddlSelectByLabel("WPS No");
            txtSearchValue.SendCheckKeys(wWPS.WPS);
            btnFind.Click();
            System.Threading.Thread.Sleep(2000);

            btnWPSWelders.Click();
            System.Threading.Thread.Sleep(2000);

            //Missing Logic to Search the Grid for Areas

            btnDeleteWPSWelder.Click();
            System.Threading.Thread.Sleep(2000);
            btnDeleteOK.Click();
        }
    }
}
