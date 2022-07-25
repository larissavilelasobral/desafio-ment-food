using NUnit.Framework;
namespace Food
{
    [TestFixture]
    public class Item
    {
        private dogao;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("bom dia");
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}