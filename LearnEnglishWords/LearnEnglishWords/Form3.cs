using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCoolFormTest;

namespace LearnEnglishWords
{
    public partial class Form3 : XCoolForm.XCoolForm
    {
        public string RelatorioProva = "";
        TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        private XmlThemeLoader xtl = new XmlThemeLoader();
        public Form3()
        {
            InitializeComponent();

            xtl.ThemeForm = this;
            xtl.ApplyTheme(@"Themes\BlueWinterTheme.xml");

            P_CARREGA_TELA();

        }

        private void P_CARREGA_TELA()
        {

            List<string> musica = WordDatabase.GetMusic(Form2.ProvaEscolhida);
            
            //tableLayoutPanel1.BackColor = Color.Red;
            int horScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tableLayoutPanel1.Width = this.Width - horScrollWidth;
            tableLayoutPanel1.Height = this.Height - 80;

            Font fonteEscolhida = new Font("Microsoft Sans Serif", 10,FontStyle.Bold);
            Font fonteEscolhidatxt = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);            

            var margemescolhida = new Padding(5);

            Controls.Add(tableLayoutPanel1);

            int count = 0;
            foreach (var item in musica)
            {
                tableLayoutPanel1.RowCount++;


                Label lblTitle = new Label
                {
                    Name = "Labeln" + count.ToString(),
                    AutoSize = false,
                    Width = tableLayoutPanel1.Width - 30,
                    Height = 25,
                    Text = item,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = fonteEscolhida,
                    Margin = margemescolhida
                };

                tableLayoutPanel1.Controls.Add(lblTitle, 0, count);

                count++;

                TextBox txtValue = new TextBox
                {
                    Name = "TextBoxn" + count.ToString(),
                    AutoSize = false,
                    Width = tableLayoutPanel1.Width - 30,
                    Height = 25,
                    TextAlign = HorizontalAlignment.Center,
                    Font = fonteEscolhidatxt,
                    ForeColor = Color.Red,
                    Margin = margemescolhida

                };

                tableLayoutPanel1.Controls.Add(txtValue, 0, count);
                count++;
            }
            tableLayoutPanel1.AutoScroll = true;
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;

            tableLayoutPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);


            P_ADD_RELATORIO("Iniciando Prova");
            P_ADD_RELATORIO("Tipo : " + Form2.ProvaEscolhida.ToString());
            P_ADD_RELATORIO("Data : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email.SendProva(f_report());
            MessageBox.Show("Aguarde correção pelo email. Parabens!");
            this.Close();
        }

        public string f_report()
        {
            P_ADD_RELATORIO("FIM PROVA");
            P_ADD_RELATORIO("Data : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            P_ADD_RELATORIO("");
            
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(Label)) 
                {
                    P_ADD_RELATORIO("Frase:    "+((Label)item).Text );
                }

                if (item.GetType() == typeof(TextBox))
                {
                    P_ADD_RELATORIO("Resposta: "+((TextBox)item).Text);
                    P_ADD_RELATORIO("Correção: ");
                    P_ADD_RELATORIO("");
                    P_ADD_RELATORIO("***************************************************************************************************");
                }
                

            }

            return RelatorioProva;

        }

        private void P_ADD_RELATORIO(string v)
        {
            RelatorioProva += v + Environment.NewLine;
        }
    }
}
