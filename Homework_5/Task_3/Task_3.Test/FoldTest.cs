using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoldNameSpace;
using System.Collections.Generic;

namespace Task_3.Test
{
    [TestClass]
    public class FoldTest
    {
        [TestMethod]
        public void FoldFunctionTest()
        {
            Fold fold = new Fold();
            int value = fold.FoldFunction(new List<int>() { 1, 2, 3, 4, 5 }, 2, (acc, elem) => acc * elem);
            Assert.AreEqual(value, 240);
        }
    }
}
