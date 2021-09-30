using GenericTest;
using NUnit.Framework;

namespace GenericUnitTest
{
    public class Tests
    {
        [Test]
        public void GivenMaxInFirstPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            int a=10,b=2,c=5;
            MaxOfNumber maxOfNumber = new MaxOfNumber();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(a,actual);
        }
    }
}