using NUnit.Framework;
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

        //Area Description
        [FindsBy(How = How.XPath, Using = "//*[@id='Description']")]
        public IWebElement txtAreaDesc { get; set; }

        //Area QR Code
        [FindsBy(How = How.XPath, Using = "//*[@id='QRnumber']")]
        public IWebElement txtAreaQR { get; set; }

        //Area Location/ CLuster
        [FindsBy(How = How.XPath, Using = "//*[@id='Location']")]
        public IWebElement selectAreaLocation { get; set; }

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


        //Edit Area
        [FindsBy(How = How.XPath, Using = "//*[@id='tblAreas']/tbody/tr[2]/td[7]/div/button[1]")]
        public IWebElement btnEdit { get; set; }

        //Delete Area
        [FindsBy(How = How.XPath, Using = "//*[@id='tblAreas']/tbody/tr[2]/td[7]/div/button[2]")]
        public IWebElement btnDelete { get; set; }

        //Add Sub Area
        [FindsBy(How = How.XPath, Using = "//*[@id='tblAreas']/tbody/tr[2]/td[7]/div/button[7]")]
        public IWebElement btnAddSubArea { get; set; }

        //OK
        [FindsBy(How = How.XPath, Using = "/html[1]/body[@class='modal-open']/div[@class='bootbox modal fade bootbox-confirm in']/div[@class='modal-dialog']/div[@class='modal-content']/div[@class='modal-footer']/button[@class='btn btn-primary']")]
        public IWebElement btnOK { get; set; }

        //Alert D
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div")]
        public IWebElement alertD { get; set; }

        //Alert N
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div")]
        public IWebElement alertN { get; set; }


        //SubAreaName
        [FindsBy(How = How.XPath, Using = "//*[@id='Value']")]
        public IWebElement txtSubAreaName { get; set; }


        //Save SubArea
        [FindsBy(How = How.XPath, Using = "//*[@id='SaveSubArea']")]
        public IWebElement btnSaveSubArea { get; set; }

        //Save++ SubArea
        [FindsBy(How = How.XPath, Using = "//*[@id='SaveNewSubArea']")]
        public IWebElement btnSaveSubAreaPP { get; set; }

        //SubArea first li in grid
        [FindsBy(How = How.XPath, Using = "//*[@id='tblAreas']/tbody/tr[2]/td[5]/div/a[1]")]
        public IWebElement liSubArea { get; set; }

        //SubArea Edit Button
        [FindsBy(How = How.XPath, Using = "/html/body/ul/li[1]/a")]
        public IWebElement cmEditSubArea { get; set; }

        //SubArea Delete Button
        [FindsBy(How = How.XPath, Using = "/html/body/ul/li[2]/a")]
        public IWebElement cmDeleteSubArea { get; set; }

        //SubArea Delete OK Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div/div/div[2]/button[2]")]
        public IWebElement btnDeleteSubAreaOK { get; set; }


        public void newArea(areaObj area)
        {
            btnNewArea.Click();
            System.Threading.Thread.Sleep(5000);

            txtAreaCode.SendCheckKeys(area.AreaCode);
            System.Threading.Thread.Sleep(2000);

            btnSave.Click();
            System.Threading.Thread.Sleep(2000);

        }

        public void deleteArea(areaObj area)
        {
            btnSearch.Click();
            System.Threading.Thread.Sleep(1000);
            txtsearchValue.SendCheckKeys(area.AreaCode);

            System.Threading.Thread.Sleep(1000);
            btnFind.Click();

            System.Threading.Thread.Sleep(3000);
            btnDelete.Click();

            System.Threading.Thread.Sleep(2000);
            btnOK.Click();
        }

        public void EditArea(areaObj area)
        {
            btnSearch.Click();
            System.Threading.Thread.Sleep(1000);
            txtsearchValue.SendCheckKeys(area.AreaCode);

            System.Threading.Thread.Sleep(1000);
            btnFind.Click();

            System.Threading.Thread.Sleep(2000);
            btnEdit.Click();
            System.Threading.Thread.Sleep(2000);

            txtAreaDesc.SendCheckKeys(area.Description);
            txtAreaQR.SendCheckKeys(area.QRNumber);
            selectAreaLocation.ddlSelectByLabel(area.Location);

            btnSave.Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void AddSubArea(areaObj area)
        {
            btnSearch.Click();
            System.Threading.Thread.Sleep(1000);
            txtsearchValue.SendCheckKeys(area.AreaCode);

            System.Threading.Thread.Sleep(1000);
            btnFind.Click();

            System.Threading.Thread.Sleep(2000);
            btnAddSubArea.Click();
            System.Threading.Thread.Sleep(4000);

            txtSubAreaName.SendCheckKeys(area.SubArea1);
            btnSaveSubAreaPP.Click();
            System.Threading.Thread.Sleep(1000);

            txtSubAreaName.SendCheckKeys(area.SubArea1);
            btnSaveSubAreaPP.Click();
            System.Threading.Thread.Sleep(1000);
//check if message no duplicate allowed shows?
            txtSubAreaName.SendCheckKeys(area.SubArea2);
            btnSaveSubArea.Click();

            System.Threading.Thread.Sleep(2000);
        }

        public void EditSubArea(areaObj area)
        {
            btnSearch.Click();
            System.Threading.Thread.Sleep(1000);
            txtsearchValue.SendCheckKeys(area.AreaCode);

            System.Threading.Thread.Sleep(1000);
            btnFind.Click();

            System.Threading.Thread.Sleep(2000);

            liSubArea.Click();
            System.Threading.Thread.Sleep(1000);

            cmEditSubArea.Click();
            System.Threading.Thread.Sleep(1000);

            txtSubAreaName.SendCheckKeys(area.SubArea1 + "-x");
            System.Threading.Thread.Sleep(1000);

            btnSaveSubArea.Click();
        }


        internal void DeleteSubArea(areaObj area)
        {
            btnSearch.Click();
            System.Threading.Thread.Sleep(1000);
            txtsearchValue.SendCheckKeys(area.AreaCode);

            System.Threading.Thread.Sleep(1000);
            btnFind.Click();

            System.Threading.Thread.Sleep(2000);

            liSubArea.Click();
            System.Threading.Thread.Sleep(1000);

            cmDeleteSubArea.Click();
            System.Threading.Thread.Sleep(1000);

            btnDeleteSubAreaOK.Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
