using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class _T_requestReports:Hooks
    {
        [Test, TestCaseSource(typeof(MyFactoryClass), "RequestReports")]
        public void NewReqestReport(RequestReportObj request)
        {
            RequestReportPageObjects requestReport = Dash.OpenRequestReports();

            requestReport.NewRequestReport(request);
            System.Threading.Thread.Sleep(1000);
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "RequestReports")]
        public void EditReqestReport(RequestReportObj request)
        {
            RequestReportPageObjects requestReport = Dash.OpenRequestReports();

            requestReport.EditRequestApprovals(request);
            System.Threading.Thread.Sleep(1000);

        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "RequestReports")]
        public void DeleteReqestReport(RequestReportObj request)
        {
            RequestReportPageObjects requestReport = Dash.OpenRequestReports();

            requestReport.Delete(request);
            System.Threading.Thread.Sleep(1000);


        }
    }
}
