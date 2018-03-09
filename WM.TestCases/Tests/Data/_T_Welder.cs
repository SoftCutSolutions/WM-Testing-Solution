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
    class _T_Welder:Hooks
    {
        [Test]
        public void NewWelder()
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.NewWelder(testValues._g_Welder, testValues._g_WelderProcessValues);
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void EditWelder()
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.EditWelder(testValues._g_Welder);
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void DeleteWelder()
        {
            welderPageObjects wld = Dash.OpenWelder();
            System.Threading.Thread.Sleep(1000);

            wld.DeleteWelder(testValues._g_Welder);
            System.Threading.Thread.Sleep(1000);
        }


    }
}
