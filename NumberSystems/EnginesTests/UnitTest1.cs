using NUnit.Framework;
using NumberSystems;

namespace EnginesTests
{
    public class Tests
    {
        [Test]
        public void TestConvertDecimalToDecimal()
        {
            IEngine engine = new DecimalEngine("10");
            Assert.AreEqual("10", engine.ConvertToDecimal());
        }
        [Test]
        public void TestConvertDecimalToHex()
        {
            IEngine engine = new DecimalEngine("10");
            Assert.AreEqual("A", engine.ConvertToHex());
        }
    }
}