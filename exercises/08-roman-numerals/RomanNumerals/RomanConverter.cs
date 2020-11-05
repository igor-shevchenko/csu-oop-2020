using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanConverter : IRomanConverter
    {
        private Dictionary<char, int> digits = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public int Convert(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length; ++i)
            {
                if (i != s.Length - 1 && digits[s[i]] < digits[s[i + 1]])
                    result -= digits[s[i]];
                else
                    result += digits[s[i]];
            }

            return result;
        }
    }
}
