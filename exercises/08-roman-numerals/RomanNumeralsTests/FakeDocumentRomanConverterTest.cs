using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RomanNumerals;

namespace RomanNumeralsTests
{
    class FakeDocumentReader : IDocumentReader
    {
        private string document;
        private string expectedName;

        public FakeDocumentReader(string document, string expectedName)
        {
            this.document = document;
            this.expectedName = expectedName;
        }

        public string Read(string name)
        {
            if (name != expectedName)
                throw new Exception();
            return document;
        }
    }

    class FakeRomanConverter : IRomanConverter
    {
        public int Convert(string s)
        {
            if (s == "I")
                return 1;
            if (s == "VI")
                return 6;
            return 9;
        }
    }

    [TestClass]
    public class FakeDocumentRomanConverterTest
    {
        [TestMethod]
        public void ShouldConvertAllTokens()
        {
            var filename = "name";
            var document = "I VI";
            var results = new List<int> {1, 6};

            var converter = new DocumentRomanConverter(
                new FakeDocumentReader(document, filename), 
                new FakeRomanConverter()
            );

            var actualResult = converter.ConvertDocument(filename);

            CollectionAssert.AreEqual(results, actualResult);
        }
    }
}