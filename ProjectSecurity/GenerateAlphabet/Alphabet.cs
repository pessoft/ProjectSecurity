using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAlphabet
{
    public class Alphabet
    {
        private static Dictionary<char, int> dataChar = new Dictionary<char, int>();
        private static int numberChr = 0;
        public static Dictionary<char, int> GetAlphabet()
        {
            char chrLowA='\0', chrUpA='\0';
            int countAlph = 0;

            Action<List<CharCode>> alphaToDictionaryLow = x => x.ForEach(p=> dataChar.Add(p.ChrLow, numberChr++));
            Action<List<CharCode>> alphaToDictionaryUp = x => x.ForEach(p => dataChar.Add(p.ChrUp,numberChr++));

            chrLowA = 'а';
            chrUpA = 'А';
            countAlph = 32;

            var alphabetRus = Enumerable.Range(0, countAlph).Select(i => new CharCode { ChrUp = (char)(chrUpA + i), ChrLow = (char)(chrLowA + i) }).ToList();

            alphaToDictionaryLow(alphabetRus);
            alphaToDictionaryUp(alphabetRus);

            chrLowA = 'a';
            chrUpA = 'A';
            countAlph = 26;

            var alphabetEng = Enumerable.Range(0, countAlph).Select(i => new CharCode {  ChrUp = (char)(chrUpA + i), ChrLow = (char)(chrLowA + i) }).ToList();


            GetDigit();

            return dataChar;
        }


        private static void GetDigit()
        {
            for (int i = 0; i < 188; ++i)
            {
                if (char.IsPunctuation((char)i))
                    dataChar.Add((char)i, numberChr++);
            }

            dataChar.Add('\r', numberChr++);
            dataChar.Add('\n', numberChr++);
        }

        private class CharCode
        {
            public char ChrUp { get; set; }
            public char ChrLow { get; set; }

        }
    }
}
