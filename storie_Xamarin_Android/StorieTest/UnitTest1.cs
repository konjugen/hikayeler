using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using storieService.Controllers;

namespace StorieTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var cc = new CategoriesController();

            var result = cc.GetCategories();
        }
    }
}
