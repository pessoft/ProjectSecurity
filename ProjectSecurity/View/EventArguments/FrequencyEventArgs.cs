using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.EventArguments
{
    public class FrequencyEventArgs : EventArgs
    {
        public string SourceText { get; private set; }

        public FrequencyEventArgs(string sourceText)
        {
            SourceText = sourceText;
        }
    }
}
