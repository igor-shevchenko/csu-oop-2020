using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
    public class DocumentRomanConverter
    {
        private IDocumentReader _documentReader;
        private IRomanConverter _romanConverter;

        public DocumentRomanConverter(IDocumentReader documentReader, IRomanConverter romanConverter)
        {
            _documentReader = documentReader;
            _romanConverter = romanConverter;
        }

        public List<int> ConvertDocument(string name)
        {
            var document = _documentReader.Read(name);
            var tokens = document.Split(' ');
            return tokens
                .Select(t => _romanConverter.Convert(t))
                .ToList();
        }
    }
}