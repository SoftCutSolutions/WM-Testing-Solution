using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WM.TestCases
{
    public class RequestReportObj
    {
        public string reportType { get; set; }
        public string reportDate { get; set; }
        public string reportNumber { get; set; }
        public string Approver1 { get; set; }
        public string Approver2 { get; set; }
        public string Approver3 { get; set; }
        public string Approver4 { get; set; }

    }
}