using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumeralsTests
{
    [TestClass]
    public class RomanConverterTest
    {
        [TestMethod]
        public void ShouldConvertSingleDigit()
        {
            var converter = new RomanConverter();
            Assert.AreEqual(1, converter.Convert("I"));
            Assert.AreEqual(5, converter.Convert("V"));
            Assert.AreEqual(10, converter.Convert("X"));
            Assert.AreEqual(50, converter.Convert("L"));
            Assert.AreEqual(100, converter.Convert("C"));
            Assert.AreEqual(500, converter.Convert("D"));
            Assert.AreEqual(1000, converter.Convert("M"));
        }

        [TestMethod]
        public void ShouldConvertDoubleDigit()
        {
            var converter = new RomanConverter();
            Assert.AreEqual(2, converter.Convert("II"));
            Assert.AreEqual(20, converter.Convert("XX"));
        }

        [TestMethod]
        public void ShouldConvertComplexNumber()
        {
            var converter = new RomanConverter();
            Assert.AreEqual(4, converter.Convert("IV"));
            Assert.AreEqual(1946, converter.Convert("MCMXLVI"));
        }
    }
}
