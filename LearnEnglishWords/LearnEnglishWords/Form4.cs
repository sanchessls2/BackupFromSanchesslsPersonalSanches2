using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            var image = Grafico.GetGrafico();
            var image2 = Image.FromStream(image);
            pictureBox1.Image = image2;
           
        }

        private void chart2_Click(object sender, EventArgs e)
        {

            

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((new List<Keys>() { Keys.Enter,Keys.Return,Keys.Escape}).Contains(e.KeyCode)) 
            {
                this.Close();
            }
        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void chart2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
