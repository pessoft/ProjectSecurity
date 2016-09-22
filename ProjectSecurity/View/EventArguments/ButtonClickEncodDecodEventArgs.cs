using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.EventArguments
{
    public class ButtonClickEncodDecodEventArgs : EventArgs
    {
        public EncryptionEnum ProcessType { get; private set; }
        public string Text { get; private set; }

        public ButtonClickEncodDecodEventArgs(EncryptionEnum processType, string text)
        {
            ProcessType = processType;
            Text = text;
        }
    }
}
