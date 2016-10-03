using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using View.EventArguments;
using Security.Encryption;
using Security;
using FileManager;
namespace Presenter
{
    public class Presenter
    {
        private IView view;
        private ISecurity securityManager;
        private IFileManger fileManager;

        public Presenter(IView view, ISecurity securityManager, IFileManger fileManager)
        {
            this.view = view;
            this.securityManager = securityManager;
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
                    result = securityManager.CeasarCoder().Encoding(text);
                    break;
                case EncryptionEnum.Decoding:
                    result = securityManager.CeasarCoder().Decoding(text);
                    break;
            }

            view.SetOutText(result);
        }
    }
}
