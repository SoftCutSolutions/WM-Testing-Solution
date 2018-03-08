using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    class dashboardPageObjects
    {
        private IWebDriver _driver;
        public dashboardPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How= How.XPath, Using = "//*[@id='JointsHeader']")]
        public IWebElement pnlJointsStats { get; set; }


        //Data
        [FindsBy(How = How.XPath, Using = "//li[@id='li_Data']")]
        public IWebElement mnuData { get; set; }

        //Areas
        [FindsBy(How = How.LinkText, Using = "Areas")]
        public IWebElement mnuAreas { get; set; }

        //Lines
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Data']/ul/li[2]/a")]
        public IWebElement mnuLines { get; set; }

        //Welder
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Data']/ul/li[3]/a")]
        public IWebElement mnuWelder { get; set; }

        //WPS
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Data']/ul/li[5]/a")]
        public IWebElement mnuWPS { get; set; }

        //Materials
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Data']/ul/li[6]/a")]
        public IWebElement mnuMaterials { get; set; }

        //Import/Export
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Data']/ul/li[8]/a")]
        public IWebElement mnuImpExp { get; set; }

        //Joints
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Data']/ul/li[10]/a")]
        public IWebElement mnuJoints { get; set; }

        //Weld Joint
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Data']/ul/li[11]/a")]
        public IWebElement mnuWeldJoint { get; set; }

        //Inspection
        [FindsBy(How = How.XPath, Using = "//*[@id='InspectionRpt']/a")]
        public IWebElement mnuInspection { get; set; }

        //Inspection Reports
        [FindsBy(How = How.XPath, Using = "//*[@id='InspectionRpt']/ul/li[1]/a")]
        public IWebElement mnuInspectionReport { get; set; }

        //SelectNDE
        [FindsBy(How = How.XPath, Using = "//*[@id='InspectionRpt']/ul/li[2]/a")]
        public IWebElement mnuSelectNDE { get; set; }

        //Request Report
        [FindsBy(How = How.XPath, Using = "//*[@id='InspectionRpt']/ul/li[4]/a")]
        public IWebElement mnuRequestReport { get; set; }

        //Administration
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Administration']")]
        public IWebElement mnuAdministration { get; set; }

        //System Definitions 
        [FindsBy(How = How.XPath, Using = "//*[@id='li_Administration']/ul/li[1]/a")]
        public IWebElement mnuSystemDefinitions { get; set; }



        public definitionsPageObjects openDefinitions()
        {
            mnuAdministration.Click();
            mnuSystemDefinitions.Click();
            return new definitionsPageObjects(_driver);
        }


        public areasPageObjects openAreas()
        {
            mnuData.Click();
            mnuAreas.Click();

            return new areasPageObjects(_driver);
        }

        public linePageObjects openLines()
        {
            mnuData.Click();
            mnuLines.Click();
            return new linePageObjects(_driver);
        }

        public wpsPageObjects openWPS()
        {
            mnuData.Click();
            mnuWPS.Click();
            return new wpsPageObjects(_driver);
        }
        public jointsPageObjects openJoints()
        {
            mnuData.Click();
            mnuJoints.Click();
            return new jointsPageObjects(_driver);
        }
        public welderPageObjects OpenWelder()
        {
            mnuData.Click();
            mnuWelder.Click();
            return new welderPageObjects(_driver);
        }
        public materialsPageObjects OpenMaterials()
        {
            mnuData.Click();
            mnuMaterials.Click();
            return new materialsPageObjects(_driver);
        }
        public impexpPageObjects OpenImpExp()
        {
            mnuData.Click();
            mnuImpExp.Click();
            return new impexpPageObjects(_driver);
        }
        public WeldJointPageObjects OpenWeldJoint()
        {
            mnuData.Click();
            mnuWeldJoint.Click();
            return new WeldJointPageObjects(_driver);
        }
        public inspectionReportPageObjects OpenInspectionReports()
        {
            mnuInspection.Click();
            mnuInspectionReport.Click();
            return new inspectionReportPageObjects(_driver);
        }
        public selectNDEPageObjects OpenSelectNDE()
        {
            mnuInspection.Click();
            mnuSelectNDE.Click();
            return new selectNDEPageObjects(_driver);
        }
        public RequestReportPageObjects OpenRequestReports()
        {
            mnuInspection.Click();
            mnuWeldJoint.Click();
            return new RequestReportPageObjects(_driver);
        }
    }
}
