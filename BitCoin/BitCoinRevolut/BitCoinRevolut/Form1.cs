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

            string valor1 = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            string valor2 = Newtonsoft.Json.JsonConvert.SerializeObject(model2);

            OperationsModel objreturn = BitCoinCalculator.Calculate(model);
            OperationsModel objreturn2 = BitCoinCalculator.Calculate(model2);


            OperationsModel objreturn3 = BitCoinCalculator.Calculate(new List<OperationsModel>(){ model, model2 } );


            if (checkBox1.Checked)
            {
                richTextBox1.Text = "";
            }

            if (checkBox3.Checked)
            {
                AdicionaTexto(richTextBox1, objreturn3.TextResultTotalResumo(2));
            }
            else
            {
                AdicionaTexto(richTextBox1, objreturn.TextResult());
                AdicionaTexto(richTextBox1, objreturn2.TextResult());
                AdicionaTexto(richTextBox1, objreturn3.TextResultTotal(2));

            }

            HighlightPhrase(richTextBox1, "<", ">",  Color.Red);
            HighlightPhrase(richTextBox1, "(", ")", Color.Green);
            HighlightPhrase(richTextBox1, "[", "]", Color.Blue);

            richTextBox1.Rtf = richTextBox1.Rtf.Replace("<","");
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("(", "");
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("[", "");
            richTextBox1.Rtf = richTextBox1.Rtf.Replace(">", "");
            richTextBox1.Rtf = richTextBox1.Rtf.Replace(")", "");
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("]", "");

        }

        private void AdicionaTexto(RichTextBox richTextBox1, string v)
        {
            string antigo = richTextBox1.Text;
            richTextBox1.Text = v;
            richTextBox1.Text = richTextBox1.Text + antigo;
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

        static void HighlightPhrase(RichTextBox box, string StartTag, string EndTag, Color color1)
        {
            int pos = box.SelectionStart;
            string s = box.Text;
            for (int ix = 0; ;)
            {
                int jx = s.IndexOf(StartTag, ix, StringComparison.CurrentCultureIgnoreCase);
                if (jx < 0) break;
                int ex = s.IndexOf(EndTag, ix, StringComparison.CurrentCultureIgnoreCase);
                box.SelectionStart = jx;
                box.SelectionLength = ex - jx + 1;
                box.SelectionColor = Color.Black;
                box.SelectionBackColor = color1;
                box.SelectionFont = new Font(box.Font, FontStyle.Bold);

                //box.SelectionStart = jx;
                //box.SelectionLength =  1;
                //box.SelectedText = "";

                //box.SelectionStart = ex-1;
                //box.SelectionLength = 1;
                //box.SelectedText = "";

                ix = ex + 1;
            }
            box.SelectionStart = pos;
            box.SelectionLength = 0;
        }


    }

}
