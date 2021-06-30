using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace LearnEnglishWords
{
    public static class Grafico
    {
        public static MemoryStream GetGrafico()
        {
            List<Series> series = getSeries();

            return GetGraficoFinal(series);
        }

        public static MemoryStream GetGrafico(TheGame.ListType listType)
        {
            List<Series> series = getSeries(listType);

            return GetGraficoFinal(series);
        }

        private static List<Series> getSeries(TheGame.ListType listType)
        {
            var objs = HDatabase.RetornaTodosTypo(listType);

            return getSeriesFinal(objs);
        }

        private static MemoryStream GetGraficoFinal(List<Series> series)
        {

            Chart chart2 = new Chart();
      
            chart2.ChartAreas.Add(new ChartArea());
            chart2.Legends.Add(new Legend());
            chart2.Series.Clear();
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.ChartAreas[0].AxisY.Minimum = 70;
            chart2.ChartAreas[0].AxisX.Minimum = 1;
            chart2.ChartAreas[0].AxisY.Interval = 10;

            foreach (Series item in series)
            {
                chart2.Series.Add(item);
            }

            MemoryStream ms = new MemoryStream();
            chart2.Width = 1800;
            chart2.Height = 1200;
            chart2.SaveImage(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ms.Position = 0;
            return ms;
        }

        public static List<Series> getSeries()
        {
            var objs = HDatabase.RetornaTodos();

            return getSeriesFinal(objs);          
        }

        private static List<Series> getSeriesFinal(List<Tuple<List<Exam>, string>> objs)
        {
            List<Series> retorno = new List<Series>();

            foreach (var item in objs)
            {
                var series = new Series(item.Item2);

                var objLinha = item.Item1.Select(x => x.Percentage).ToList();

                List<int> colList = new List<int>();
                for (int i = 1; i <= objLinha.Count; i++)
                {
                    colList.Add(i);
                }


                Double[] lin = objLinha.ToArray();
                int[] col = colList.ToArray();

                series.IsVisibleInLegend = true;
                series.BorderWidth = 4;
                series.Points.DataBindXY(col, lin);
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.Int32;
                series.YValueType = ChartValueType.Double;
                series.Points[col.Length - 1].Label = string.Format("{0:n2}%", lin.Last());
                if (lin.Last() >= 90)
                {
                    series.Points[col.Length - 1].LabelBackColor = Color.LightGreen;
                }
                series.SmartLabelStyle.Enabled = true;
                retorno.Add(series);

            }


            return retorno;
        }

        internal static List<MemoryStream> CriaLista(TheGame.ListType listType)
        {
            var GraficoGeral = GetGrafico();
            var GraficoEspecifico = GetGrafico(listType);

            return new List<MemoryStream>() { GraficoGeral, GraficoEspecifico };




        }
    }
}
