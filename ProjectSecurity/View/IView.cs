using System;
using View.EventArguments;
namespace View
{
    public interface IView
    {
        event EventHandler<ButtonClickEncodDecodEventArgs> ButtonEncodDecodClick;
        event EventHandler<SavingTextEventArgs> SavingTextForFile;
        event EventHandler<OpenFileTextEventArgs> OpenTextFromFile;
        void SetOutText(string text);
        void SetInText(string text);
    }
}
