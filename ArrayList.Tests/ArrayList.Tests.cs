using System;
using NUnit.Framework;

namespace ArrayList.Tests
{
    class ArrayListTests
    {
        [TestCase(new int[] { },0)]
        [TestCase(new int[] {1},1)]
        [TestCase(new int[] {1,2,3},3)]

        public void SizeTest(int[] original, int expected)
        {
            ArrayList list = new ArrayList(original);
            Assert.AreEqual(expected, list.Size());
        }

    }
}
