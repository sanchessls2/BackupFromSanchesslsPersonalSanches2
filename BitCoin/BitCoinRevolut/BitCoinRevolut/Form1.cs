using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinRevolut
{
    public partial class Form1 : Form
    {
        public static double LastOne = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void P_Carrega()
        {
            OperationsModel model = new OperationsModel
            {
                BitCoinsComprado = 0.00324196,
                PercentualRevolut = 2.5,
                ValorComprado = 131.61
            };

            var objreturn = BitCoinCalculator.Calculate(model);
            if (checkBox1.Checked)
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = objreturn.TextResult() + richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_Carrega();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                P_Carrega();
            }
        }
    }
}
