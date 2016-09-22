using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Security.Encryption
{
    public abstract class BaseEncryption
    {
        protected Dictionary<char, int> Alphabet { get; set; } = Security.Helpers.Alphabet.GetAlphabet();
    }


}
