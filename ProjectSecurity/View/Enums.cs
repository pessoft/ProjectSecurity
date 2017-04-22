using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public enum EncryptionEnum
    {
        Encoding,
        Decoding 
    }

    public enum TypeText
    {
        Source,
        Processed
    }

    public enum FrequencyTypeTask
    {
        Letter,
        PairLetter
    }

    public enum Coder
    {
        CaesarCoder,
        PolybiusCoder,
        VizhinerCoder,
        PairedСipherCoder
    }
}
