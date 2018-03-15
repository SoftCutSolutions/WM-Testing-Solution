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

        [Test, TestCaseSource(typeof(MyFactoryClass), "Materials")]
        public void Newmaterials(materialObj mat)
        {
            materialsPageObjects materials = Dash.OpenMaterials();

            materials.New(mat);
            System.Threading.Thread.Sleep(2000);
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "Materials")]
        public void Editmaterials(materialObj mat)
        {
            materialsPageObjects materials = Dash.OpenMaterials();

            materials.Edit(mat);
            System.Threading.Thread.Sleep(2000);
        }

        [Test, TestCaseSource(typeof(MyFactoryClass), "Materials")]
        public void Deletematerials(materialObj mat)
        {
            materialsPageObjects materials = Dash.OpenMaterials();

            materials.Delete(mat);
            System.Threading.Thread.Sleep(2000);
        }

    }
}
