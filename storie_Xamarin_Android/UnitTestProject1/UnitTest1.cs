using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using storieService.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ca = new CategoriesController();

            var rst = ca.GetCategories();
        }
    }
}
