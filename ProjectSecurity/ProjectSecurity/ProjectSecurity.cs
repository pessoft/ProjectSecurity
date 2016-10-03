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
            InitializeComponentPartial();
        }

        private void InitializeComponentPartial()
        {
            
            btnEncoding.Tag = EncryptionEnum.Encoding;
            btnDecoding.Tag = EncryptionEnum.Decoding;
            sourceBtnSaveSource.Tag = TypeText.Source;
            sourceBtnSaveProcessed.Tag = TypeText.Processed;
            textToolStripMenuSaveSource.Tag = TypeText.Source;
            textToolStripMenuSaveProcessed.Tag = TypeText.Processed; ;
            activeTxtBox = textBoxIn;
        }

        public event EventHandler<ButtonClickEncodDecodEventArgs> ButtonEncodDecodClick = delegate{};
        public event EventHandler<SavingTextEventArgs> SavingTextForFile = delegate { };
        public event EventHandler<OpenFileTextEventArgs> OpenTextFromFile = delegate { };
        private TextBox activeTxtBox;

        public void SetOutText(string text)
        {
            textBoxOut.Text = text;
        }

        public void SetInText(string text)
        {
            activeTxtBox.Text = text;
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
            if (FileDialogShow(saveFileText) == DialogResult.OK)
            {
                var typeText = (TypeText)(sender as ToolStripMenuItem).Tag;
                switch (typeText)
                {
                    case TypeText.Source:
                        OnSavingTextForFile(new SavingTextEventArgs(saveFileText.FileName, activeTxtBox.Text));
                        break;
                    case TypeText.Processed:
                        OnSavingTextForFile(new SavingTextEventArgs(saveFileText.FileName, textBoxOut.Text));
                        break;
                }
                
            }
            
        }

        private void OpenText(object sender, EventArgs e)
        {
            if (FileDialogShow(openFileText) == DialogResult.OK)
                OnOpenTextFromFile(new OpenFileTextEventArgs(openFileText.FileName));
        }

        private DialogResult FileDialogShow(FileDialog sender)
        {
            return sender.ShowDialog();
        }

        private void projectContentSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (projectContent.SelectedIndex)
            {
                case 0:
                    activeTxtBox = textBoxIn;
                    break;
                case 1:
                    activeTxtBox = frequencySourceText;
                    break;
            }
        }

        private void toolStripBtnPrcToSrcClick(object sender, EventArgs e)
        {
            if (textBoxOut.TextLength != 0)
                textBoxIn.Text = textBoxOut.Text;
        }

        private void toolStripMenuExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projectContentSelecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    toolStripBtnEncryption.Visible = true;
                    toolStripBtnPrcToSrc.Visible = true;
                    sourceBtnSaveProcessed.Visible = true;
                    textToolStripMenuSaveProcessed.Visible = true;
                    break;
                case 1:
                    toolStripBtnEncryption.Visible = false;
                    toolStripBtnPrcToSrc.Visible = false;
                    sourceBtnSaveProcessed.Visible = false;
                    textToolStripMenuSaveProcessed.Visible = false;
                    break;
            }
        }
    }
}
