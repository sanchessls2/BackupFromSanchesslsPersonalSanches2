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
                BitCoinsComprado = 0.00036898,
                BitCoinsFee = 0.00000959,
                PercentualRevolut = 2.5,
                ValorComprado = 15
            };

            OperationsModel model2 = new OperationsModel
            {
                BitCoinsComprado = 0.00287298,
                BitCoinsFee = 0.00007375,
                PercentualRevolut = 2.5,
                ValorComprado = 116.61
            };

            OperationsModel objreturn = BitCoinCalculator.Calculate(model);
            OperationsModel objreturn2 = BitCoinCalculator.Calculate(model2);


            OperationsModel objreturn3 = BitCoinCalculator.Calculate(new List<OperationsModel>(){ model, model2 } );


            if (checkBox1.Checked)
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = objreturn.TextResult() + richTextBox1.Text;
            richTextBox1.Text = objreturn2.TextResult() + richTextBox1.Text;
            richTextBox1.Text = objreturn3.TextResultTotal(2) + richTextBox1.Text;
        }

        private T List<T>()
        {
            throw new NotImplementedException();
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
