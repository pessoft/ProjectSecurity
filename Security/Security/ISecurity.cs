using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Security.Encryption;

namespace Security
{
    public interface ISecurity
    {
        IEncryption CeasarCoder(int keyN = 3, int keyK = 5);
        IEncryption PolybiusCoder(string passwordKey);
        IEncryption VizhinerCoder(string key);
        IEncryption PairedСipher(string key);
        IFrequency CalcFreq(string sourceText);      
    }
}
