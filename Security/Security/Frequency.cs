using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class Frequency : IFrequency
    {
        private string text;
        private int lengthLetter;

        public Frequency(string sourceText)
        {
            var sbTmp = new StringBuilder();
            
            foreach (var chr in sourceText)
            {
                if (char.IsLetter(chr))
                    sbTmp.Append(chr);
                
            }
            text = sbTmp.ToString();
            lengthLetter = sbTmp.Length;
        }

        public Dictionary<string, double> GetLetterFreq()
        {
            var result = new Dictionary<string, double>();

            if (lengthLetter != 0)
            {
                foreach (var chr in text)
                {
                    if (result.ContainsKey(chr.ToString()))
                        ++result[chr.ToString()];
                    else
                        result.Add(chr.ToString(), 1);
                }

                var keys = result.Keys.ToList();
                foreach (var key in keys)
                {
                    result[key] /= lengthLetter;
                }
            }

            return result;
        }

        public Dictionary<string, double> GetPairLetterFreq()
        {
            var result = new Dictionary<string, double>();

            if (lengthLetter != 0)
            {
                for(int i=0; i<lengthLetter-1; i+=2)
                {
                    var key = text.Substring(i, 2);
                    if (result.ContainsKey(key))
                        ++result[key];
                    else
                        result.Add(key, 1);
                }

                foreach (var key in result.Keys)
                {
                    result[key] /= lengthLetter-1;
                }
            }

            return result;
        }
    }
}
