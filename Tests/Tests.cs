using NUnit.Framework;

namespace Algo.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            int[] expected = { 3, 4 };
            int[] result = Algo.SearchRange(nums, target);
            Assert.AreEqual(expected, result); //
        }

        [Test]
        public void Test2()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 6;
            int[] expected = { -1, -1 };
            int[] result = Algo.SearchRange(nums, target);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
            int[] nums = { };
            int target = 0;
            int[] expected = { -1, -1 };
            int[] result = Algo.SearchRange(nums, target);
            Assert.AreEqual(expected, result);
        }
    }
}

