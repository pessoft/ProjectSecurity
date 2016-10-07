using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Security.Helpers
{
    public static class FrequencyHelper
    {
        public static Chart ConverToChart(this IFrequency source, bool pairChar = false)
        {
            var result = new Chart();
            result.ChartAreas.Add(new ChartArea());
            result.Series.Add(new Series());

            result.Series[0].ChartType = SeriesChartType.Column;
            
           //result.ChartAreas[0].AxisX = new Axis();
            result.ChartAreas[0].AxisX.Minimum = 0;
            result.ChartAreas[0].AxisX.Interval = 1;
            result.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            result.ChartAreas[0].AxisX.LabelAutoFitMinFontSize = 9;
            result.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Horizontal;
            result.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont;

            Dictionary<string, double> src;
            if (pairChar)
            {
                src = source.GetPairLetterFreq();
            }
            else
            {
                src = source.GetLetterFreq();
                
            }

            int numb = 0;
            foreach (var let in src.OrderBy(p=>p.Key))
            {
                result.Series[0].Points.AddXY(++numb, let.Value);
                result.ChartAreas[0].AxisX.CustomLabels.Add(numb-2, numb+2, let.Key);
               
            }

            result.ChartAreas[0].CursorX.IsUserEnabled = true;
            result.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            result.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            result.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            
            return result;
        }

        public static DataGridView ConverToDataGridView(this IFrequency source, bool pairChar = false)
        {
            
            var nameCel1 = "Letters";
            var nameCel2 = "FreqLetters";
            var result = new DataGridView();
            result.Dock = DockStyle.Fill;
            result.Columns.Add(nameCel1, "Letters");
            result.Columns.Add(nameCel2, "Frequency letters");

            Dictionary<string, double> src;
            if (pairChar)
                src = source.GetPairLetterFreq();
            else
                src = source.GetLetterFreq();

            foreach (var let in src.OrderBy(p => p.Key))
            {
               int i =  result.Rows.Add();
               result.Rows[i].Cells[0].Value = let.Key;
               result.Rows[i].Cells[1].Value = Math.Round(let.Value,4);
            }


            result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            result.RowHeadersVisible = false;


            return result;
        }

    }
}
