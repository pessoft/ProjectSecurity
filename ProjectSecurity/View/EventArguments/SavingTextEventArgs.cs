using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.EventArguments
{
    public class SavingTextEventArgs: EventArgs
    {
        public string Text
        {
            get;
            private set;
        }

        public string PathFile
        {
            get;
            private set;
        }

        public SavingTextEventArgs(string pathFile, string text)
        {
            Text = text;
            PathFile = pathFile;
        }

    }
}
