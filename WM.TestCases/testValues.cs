using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    public class testValues
    {
        public static RequestReportObj _g_RequestReport = new RequestReportObj {
            reportType = "DAL",
            reportNumber = "DAL-x0001", 
            reportDate = "01-Feb-2018"
        };
        public static string _g_UserName = "admin";
        public static string _g_Password = "WMsoftcut!";
        public static areaObj _g_Area = new areaObj
        {
            AreaCode = "Regression Area",
            SubArea1 = "Flow Line",
            SubArea2 = "Piping",
            Description = "Test Area for Regression Testing",
            Location = "Muscat",
            QRNumber = "123456"
        };
        public static string _g_LineNo = "Line01";
        public static string _g_PipingClass = "4CS01P";
        public static JointObj _g_Joint = new JointObj
        {
            JointSheet = "1/2",
            JointCategory = "FIELD",
            JointType = "BW",
            DIAM = "12",
            THICK = "2",
            JointWPS = "_WPS01",
            DAL = "DAL-001",
            VI = "VI-12",
            ActivityNo = "1",
            Fitupdate = "10-Feb-2018",

            WeldDate = "12-Feb-2018",
            Welder1 = "W01_r",
            Welder2 = "W02_r",
            Welder3 = "W03_r",
            Welder4 = "",

        };
        public static WeldJointObj _g_WelJointObj = new WeldJointObj
        {
            WPS = "_WPS01",
            WeldDate = "22-Feb-2018",
            Welder1 = "W01_r",
            Welder2 = "W02_r",
            Welder3 = "W03_r"
        };
    }

    public class MyFactoryClass
    {
        public static IEnumerable Welders
        {
            get
            {
                yield return new TestCaseData(new WelderObj
                {
                    WelderIDNO = "W01_r",
                    WelderName = "Reg Welder 01",
                    contractor = "ATE",
                    location = "Amal",
                    SerialNo = "123456",
                    WelderPosition = "Junior Welder",
                    DIAMFrom = "2",
                    DIAMTo = "24",
                    THICKFrom = "0",
                    THICKTo = "12",
                    Material = "P1-P6",
                    Position = "C"
                });
                yield return new TestCaseData(new WelderObj
                {
                    WelderIDNO = "W02_r",
                    WelderName = "Reg Welder 02",
                    contractor = "ATE",
                    location = "Amal",
                    SerialNo = "123457",
                    WelderPosition = "Senior Welder",
                    DIAMFrom = "2",
                    DIAMTo = "24",
                    THICKFrom = "0",
                    THICKTo = "12",
                    Material = "P1-P4",
                    Position = "C"
                });
                yield return new TestCaseData(new WelderObj
                {
                    WelderIDNO = "W03_r",
                    WelderName = "Reg Welder 03",
                    contractor = "ATE",
                    location = "Amal",
                    SerialNo = "123458",
                    WelderPosition = "Senior Welder",
                    DIAMFrom = "2",
                    DIAMTo = "24",
                    THICKFrom = "0",
                    THICKTo = "12",
                    Material = "P1-P2",
                    Position = "C"
                });
            }
        }

        public static IEnumerable WPSs
        {
            get
            {
                yield return new TestCaseData(new WPSObj
                {
                    WPSCode = "ASME IX",
                    WPSName = "_WPS01",
                    PQR = "PQR01",
                    ThickFrom = "0",
                    ThickTo = "12",
                    DIAFrom = "0",
                    DIATo = "24",
                });
                yield return new TestCaseData(new WPSObj
                {
                    WPSCode = "ASME IX",
                    WPSName = "_WPS02",
                    PQR = "PQR02",
                    ThickFrom = "0",
                    ThickTo = "12",
                    DIAFrom = "0",
                    DIATo = "24",

                });
                yield return new TestCaseData(new WPSObj
                {
                    WPSCode = "ASME IX",
                    WPSName = "_WPS03",
                    PQR = "PQR03",
                    ThickFrom = "0",
                    ThickTo = "12",
                    DIAFrom = "0",
                    DIATo = "24",
                });
            }
        }

        public static IEnumerable WelderWPS
        {
            get
            {
                yield return new TestCaseData(new WelderWPSObj
                {
                    Welder = "W01_r",
                    WPS = "_WPS01",
                    From = "01-May-2017",
                    To = "01-Nov-2017"
                });
                yield return new TestCaseData(new WelderWPSObj
                {
                    Welder = "W01_r",
                    WPS = "_WPS02",
                    From = "01-May-2017",
                    To = "01-Nov-2017"
                });
                yield return new TestCaseData(new WelderWPSObj
                {
                    Welder = "W02_r",
                    WPS = "_WPS01",
                    From = "01-May-2017",
                    To = "01-Nov-2017"
                });
                yield return new TestCaseData(new WelderWPSObj
                {
                    Welder = "W02_r",
                    WPS = "_WPS02",
                    From = "01-May-2017",
                    To = "01-Nov-2017"
                });
                yield return new TestCaseData(new WelderWPSObj
                {
                    Welder = "W03_r",
                    WPS = "_WPS01",
                    From = "01-May-2017",
                    To = "01-Nov-2017"
                });
            }
        }

        public static IEnumerable Lines
        {
            get
            {
                yield return new TestCaseData(new lineObj
                {
                    LineNo = "Line01",
                    PipingClass = "4CS01P",
                    MainSize = "12",
                    revision = "A",
                    DrawingNo1 = "Draw0123",
                    DrawingNo2 = "Draw0124",
                    SheetNo1 = "1/2",
                    SheetNo2 = "2/2",
                    Service = "Anti Foam"
                });
                yield return new TestCaseData(new lineObj
                {
                    LineNo = "Line02",
                    PipingClass = "4CS01P",
                    MainSize = "12",
                    revision = "A",
                    DrawingNo1 = "Draw0123",
                    DrawingNo2 = "Draw0124",
                    SheetNo1 = "1/2",
                    SheetNo2 = "2/2",
                    Service = "Anti Foam"
                });
                yield return new TestCaseData(new lineObj
                {
                    LineNo = "Line03",
                    PipingClass = "4CS01P",
                    MainSize = "12",
                    revision = "A",
                    DrawingNo1 = "Draw0123",
                    DrawingNo2 = "Draw0124",
                    SheetNo1 = "1/2",
                    SheetNo2 = "2/2",
                    Service = "Anti Foam"
                });
            }
        }

        public static IEnumerable Joints
        {
            get
            {
                yield return new TestCaseData(new JointObj
                {
                    JointSheet = "1/2",
                    JointNo = "J01",
                    JointCategory = "FIELD",
                    JointType = "BW",
                    DIAM = "12",
                    THICK = "2",
                    JointWPS = "_WPS01",
                    DAL = "DAL-001",
                    VI = "VI-12",
                    ActivityNo = "1",
                    Fitupdate = "13-Feb-2018",

                    WeldDate = "15-Feb-2018",
                    Welder1 = "W01_r",
                    Welder2 = "W02_r",
                    Welder3 = "",
                    Welder4 = "",

                    VTReportDate = "16-Feb-2018",
                    VTReportNumber = "VT-x0001",
                });
                yield return new TestCaseData(new JointObj
                {
                    JointSheet = "1/2",
                    JointNo = "J01",
                    JointCategory = "FIELD",
                    JointType = "BW",
                    DIAM = "12",
                    THICK = "2",
                    JointWPS = "_WPS01",
                    DAL = "DAL-001",
                    VI = "VI-12",
                    ActivityNo = "1",
                    Fitupdate = "13-Feb-2018",

                    WeldDate = "15-Feb-2018",
                    Welder1 = "W01_r",
                    Welder2 = "W02_r",
                    Welder3 = "",
                    Welder4 = "",

                    VTReportDate = "16-Feb-2018",
                    VTReportNumber = "VT-x0001",
                });
            }
        }

        public static IEnumerable RequestReports
        {
            get
            {
                yield return new TestCaseData(new RequestReportObj
                {
                    reportType = "DAL",
                    reportNumber = "DAL-x0001",
                    reportDate = "03-Feb-2018"
                });
                yield return new TestCaseData(new RequestReportObj
                {
                    reportType = "VI",
                    reportNumber = "VI-x0001",
                    reportDate = "02-Feb-2018"
                });
                yield return new TestCaseData(new RequestReportObj
                {
                    reportType = "Weld",
                    reportNumber = "Weld-x0001",
                    reportDate = "01-Feb-2018"
                });
            }
        }

        public static IEnumerable JointsPP
        {
            get
            {
                yield return new TestCaseData(new JointObj
                {
                    JointSheet = "1/2",
                    JointCategory = "FIELD",
                    JointType = "SW",
                    DIAM = "12",
                    THICK = "2",
                    JointWPS = "_WPS03",
                    DAL = "DAL-001",
                    VI = "VI-12",
                    ActivityNo = "1",
                });
                yield return new TestCaseData(new JointObj
                {
                    JointSheet = "1/2",
                    JointCategory = "FIELD",
                    JointType = "BW",
                    DIAM = "12",
                    THICK = "2",
                    JointWPS = "_WPS01",
                    DAL = "DAL-001",
                    VI = "VI-12",
                    ActivityNo = "1",
                    Fitupdate = "13-Feb-2018",

                    WeldDate = "15-Feb-2018",
                    Welder1 = "W01_r",
                    Welder2 = "W02_r",
                    Welder3 = "",
                    Welder4 = "",
                });
                yield return new TestCaseData(new JointObj
                {
                    JointSheet = "1/2",
                    JointCategory = "FIELD",
                    JointType = "BW",
                    DIAM = "12",
                    THICK = "2",
                    JointWPS = "_WPS01",
                    DAL = "DAL-001",
                    VI = "VI-12",
                    ActivityNo = "1",
                    Fitupdate = "13-Feb-2018",

                    WeldDate = "15-Feb-2018",
                    Welder1 = "W01_r",
                    Welder2 = "W02_r",
                    Welder3 = "W03_r",
                    Welder4 = "",

                    VTReportDate = "16-Feb-2018",
                    VTReportNumber = "VT-x0001",
                });
            }
        }
    }
}

//public enum PipingClass
//{
//    CS04P01,
//    CS04P02,
//    CS04P03
//}
