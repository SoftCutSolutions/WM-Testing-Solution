using System;
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

        // New Materials
        [FindsBy(How = How.XPath, Using = "//*[@id='addNewMaterial']")]
        public IWebElement btnNewMaterials { get; set; }


        // Material Name
        [FindsBy(How = How.XPath, Using = "//*[@id='Name']")]
        public IWebElement txtMaterialName { get; set; }

        // Delivery Con
        [FindsBy(How = How.XPath, Using = "//*[@id='DeliveryCondition']")]
        public IWebElement txtDeliveryCon { get; set; }

        // Standard
        [FindsBy(How = How.XPath, Using = "//*[@id='Standard']")]
        public IWebElement txtStandard { get; set; }

        // Grade
        [FindsBy(How = How.XPath, Using = "//*[@id='Grade']")]
        public IWebElement txtGrade { get; set; }

        // Group 1
        [FindsBy(How = How.XPath, Using = "//*[@id='GroupEN288']")]
        public IWebElement txtGroup1 { get; set; }

        // Group 2
        [FindsBy(How = How.XPath, Using = "//*[@id='GroupEN287']")]
        public IWebElement txtGroup2 { get; set; }

        // Group 3
        [FindsBy(How = How.XPath, Using = "//*[@id='GroupISO15608']")]
        public IWebElement txtGroup3 { get; set; }

        //Code
        [FindsBy(How = How.XPath, Using = "//*[@id='Code']")]
        public IWebElement txtCode { get; set; }

        // Supplier 
        [FindsBy(How = How.XPath, Using = "//*[@id='Supplier']")]
        public IWebElement txtSupplier { get; set; }

        //Type
        [FindsBy(How = How.XPath, Using = "//*[@id='Type']")]
        public IWebElement txtType { get; set; }

        // Thinkess
        [FindsBy(How = How.XPath, Using = "//*[@id='Thickness']")]
        public IWebElement txtThikness { get; set; }

        // ASMEGNo
        [FindsBy(How = How.XPath, Using = "//*[@id='ASMEgNo']")]
        public IWebElement txtASMEGNo { get; set; }

        //ASMEPNo
        [FindsBy(How = How.XPath, Using = "//*[@id='ASMEpNo']")]
        public IWebElement txtASMEPNo { get; set; }

        //Active Checkbox
        [FindsBy(How = How.XPath, Using = "//*[@id='Active']")]
        public IWebElement chkbxActive { get; set; }

        // Special NDE req
        [FindsBy(How = How.XPath, Using = "//*[@id='SpecialNDEREQs']")]
        public IWebElement chkbxSpecialNDEReq { get; set; }

        //save
        [FindsBy(How = How.XPath, Using = "//*[@id='SaveMaterial']")]
        public IWebElement btnSave { get; set; }

        // Finad Material

        //Find Record
        [FindsBy(How = How.XPath, Using = "//*[@id='search_tblMaterialList_top']/div/span")]
        public IWebElement btnFindrecord { get; set; }

        //Text box
        [FindsBy(How = How.XPath, Using = "//*[@id='jqg1']")]
        public IWebElement txtbox { get; set; }

        // Find 
        [FindsBy(How = How.XPath, Using = "//*[@id='fbox_tblMaterialList_search']")]
        public IWebElement btnFind { get; set; }

        //Edit
        [FindsBy(How = How.XPath, Using = "//*[@id='tblMaterialList']/tbody/tr[2]/td[11]/div/button[1]")]
        public IWebElement btnEdit { get; set; }

        //Delete 
        [FindsBy(How = How.XPath, Using = "//*[@id='tblMaterialList']/tbody/tr[2]/td[11]/div/button[2]")]
        public IWebElement btnDelete { get; set; }

        //ok
        [FindsBy(How = How.XPath, Using = "//button[2][@type='button']")]
        public IWebElement btnOk { get; set; }


        //*[@id='SpecialNDEREQs']

        #endregion

        #region Methods
        public void New(materialObj mat)
        {
            btnNewMaterials.Click();
            System.Threading.Thread.Sleep(5000);

            txtMaterialName.SendCheckKeys(mat.MaterialName);
            txtDeliveryCon.SendCheckKeys(mat.DeliveryCon);
            txtStandard.SendCheckKeys(mat.Standard);
            txtGrade.SendCheckKeys(mat.Grade);
            //txtGroup1.SendCheckKeys(mat.Group1);
            //txtGroup2.SendCheckKeys(mat.Group2);
            //txtGroup3.SendCheckKeys(mat.Group3);
            //txtCode.SendCheckKeys(mat.Code);
            //System.Threading.Thread.Sleep(1000);

            //txtSupplier.SendCheckKeys(mat.Supplier);
            //txtType.SendCheckKeys(mat.Type);
            //txtThikness.SendCheckKeys(mat.Thinkess);
            //txtASMEGNo.SendCheckKeys(mat.ASMEGNo);
            //txtASMEPNo.SendCheckKeys(mat.ASMEPNo);
            //chkbxActive.Click();
            System.Threading.Thread.Sleep(2000);

            btnSave.Click();
            System.Threading.Thread.Sleep(5000);
        }

        public void Edit(materialObj mat)
        {
            //Find Material

            btnFindrecord.Click();
            System.Threading.Thread.Sleep(5000);

            txtbox.SendCheckKeys(mat.MaterialName);
            System.Threading.Thread.Sleep(1000);

            btnFind.Click();
            System.Threading.Thread.Sleep(3000);

            btnEdit.Click();
            System.Threading.Thread.Sleep(3000);

            txtGroup1.SendCheckKeys(mat.Group1);
            txtGroup2.SendCheckKeys(mat.Group2);
            txtGroup3.SendCheckKeys(mat.Group3);
            txtCode.SendCheckKeys(mat.Code);
            System.Threading.Thread.Sleep(1000);

            txtSupplier.SendCheckKeys(mat.Supplier);
            txtThikness.SendCheckKeys(mat.Thinkess);
            txtType.SendCheckKeys(mat.Type);
            txtASMEGNo.SendCheckKeys(mat.ASMEGNo);
            txtASMEPNo.SendCheckKeys(mat.ASMEPNo);

            chkbxSpecialNDEReq.Click();
            System.Threading.Thread.Sleep(1000);

            btnSave.Click();
            System.Threading.Thread.Sleep(5000);

        }
        public void Delete(materialObj mat)
        {
            //Find Material

            btnFindrecord.Click();
            System.Threading.Thread.Sleep(5000);

            txtbox.SendCheckKeys(mat.MaterialName);
            System.Threading.Thread.Sleep(1000);

            btnFind.Click();
            System.Threading.Thread.Sleep(3000);

            btnDelete.Click();
            System.Threading.Thread.Sleep(3000);

            btnOk.Click();
            System.Threading.Thread.Sleep(5000);
        }
        #endregion
    }
}