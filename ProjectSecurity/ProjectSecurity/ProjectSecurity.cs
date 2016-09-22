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
            buttonEncoding.Tag = EncryptionEnum.Encoding;
            buttonDecoding.Tag = EncryptionEnum.Decoding;
        }

        public event EventHandler<ButtonClickEncodDecodEventArgs> ButtonEncodDecodClick = delegate{};

        public void SetDecodingText(string text)
        {
            textBoxOut.Text = text;
        }

        protected void OnButtonEncodDecodClick(ButtonClickEncodDecodEventArgs e)
        {
            ButtonEncodDecodClick(this, e);
        }

        private void ButtonEncryptClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var processType = (EncryptionEnum)button.Tag;
            
            OnButtonEncodDecodClick(new ButtonClickEncodDecodEventArgs(processType, textBoxIn.Text));
        }
    }
}
