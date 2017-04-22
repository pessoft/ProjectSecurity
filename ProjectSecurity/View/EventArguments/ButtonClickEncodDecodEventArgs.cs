using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.EventArguments
{
    public class EncodDecodEventArgs : EventArgs
    {
        public EncryptionEnum ProcessType { get; private set; }
        public string Text { get; private set; }
        public int KeyOne { get; private set; }
        public int KeyTwo { get; private set; }
        public string Key { get; private set; }
        public Coder CoderType { get; private set; }

        public EncodDecodEventArgs(EncryptionEnum processType, Coder coderType,string text, int key1, int key2)
        {
            ProcessType = processType;
            Text = text;
            KeyOne = key1 == 0 ? 3: key1;
            KeyTwo = key2 == 0 ? 5 : key2;
            CoderType = coderType;
        }

        public EncodDecodEventArgs(EncryptionEnum processType, Coder coderType, string text, string passwordKey)
        {
            ProcessType = processType;
            Key = passwordKey;
            Text = text;
            CoderType = coderType;
        }
    }
}
