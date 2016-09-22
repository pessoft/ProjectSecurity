using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.EventArguments
{
    public class OpenFileTextEventArgs: EventArgs
    {
        public string PathFile
        {
            get;
            private set;
        }

        public OpenFileTextEventArgs(string pathFile)
        {
            PathFile = pathFile;
        }
    }
}
