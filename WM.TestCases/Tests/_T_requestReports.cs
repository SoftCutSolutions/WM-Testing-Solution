﻿using NUnit.Framework;
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
        [Test]
        public void NewReqestReport()
        {
            RequestReportPageObjects requestReport = Dash.OpenRequestReports();

            requestReport.New(testValues._g_RequestReport);
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void EditReqestReport()
        {
            RequestReportPageObjects requestReport = Dash.OpenRequestReports();

            requestReport.Edit(testValues._g_RequestReport);
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void DeleteReqestReport()
        {
            RequestReportPageObjects requestReport = Dash.OpenRequestReports();

            requestReport.Delete(testValues._g_RequestReport);
            System.Threading.Thread.Sleep(1000);


        }
    }
}
