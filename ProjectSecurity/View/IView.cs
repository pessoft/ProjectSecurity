using System;
using View.EventArguments;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace View
{
    public interface IView
    {
        event EventHandler<EncodDecodEventArgs> EncodDecodClick;
        event EventHandler<SavingTextEventArgs> SavingTextForFile;
        event EventHandler<OpenFileTextEventArgs> OpenTextFromFile;
        event EventHandler<FrequencyEventArgs> CalcFrequenceLetter;
        void SetOutText(string text);
        void SetInText(string text);
        void SetFrequencyChart(Chart chart, FrequencyTypeTask freqTypeTask);
        void SetFrequencyDataGrid(DataGridView data, FrequencyTypeTask freqTypeTask);
    }

    public interface ISetting
    {
        event EventHandler<ApplySettingEventArgs> ApplySetting;
        DialogResult ShowDialog();
    }
}
