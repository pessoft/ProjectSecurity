using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Encryption
{
    /// <summary>
    /// Методы шифровки и расшифровки текста
    /// </summary>
    public interface IEncryption
    {
        /// <summary>
        /// Кодирует текст
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Закодированный текст</returns>
        string Encoding(string text);

        /// <summary>
        /// Декодирует текст
        /// </summary>
        /// <param name="text">Закодированный текст</param>
        /// <returns>Декоированный текст</returns>
        string Decoding(string text);
    }
}
