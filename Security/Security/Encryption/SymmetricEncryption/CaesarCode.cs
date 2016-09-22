using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Encryption.SymmetricEncryption
{
    /// <summary>
    /// Реализует кодировку и декодировку тектса шифром Цезаря
    /// </summary>
    public class CaesarCode : BaseEncryption, IEncryption
    {
        #region properties
        public int AlphabetLength { get; set; } 
        public int KeyN { get; set; }
        public int KeyK { get; set; }
        #endregion

        #region ctor
        public CaesarCode(int keyN = 3, int keyK = 5)
        {
            AlphabetLength = Alphabet.Count;
            KeyN = keyN;
            KeyK = keyK;
        }
        #endregion

        #region encoding and decoding
        /// <summary>
        /// Кодирует тект шифром Цезаря
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Закодированный текст</returns>
        public string Encoding(string text)
        {
            var result = new StringBuilder();

            foreach (var chr in text)
            {
                var code = 0;
                switch (chr)
                {
                    case '\r':
                        code = AlphabetLength - 2;
                        break;
                    case '\n':
                        code = AlphabetLength-1;
                        break;
                    default:
                        code = Alphabet[chr];
                        break;
                }

                int tmpRes = (code * KeyN + KeyK) % AlphabetLength;
                char encChar = GetChar(tmpRes);
                result.Append(encChar);
            }

            return result.ToString();
        }

        /// <summary>
        /// Декодирует текст закодированный шифром Цезаря
        /// </summary>
        /// <param name="text">Закодированный тексте</param>
        /// <returns>Декодированный текст</returns>
        public string Decoding(string text)
        {
            var result = new StringBuilder();

            foreach (var chr in text)
            {
                int code = 0;
                switch (chr)
                {
                    case '\r':
                        code = AlphabetLength - 2;
                        break;
                    case '\n':
                        code = AlphabetLength - 1;
                        break;
                    default:
                        code = Alphabet[chr];
                        break;
                }

                int tmpRes =(int)((code - KeyK) * ModPow(AlphabetLength, KeyN) % AlphabetLength);
                char decChar = GetChar(tmpRes);
                result.Append(decChar);
            }

            return result.ToString();
        }

        /// <summary>
        /// Возведение в стемень по модулю расшириным алгоритмом Евклида
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns></returns>
        private int ModPow(int numberOne, int numberTwo)
        {
            Func<int, int, int> nod = (a, b) =>
                                             {
                                                  while (b != 0)
                                                     b = a % (a = b);
                                                  return a;
                                             };
            var result = 0;
            if (numberOne < numberTwo)
            {
                var tmp = numberOne;
                numberOne = numberTwo;
                numberTwo = tmp;
            }

            result = (nod(numberOne, numberTwo) - numberOne * (-1)) / numberTwo;
            return result;
        }


        private char GetChar(int code)
        {
            var chr = '\0';

            if(code == AlphabetLength - 2)
                chr = '\r';
            else
                if (code == AlphabetLength - 1)
                    chr = '\n';
                else
                chr = Alphabet.FirstOrDefault(p => p.Value == code).Key;
           
            return chr;
        }
        #endregion
    }
}
