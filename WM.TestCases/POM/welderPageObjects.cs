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
        //New Welder Btn
        [FindsBy(How = How.XPath, Using = "//*[@id='NEWWelder']")]
        public IWebElement btnNewWelder { get; set; }

        //Welder ID No
        [FindsBy(How = How.XPath, Using = "//*[@id='IDNO']")]
        public IWebElement txtWelderIDNO { get; set; }

        //Welder Name
        [FindsBy(How = How.XPath, Using = "//*[@id='WelderName']")]
        public IWebElement txtWelderName { get; set; }

        //Location
        [FindsBy(How = How.XPath, Using = "//*[@id='Location']")]
        public IWebElement selectLocation { get; set; }

        //Contractor Name
        [FindsBy(How = How.XPath, Using = "//*[@id='Contractor']")]
        public IWebElement selectContractor { get; set; }

        //Serial No
        [FindsBy(How = How.XPath, Using = "//*[@id='JCCNO']")]
        public IWebElement txtSerialNo { get; set; }

        //Position
        [FindsBy(How = How.XPath, Using = "//*[@id='Position']")]
        public IWebElement txtPosition { get; set; }

        //Process Grid------------------------------------------------------------------------------------------
        //ThickFrom
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[2]/input[@id='ThickFrom']")]
        public IWebElement txtThickFrom { get; set; }

        //ThickTo
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[3]/input[@id='ThickTo']")]
        public IWebElement txtThickTo { get; set; }

        //Thickunli
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[4]/input[@id='WelderProcess_0__Unlimited_Value']")]
        public IWebElement chkThickunli { get; set; }

        //DiamFrom
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[5]/input[@id='DiamFrom']")]
        public IWebElement txtDiamFrom { get; set; }

        //DiamTo
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[6]/input[@id='DiamTo']")]
        public IWebElement txtDiamTo { get; set; }

        //Diam Unlimi
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[7]/input[@id='WelderProcess_0__UnlimitedDiam_Value']")]
        public IWebElement chkDIAMUnli { get; set; }

        //Material
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[8]/input[@id='Material']")]
        public IWebElement txtMaterial { get; set; }

        //Position Process
        [FindsBy(How = How.XPath, Using = "//*[@id='MyTable']/tbody/tr[2]/td[9]/input[@id='Position']")]
        public IWebElement txtprocessProcess { get; set; }


        //Change Picture
        [FindsBy(How = How.XPath, Using = "//*[@id='changepic']")]
        public IWebElement changePicture { get; set; }

        //Save Welder
        [FindsBy(How = How.XPath, Using = "//*[@id='Save']")]
        public IWebElement btnSave { get; set; }
        //----------------------------------------------------------------------------------------------

        //Welder Grid Filter ---------------------------------------------------------------------------
        //Edit Welder
        [FindsBy(How = How.XPath, Using = "//*[@id='tblWelders']/tbody/tr[2]/td[12]/div/button[2]")]
        public IWebElement btnEditWelder { get; set; }

        //Delete Welder
        [FindsBy(How = How.XPath, Using = "//*[@id='tblWelders']/tbody/tr[2]/td[12]/div/button[3]")]
        public IWebElement btnDeleteWelder { get; set; }

        //Search Welder
        [FindsBy(How = How.XPath, Using = "//*[@id='search_tblWelders_top']/div/span")]
        public IWebElement btnSearch { get; set; }

        //Find Welder
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblWelders_search']")]
        public IWebElement btnFind { get; set; }

        //Search Criteria
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblWelders']/table/tbody/tr[3]/td[2]/select")]
        public IWebElement selectSearchCriteria { get; set; }

        //Search Value
        [FindsBy(How = How.XPath, Using = "//*[@id='jqg1']")]
        public IWebElement txtSearchValue { get; set; }

        //Delete Welder OK
        [FindsBy(How = How.XPath, Using = "/html[1]/body[@class='modal-open']/div[@class='bootbox modal fade bootbox-confirm in']/div[@class='modal-dialog']/div[@class='modal-content']/div[@class='modal-footer']/button[@class='btn btn-primary']")]
        public IWebElement btnDeleteOK { get; set; }

        //----------------------------------------------------------------------------------------------

        #endregion

        #region Methods
        public void NewWelder(WelderObj welder, welderProcess wldprocess)
        {
            btnNewWelder.Click();
            System.Threading.Thread.Sleep(2000);

            txtWelderIDNO.SendCheckKeys(welder.WelderIDNO);
            txtWelderName.SendCheckKeys(welder.WelderName);

            selectContractor.ddlSelectByLabel(welder.contractor);

            txtDiamFrom.SendCheckKeys(wldprocess.DIAMFrom);
            txtDiamTo.SendCheckKeys(wldprocess.DIAMTo);

            txtThickFrom.SendCheckKeys(wldprocess.THICKFrom);
            txtThickTo.SendCheckKeys(wldprocess.THICKTo);
            txtMaterial.SendCheckKeys(wldprocess.Material);
            txtprocessProcess.SendCheckKeys(wldprocess.Position);

            btnSave.Click();

            //Assert
        }
        public void EditWelder(WelderObj welder)
        {
            btnSearch.Click();
            selectSearchCriteria.ddlSelectByLabel("Welder No");
            txtSearchValue.SendCheckKeys(welder.WelderIDNO);
            System.Threading.Thread.Sleep(1000);
            btnFind.Click();

            System.Threading.Thread.Sleep(2000);


            btnEditWelder.Click();
            System.Threading.Thread.Sleep(2000);

            selectLocation.ddlSelectByValue(welder.location);
            txtSerialNo.SendCheckKeys(welder.SerialNo);
            txtPosition.SendCheckKeys(welder.WelderPosition);

            btnSave.Click();
        }
        public void DeleteWelder(WelderObj welder)
        {
            btnSearch.Click();
            selectSearchCriteria.ddlSelectByLabel("Welder No");
            txtSearchValue.SendCheckKeys(welder.WelderIDNO);
            System.Threading.Thread.Sleep(1000);
            btnFind.Click();

            System.Threading.Thread.Sleep(2000);

            btnDeleteWelder.Click();
            System.Threading.Thread.Sleep(3000);

            btnDeleteOK.waitforElement();
            btnDeleteOK.Click();
        }
        #endregion

    }
}
