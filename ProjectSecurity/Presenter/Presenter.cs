using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Security.Encryption;
namespace Presenter
{
    public class Presenter
    {
        private IView view;
        private IEncryption encryption;

        public Presenter(IView view, IEncryption encryption)
        {
            this.view = view;
            this.encryption = encryption;

            Init();
        }

        private void Init()
        {
            view.ButtonEncodDecodClick += ViewButtonClick;
        }

        private void ViewButtonClick(object sender, View.EventArguments.ButtonClickEncodDecodEventArgs e)
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

            view.SetDecodingText(result);
        }
    }
}
