using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace Security.Helpers
{
    public static class FrequencyHelper
    {
        public static Chart ConverToChart(this IFrequency source)
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

            int numb = 0;
            foreach (var let in source.GetLetterFreq().OrderBy(p=>p.Key))
            {
                result.Series[0].Points.AddXY(++numb, let.Value);
                result.ChartAreas[0].AxisX.CustomLabels.Add(numb, numb+0.01, let.Key);
            }
            return result;
        }

    }
}
