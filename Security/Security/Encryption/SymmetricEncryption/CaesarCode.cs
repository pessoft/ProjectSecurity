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
    public class CaesarCode :IEncryption
    {
        #region properties
        public int AlphabetLength { get; set; } 
        public int KeyN { get; set; }
        public int KeyK { get; set; }
        #endregion

        #region ctor
        /// <summary>
        /// Шифр Цезаря
        /// </summary>
        /// <param name="keyN">Первый ключ шифра</param>
        /// <param name="keyK">Второй ключ шифра</param>
        public CaesarCode(int keyN = 3, int keyK = 5)
        {
            AlphabetLength = 64997;
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
                char tmpRes = (char)((chr * KeyN + KeyK) % AlphabetLength);
               
                result.Append(tmpRes);
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
                var min = (chr - KeyK) < 0 ? (chr - KeyK) + AlphabetLength : chr - KeyK;
                var div = min;
                while (true)
                {
                    if (div % KeyN == 0)
                    {
                        div /= KeyN;
                        break;
                    }
                    div += AlphabetLength;
                }

                char tmpRes =(char)(div % AlphabetLength);
                result.Append(tmpRes);
            }

            return result.ToString();
        }
        
        #endregion
    }
}
