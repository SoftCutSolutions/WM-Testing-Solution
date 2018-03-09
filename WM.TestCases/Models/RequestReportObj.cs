using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    public class RequestReportObj
    {
        public string reportType { get; set; }
        public string reportNumber { get; set; }
        public string reportDate { get; set; }
    }
}