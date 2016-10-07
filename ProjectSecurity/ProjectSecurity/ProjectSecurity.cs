using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        public event EventHandler<FrequencyEventArgs> CalcFrequenceLetter = delegate { };

        private TextBox activeTxtBox;

        protected void OnCalcFrequenceLetter(FrequencyEventArgs e)
        {
            CalcFrequenceLetter(this, e);

        }

        

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
                    toolStripBtnCalcFreqLetters.Visible = false;
                    break;
                case 1:
                    toolStripBtnEncryption.Visible = false;
                    toolStripBtnPrcToSrc.Visible = false;
                    sourceBtnSaveProcessed.Visible = false;
                    textToolStripMenuSaveProcessed.Visible = false;
                    toolStripBtnCalcFreqLetters.Visible = true;
                    break;
            }
        }

        public void SetFrequencyChart(Chart chart, FrequencyTypeTask freqTypeTask)
        {
            switch (freqTypeTask)
            {
                case FrequencyTypeTask.Letter:
                    chartFrqeLetters.ChartAreas.Clear();;
                    chartFrqeLetters.Series.Clear();
                    chartFrqeLetters.Legends.Clear();
                    chartFrqeLetters.ChartAreas.Add(chart.ChartAreas[0]);
                    
                    chartFrqeLetters.Series.Add(chart.Series[0]);
                   // chartFrqeLetters.Parent = groupBox2;
                    break;
                case FrequencyTypeTask.PairLetter:
                    chartFrqePairLetters.ChartAreas.Clear(); ;
                    chartFrqePairLetters.Series.Clear();
                    chartFrqePairLetters.Legends.Clear();
                    chartFrqePairLetters.ChartAreas.Add(chart.ChartAreas[0]);

                    chartFrqePairLetters.Series.Add(chart.Series[0]);
                    break;
            }
        }

        private void toolStripBtnCalcFreqLettersClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(activeTxtBox.Text))
                OnCalcFrequenceLetter(new FrequencyEventArgs(activeTxtBox.Text));
        }

        public void SetFrequencyDataGrid(DataGridView data, FrequencyTypeTask freqTypeTask)
        {
            switch (freqTypeTask)
            {
                case FrequencyTypeTask.Letter:

                    data.Parent = dataGridViewFreqLetter.Parent;
                    data.Name = dataGridViewFreqLetter.Name;
                    data.Parent.Controls.Remove(dataGridViewFreqLetter);
                    dataGridViewFreqLetter = data;
                    dataGridViewFreqLetter.Parent.Controls.Add(dataGridViewFreqLetter);
                    //dataGridViewFreqLetter = data;
                    //dataGridViewFreqLetter.Parent.Controls.Add(dataGridViewFreqLetter);
                    break;
                case FrequencyTypeTask.PairLetter:
                    data.Parent = dataGridViewFreqPairLetter.Parent;
                    data.Name = dataGridViewFreqPairLetter.Name;
                    data.Parent.Controls.Remove(dataGridViewFreqPairLetter);
                    dataGridViewFreqPairLetter = data;
                    dataGridViewFreqPairLetter.Parent.Controls.Add(dataGridViewFreqPairLetter);
                    break;
            }
        }
    }
}
