using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{

    class linePageObjects
    {
        private IWebDriver _driver;
        public linePageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        //New Line
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[@class='container']/div[@class='container']/input[@class='btn btn-primary btn-xs clsAddLine']")]
        public IWebElement btnNewLine { get; set; }

        //Select Area
        [FindsBy(How = How.XPath, Using = "//*[@id='AreaID']")]
        public IWebElement selectArea { get; set; }

        //Line Number
        [FindsBy(How = How.XPath, Using = "//*[@id='LineNum']")]
        public IWebElement txtLineNo { get; set; }

        //Main Size
        [FindsBy(How = How.XPath, Using = "//*[@id='MainSize']")]
        public IWebElement txtMainSize { get; set; }

        //Piping Class
        [FindsBy(How = How.XPath, Using = "//*[@id='PipeClass']")]
        public IWebElement selectPipingClass { get; set; }

        //Service
        [FindsBy(How = How.XPath, Using = "//*[@id='Service']")]
        public IWebElement selectService { get; set; }

        //Revision
        [FindsBy(How = How.XPath, Using = "//*[@id='Revision']")]
        public IWebElement txtRevision { get; set; }

        //Drawing No txt
        [FindsBy(How = How.XPath, Using = "//*[@id='DrawingNo']")]
        public IWebElement txtDrawingNo { get; set; }

        //Drawing No Add
        [FindsBy(How = How.XPath, Using = "//*[@id='AddNewDrawingNO']")]
        public IWebElement btnAddDrawingNo { get; set; }

        //New Sheet btn
        [FindsBy(How = How.XPath, Using = "//*[@id='tblDrawingNOs']/tbody/tr[2]/td[5]/div/button[2]")]
        public IWebElement btnNewSheetRow1 { get; set; }

        //Sheet No txt
        [FindsBy(How = How.XPath, Using = "//*[@id='SheetNO']")]
        public IWebElement txtSheetNo { get; set; }


        //Save Sheet Btn
        [FindsBy(How = How.XPath, Using = "//*[@id='SaveSheet']")]
        public IWebElement btnSaveSheet { get; set; }

        //Save Line Btn
        [FindsBy(How = How.XPath, Using = "//*[@id='SaveLine']")]
        public IWebElement btnSaveLine { get; set; }

        //Area Filter
        [FindsBy(How = How.XPath, Using = "//*[@id='gs_AreaCode']")]
        public IWebElement txtAreaFilter { get; set; }

        //Line Filter
        [FindsBy(How = How.XPath, Using = "//*[@id='gs_LineNum']")]
        public IWebElement txtLineFilter { get; set; }

        //Line Delete Btn
        [FindsBy(How = How.XPath, Using = "//*[@id='tblLines']/tbody/tr[2]/td[12]/div/button[2]")]
        public IWebElement btnDeleteLine { get; set; }

        //Confirm Delete Btn
        [FindsBy(How = How.XPath, Using = "/html[1]/body[@class='modal-open']/div[@class='bootbox modal fade bootbox-confirm in']/div[@class='modal-dialog']/div[@class='modal-content']/div[@class='modal-footer']/button[@class='btn btn-primary']")]
        public IWebElement btnOkDelete { get; set; }

        public void NewLine(lineObj line)
        {
            btnNewLine.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            selectArea.Click();
            selectArea.ddlSelectByLabel(line.AreaCode);
            txtLineNo.SendCheckKeys(line.LineNo);
            txtMainSize.SendCheckKeys(line.MainSize);
            selectPipingClass.ddlSelectByValue(line.PipingClass);
            selectService.ddlSelectByValue(line.Service);
            txtRevision.SendCheckKeys(line.revision);
            txtDrawingNo.SendCheckKeys(line.DrawingNo1);
            btnAddDrawingNo.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            btnNewSheetRow1.waitforElement();
            btnNewSheetRow1.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            txtSheetNo.waitforElement();
            txtSheetNo.SendCheckKeys(line.SheetNo1);
            btnSaveSheet.Click();

            System.Threading.Thread.Sleep(3000);

            btnSaveLine.Click();
        }

        public void DeleteLine(lineObj line)
        {
            txtAreaFilter.SendCheckKeys(line.AreaCode);
            txtLineFilter.SendCheckKeys(line.LineNo);

            System.Threading.Thread.Sleep(1000);

            btnDeleteLine.Click();

            System.Threading.Thread.Sleep(1000);

            btnOkDelete.Click();
        }
    }
}
