using NUnit.Framework;

namespace WM.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class _T_WeldJoint:Hooks
    {
        [Test]
        public void NewWeldJoint()
        {
            WeldJointPageObjects wj = Dash.OpenWeldJoint();
            wj.NewWeldJoint(testValues._g_WelJointObj);
        }

        [Test]
        public void EditWeldJoint()
        {

        }

        [Test]
        public void DeleteWeldJoint()
        {

        }
    }
}
