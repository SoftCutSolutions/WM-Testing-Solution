using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace WM.TestCases.Tests.Data
{
    [TestFixture]
    [Parallelizable]

    class _T_Materials:Hooks
    {

        [Test]
        public void Newmaterials()
        {
            materialsPageObjects materials = Dash.OpenMaterials();

            materials.New(testValues._g_materials);
            System.Threading.Thread.Sleep(2000);

        }

        [Test]
        public void Editmaterials()
        {
            materialsPageObjects materials = Dash.OpenMaterials();

            materials.Edit(testValues._g_materials);
            System.Threading.Thread.Sleep(2000);

        }

        [Test]
        public void Deletematerials()
        {
            materialsPageObjects materials = Dash.OpenMaterials();

            materials.Delete(testValues._g_materials);
            System.Threading.Thread.Sleep(2000);

        }




    }
}
