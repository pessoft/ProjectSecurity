using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public interface ITextWorker
    {
        bool Save(string path, string text);
        string Open(string path);
    }
}
