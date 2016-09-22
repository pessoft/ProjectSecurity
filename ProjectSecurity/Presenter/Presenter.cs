using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using View.EventArguments;
using Security.Encryption;
using FileManager;
namespace Presenter
{
    public class Presenter
    {
        private IView view;
        private IEncryption encryption;
        private IFileManger fileManager;

        public Presenter(IView view, IEncryption encryption, IFileManger fileManager)
        {
            this.view = view;
            this.encryption = encryption;
            this.fileManager = fileManager;
            Init();
        }

        private void Init()
        {
            view.ButtonEncodDecodClick += ViewButtonClick;
            view.OpenTextFromFile += ViewOpenTextFromFile;
            view.SavingTextForFile += ViewSavingTextForFile;
        }

        private void ViewSavingTextForFile(object sender, SavingTextEventArgs e)
        {
            fileManager.GetTextRW().Save(e.PathFile, e.Text);
        }

        private void ViewOpenTextFromFile(object sender, OpenFileTextEventArgs e)
        {
            string text = fileManager.GetTextRW().Open(e.PathFile);
            view.SetInText(text);
        }

        private void ViewButtonClick(object sender, ButtonClickEncodDecodEventArgs e)
        {
            ProcessText(e.ProcessType, e.Text);
        }

        private void ProcessText(EncryptionEnum processType, string text)
        {
            string result = string.Empty;
            switch (processType)
            {
                case EncryptionEnum.Encoding:
                    result = encryption.Encoding(text);
                    break;
                case EncryptionEnum.Decoding:
                    result = encryption.Decoding(text);
                    break;
            }

            view.SetOutText(result);
        }
    }
}
