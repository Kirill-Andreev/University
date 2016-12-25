using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FilterNameSpace;

namespace Task_2.Test
{
    [TestClass]
    public class FilterTest
    {
        [TestMethod]
        public void FilterFunctionTest()
        {
            Filter filter = new Filter();
            List<int> list = filter.FilterFunction(new List<int>() { 1, 2, 3, 4, 5 }, function => function % 2 == 1);

            for (int i = 0; i < list.Count; ++i)
            {
                Assert.AreEqual(list[i], (i * 2 + 1));
            }
        }
    }
}
