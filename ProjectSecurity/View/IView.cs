using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.EventArguments;
namespace View
{
    public interface IView
    {
        event EventHandler<ButtonClickEncodDecodEventArgs> ButtonEncodDecodClick;
        void SetDecodingText(string text);
    }
}
