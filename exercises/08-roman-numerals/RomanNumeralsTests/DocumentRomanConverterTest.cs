using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RomanNumerals;

namespace RomanNumeralsTests
{
    [TestClass]
    public class DocumentRomanConverterTest
    {
        [TestMethod]
        public void ShouldConvertAllTokens()
        {
            var filename = "name";
            var document = "I VI";
            var results = new List<int> {1, 6};

            var documentReader = new Mock<IDocumentReader>();
            var romanConverter = new Mock<IRomanConverter>();

            documentReader.Setup(d => d.Read(It.Is<string>(s => s == filename)))
                .Returns(document);

            romanConverter.Setup(c => c.Convert(It.Is<string>(s => s == "I")))
                .Returns(results[0]);

            romanConverter.Setup(c => c.Convert(It.Is<string>(s => s == "VI")))
                .Returns(results[1]);

            var converter = new DocumentRomanConverter(
                documentReader.Object, 
                romanConverter.Object
            );

            var actualResult = converter.ConvertDocument(filename);

            CollectionAssert.AreEqual(results, actualResult);
        }
    }
}