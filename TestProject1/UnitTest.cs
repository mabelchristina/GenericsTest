using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void GivenMaxInFirstPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            int a = 10, b = 3, c = 4;
            MaxOfNumber maxOfNumber = new MaxOfNumber();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(a,actual);
        }
    }
}