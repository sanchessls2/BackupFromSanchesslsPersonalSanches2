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
using XCoolFormTest;

namespace LearnEnglishWords
{
    public partial class Form4 : XCoolForm.XCoolForm
    {
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        private XmlThemeLoader xtl = new XmlThemeLoader();
        public Form4()
        {
            InitializeComponent();

            xtl.ThemeForm = this;
            xtl.ApplyTheme(@"Themes\BlueWinterTheme.xml");

            P_MONTA_GRAFICO();
           
        }

        private void P_MONTA_GRAFICO()
        {
            chart2.Series.Clear();
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Minimum = 1;
            chart2.ChartAreas[0].AxisY.Interval = 10;
            List<Series> series = getSeries();
            foreach (Series item in series)
            {
                chart2.Series.Add(item);
            }

        }

        private void chart2_Click(object sender, EventArgs e)
        {

            

        }

        private List<Series> getSeries()
        {
            List<Series> retorno = new List<Series>();

            var objs = HDatabase.RetornaTodos();

            //int maxCols = GetMaxCols(objs);
            //if (maxCols < 10)
            //{
            //    maxCols = 10;
            //}
      

            //


            foreach (var item in objs)
            {
         


                var series = new Series(item.Item2);

                var objLinha = item.Item1.Select(x => x.Percentage).ToList();

                List<int> colList = new List<int>();
                for (int i = 1; i <= objLinha.Count; i++)
                {
                    colList.Add(i);
                }

                //var restantes = maxCols - objLinha.Count();

                //for (int i = 0; i < restantes; i++)
                //{
                //    objLinha.Add(0);
                //}

                Double[] lin = objLinha.ToArray();
                int[] col = colList.ToArray();

                

                series.BorderWidth = 4;
                series.Points.DataBindXY(col, lin);
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.Int32;
                series.YValueType = ChartValueType.Double;
                series.Points[col.Length-1].Label = string.Format("{0:n2}%",lin.Last());
                if (lin.Last() >= 90)
                {
                    series.Points[col.Length - 1].LabelBackColor = Color.LightGreen;
                }
                series.SmartLabelStyle.Enabled = true;
                retorno.Add(series);

            }


            return retorno;

        }

        private int GetMaxCols(List<Tuple<List<Exam>, string>> objs)
        {
            int maior = 0;

            foreach (var item in objs)
            {
                if (maior < item.Item1.Count())
                {
                    maior = item.Item1.Count();
                }
            }

            return maior;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
