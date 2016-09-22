using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.EventArguments;

namespace ProjectSecurity
{
    public partial class ProjectSecurity : Form, IView
    {
        public ProjectSecurity()
        {
            InitializeComponent();
            InitializeTagBtn();
        }

        private void InitializeTagBtn()
        {
            
            encodingButton.Tag = EncryptionEnum.Encoding;
            decodingButton.Tag = EncryptionEnum.Decoding;
        }

        private string textSavePath = String.Empty, textOpenFile = string.Empty;
        public event EventHandler<ButtonClickEncodDecodEventArgs> ButtonEncodDecodClick = delegate{};
        public event EventHandler<SavingTextEventArgs> SavingTextForFile = delegate { };
        public event EventHandler<OpenFileTextEventArgs> OpenTextFromFile = delegate { };

        public void SetOutText(string text)
        {
            textBoxOut.Text = text;
        }

        public void SetInText(string text)
        {
            textBoxIn.Text = text;
        }

        protected void OnButtonEncodDecodClick(ButtonClickEncodDecodEventArgs e)
        {
            ButtonEncodDecodClick(this, e);
        }

        protected void OnSavingTextForFile(SavingTextEventArgs e)
        {
            SavingTextForFile(this, e);
        }

        protected void OnOpenTextFromFile(OpenFileTextEventArgs e)
        {
            OpenTextFromFile(this, e);
        }

        private void ButtonEncryptClick(object sender, EventArgs e)
        {
            var button = (ToolStripMenuItem)sender;
            var processType = (EncryptionEnum)button.Tag;
            
            OnButtonEncodDecodClick(new ButtonClickEncodDecodEventArgs(processType, textBoxIn.Text));
        }

        private void SaveText(object sender, EventArgs e)
        {
            string text = string.Empty;
            OnSavingTextForFile(new SavingTextEventArgs(textSavePath, text));
        }

        private void OpenText(object sender, EventArgs e)
        {
            OnOpenTextFromFile(new OpenFileTextEventArgs(textOpenFile));
        }



    }
}
