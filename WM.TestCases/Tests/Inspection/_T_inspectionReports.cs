using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WM.TestCases
{
    [TestFixture]
    [Parallelizable]
    class _T_inspectionReports:Hooks
    {   
        [Test]
        public void NewInspectionReport()
        {
            inspectionReportPageObjects inspectionReport = Dash.OpenInspectionReports();

            inspectionReport.NewInspectionReport(testValues._g_InspectionReport);
            System.Threading.Thread.Sleep(3000);
        }

        [Test]
        public void AcceptRejectInspectionReport()
        {
            inspectionReportPageObjects inspectionReport = Dash.OpenInspectionReports();

            inspectionReport.AcceptRejectInspectionReport(testValues._g_InspectionReport);
            System.Threading.Thread.Sleep(3000);

        }

        [Test]
        public void EditInspectionReport()
        {
            inspectionReportPageObjects inspectionReport = Dash.OpenInspectionReports();

            inspectionReport.EditInspectionReport(testValues._g_InspectionReport);
            System.Threading.Thread.Sleep(3000);

        }

        [Test]
        public void DeleteInspectionReport()
        {
            inspectionReportPageObjects inspectionReport = Dash.OpenInspectionReports();

            inspectionReport.DeleteInspectionReport(testValues._g_InspectionReport);
            System.Threading.Thread.Sleep(3000);

        }
    }
}
