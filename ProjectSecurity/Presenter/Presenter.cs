using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using View.EventArguments;
using Security.Encryption;
using Security;
using Security.Helpers;
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
            view.EncodDecodClick += ViewButtonClick;
            view.OpenTextFromFile += ViewOpenTextFromFile;
            view.SavingTextForFile += ViewSavingTextForFile;
            view.CalcFrequenceLetter += ViewCalcFrequenceLetter;
        }

        private void ViewCalcFrequenceLetter(object sender, FrequencyEventArgs e)
        {
            IFrequency freq = securityManager.CalcFreq(e.SourceText);
            view.SetFrequencyChart(freq.ConverToChart(), FrequencyTypeTask.Letter);
            view.SetFrequencyDataGrid(freq.ConverToDataGridView(), FrequencyTypeTask.Letter);
            view.SetFrequencyChart(freq.ConverToChart(true), FrequencyTypeTask.PairLetter);
            view.SetFrequencyDataGrid(freq.ConverToDataGridView(true), FrequencyTypeTask.PairLetter);
        }

        private void ViewSavingTextForFile(object sender, SavingTextEventArgs e)
        {
            Task.Run(()=> 
            {
                fileManager.GetTextRW().Save(e.PathFile, e.Text);
            });
           
        }

        private void ViewOpenTextFromFile(object sender, OpenFileTextEventArgs e)
        {
            Task.Run(() =>
            {
                string text = fileManager.GetTextRW().Open(e.PathFile);
                view.SetInText(text);
            });
            
        }

        private void ViewButtonClick(object sender, EncodDecodEventArgs e)
        {
            IEncryption coder;

            switch (e.CoderType)
            {
                case Coder.PolybiusCoder:
                    coder = securityManager.PolybiusCoder(e.Key);
                    break;
                case Coder.VizhinerCoder:
                    coder = securityManager.VizhinerCoder(e.Key);
                    break;
                case Coder.PairedСipherCoder:
                    coder = securityManager.PairedСipher(e.Key);
                    break;
                default:
                    coder = securityManager.CeasarCoder(e.KeyOne, e.KeyTwo);
                    break;
            }

            Task.Run(() =>
            {
                ProcessText(e.ProcessType, coder, e.Text);
            });
            
        }

        private void ProcessText(EncryptionEnum processType, IEncryption coder, string text)
        {
            string result = string.Empty;
            switch (processType)
            {
                case EncryptionEnum.Encoding:
                    result = coder.Encoding(text);
                    break;
                case EncryptionEnum.Decoding:
                    result = coder.Decoding(text);
                    break;
            }

            view.SetOutText(result);
        }
    }
}
