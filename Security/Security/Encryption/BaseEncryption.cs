using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Security.Helpers;

namespace Security.Encryption
{
    public abstract class BaseEncryption
    {
        protected Dictionary<int, int> Alphabet { get; set; } = new Alphabet().GetAlphabet();
    }


}
