using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    public class testValues
    {


        public static string _g_UserName = "admin";
        public static string _g_Password = "WMsoftcut!";

        public static string _g_PipingClass = "4CS01P!";
        public static string _g_Area = "Regression Area";

        public static WelderObj _g_Welder = new WelderObj
        {
            WelderIDNO = "REGWelder01",
            WelderName = "Reg Welder 01",
            contractor = "ATE",
            location = "Amal",
            SerialNo = "123456",
            WelderPosition = "Senior Welder",
        };

        public static welderProcess _g_WelderProcessValues = new welderProcess
        {
            DIAMFrom = "2",
            DIAMTo = "12",
            THICKFrom = "0",
            THICKTo = "24",
            Material = "P1-P6",
            Position = "C"
        };

        public static WPSObj _g_WPS = new WPSObj
        {
            WPSCode = "ASME IX",
            WPSName = "_WPS01",
            PQR = "PQR01",
            ThickFrom = "0",
            ThickTo = "12",
            DIAFrom = "0",
            DIATo = "24"
        };

        public static lineObj _g_Line = new lineObj
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
        };

        public static JointObj _g_Joint = new JointObj
        {
            JointCategory = "FIELD",
            JointType = "BW",
            DIAM = "12",
            THICK = "2",
            JointWPS = "No WPS",
            DAL = "DAL-001",
            VI = "VI-12",
            ActivityNo = "1",
            Fitupdate = "12-2-2018"
        };
    }
}
