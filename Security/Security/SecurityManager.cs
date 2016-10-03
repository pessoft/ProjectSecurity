using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Security.Encryption;
using Security.Encryption.SymmetricEncryption;
namespace Security
{
    public class SecurityManager : ISecurity
    {
        /// <summary>
        /// Create class calculate frequency
        /// </summary>
        /// <param name="sourceText">csource text</param>
        /// <returns>interface frequency</returns>
        public IFrequency CalcFreq(string sourceText)
        {
            return new Frequency(sourceText);
        }

        /// <summary>
        /// Create class CaesarCode
        /// </summary>
        /// <param name="keyN">ferst key</param>
        /// <param name="keyK">second key</param>
        /// <returns>IEncryption</returns>
        public IEncryption CeasarCoder(int keyN = 3, int keyK = 5)
        {
            return new CaesarCode(keyN, keyK);
        }
    }
}
