using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.EventArguments
{
    public class ApplySettingEventArgs: EventArgs
    {
        public int KeyOne { get; private set; }
        public int KeyTwo { get; private set; }
        public string PasswordKey { get; private set; }

        public ApplySettingEventArgs(int key1, int key2)
        {
            KeyOne = key1;
            KeyTwo = key2;
        }

        public ApplySettingEventArgs(string passwordKey)
        {
            PasswordKey = passwordKey;
        }
    }
}
