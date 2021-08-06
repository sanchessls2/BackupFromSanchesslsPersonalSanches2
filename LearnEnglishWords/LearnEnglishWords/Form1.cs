using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCoolForm;
using XCoolFormTest;

namespace LearnEnglishWords
{
    public partial class Form1 : XCoolForm.XCoolForm
    {
        private readonly XmlThemeLoader xtl = new XmlThemeLoader();
        private bool MusicaMais80 = false;
        public Form1()
        {
            InitializeComponent();
            
            xtl.ThemeForm = this;
            xtl.ApplyTheme(@"Themes\BlueWinterTheme.xml");

            typedWord.SelectionAlignment = HorizontalAlignment.Center;

         

            P_ESPERA_RESPOSTA();
            
    }

        private void Form1_Load(object sender, EventArgs e)
        {



            //string windowsTempPath = Path.GetTempPath();

            //var filePath = Path.Combine(windowsTempPath, "file_" + DateTime.Now.ToFileTimeUtc() + ".txt");

            //using (StreamWriter sr = new StreamWriter(filePath))
            //{
            //    sr.Write(String.Join(Environment.NewLine, Separador_de_palavras.Separar2()));
            //    sr.Flush();
            //    sr.Close();
            //}


            //Process.Start(filePath);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheGame.GetInstance().ClickPulou(typedWord.Text.Trim());
            P_ACERTOU_PALAVRA(); //improve latter
            typedWord.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MusicaMais80)
            {

                TheGame.GetInstance().ClickVerDescricao();
                richTextBox1.Text = TheGame.GetInstance().GetDescription();
                typedWord.Focus();
             }
            else
            {
                MessageBox.Show("Não mais disponivel devido nota alta!");
            }
}

        private void P_FIM_DO_JOGO()
        {
            List<String> WrongWords = new List<String>();

            TheGame.GetInstance().Report(false,0, WrongWords);

            HDatabase.GravaPalavrasErradas(WrongWords);


            foreach (TheGame.ListType item in Enum.GetValues(typeof(TheGame.ListType)))
            {
                Exam toRecord = TheGame.GetInstance().Report(true, item);

                if (toRecord != null)
                {
                    HDatabase.GravaRegistro(toRecord,item);
                }
            }

            

            string report = TheGame.GetInstance().GetReport();

            List<MemoryStream> ListaGraphs = Grafico.CriaLista(TheGame.GetInstance().GetTipo());
            

            Email.SendReport(report, ListaGraphs);

            button3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            richTextBox1.Enabled = false;
            //typedWord.Enabled = false;


            string windowsTempPath = Path.GetTempPath();

            var filePath = Path.Combine(windowsTempPath, "file_" + DateTime.Now.ToFileTimeUtc() + ".txt");

            using (StreamWriter sr = new StreamWriter(filePath))
            {
                sr.Write(report);
                sr.Flush();
                sr.Close();
            }
                
            Process.Start(filePath);
            //MessageBox.Show("Fim do jogo, Te amo.!");
            Thread.Sleep(1000);
            this.Close();

        }

        private void P_INCIALIZA_JOGO()
        {
            HDatabase.ExecutaScripts();

            TheGame.LimpaJogo();
            try
            {
                TheGame.GetInstance().Start();

                P_INICIA_PERGUNTA();

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
                this.Close();
            }
            
        }

        private void P_INICIA_PERGUNTA()
        {
            richTextBox1.Clear();
            typedWord.Clear();
            richTextBox1.Text = "Tente ouvindo o som, caso nao consiga, Leia a descricao usando o botao abaixo.";
            P_ATUALIZA_STATUS();

            if (checkBox1.Checked) 
            {
                p_ouvir();
            }
            typedWord.Focus();
        }

        private void P_ESPERA_RESPOSTA()
        {
            typedWord.TextChanged += P_TEXT_CHANGED;
        }

        private void P_TEXT_CHANGED(object sender, EventArgs e)
        {
            typedWord.Focus();
        }


        private void P_ATUALIZA_STATUS()
        {
            label3.Text = TheGame.GetInstance().GetTxtStatus();
            label6.Text = TheGame.GetInstance().GetPercentRight().ToString("0.00") + "%";
            LastWord.Text = "Ultima Palavra : " + TheGame.GetInstance().GetLastWord();
            Application.DoEvents();
        }

        private void P_ACERTOU_PALAVRA()
        {            
            TheGame.GetInstance().NextQuestion();
            P_INICIA_PERGUNTA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p_ouvir();
            typedWord.Focus();
            
        }

        private void p_ouvir()
        {
            try
            {
                if (TheGame.GetInstance().Status == TheGame.GameStatus.Started)
                {
                    panel1.Visible = true;
                    TheGame.GetInstance().AddClickOuvir();
                    Speaker.Speak(TheGame.GetInstance().GetRunningWordToSpeak(), Convert.ToInt32(numericUpDown1.Value));
                }
            }
            finally
            {

                panel1.Visible = false;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void typedWord_KeyDown(object sender, KeyEventArgs e)
        {
            


            if ((e.KeyCode == Keys.Return) && (typedWord.Text.Trim().Length > 0))
            {
                e.Handled = true;
                try
                {
                    typedWord.Enabled = false;

                    bool acertou = TheGame.GetInstance().CheckWord(typedWord.Text);

                    if (!acertou)
                    {
                        TheGame.GetInstance().AdicionaTentativa(typedWord.Text.Trim());
                        Speaker.Errou();
                     
                    }

                }
                finally
                {
                    typedWord.Enabled = true;
                }
                typedWord.Focus();


                if (typedWord.Text.Trim() != "")
                {

                    if (TheGame.GetInstance().HardModeOn) 
                    {                
                        Thread.Sleep(500);
                        TheGame.GetInstance().ClickPulou(typedWord.Text.Trim());
                        P_ACERTOU_PALAVRA();
                    }
                }
            }
            
            
            


        }

        private void typedWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void typedWord_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button3_MouseClick_1(object sender, MouseEventArgs e)
        {
            typedWord.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MusicaMais80)
            {
                try
                {
                    panel1.Visible = true;
                    richTextBox1.Text = Separador_de_palavras.Translate(TheGame.GetInstance().GetRunningWord());
                    typedWord.Focus();
                }
                finally
                {
                    panel1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Não mais disponivel devido nota alta!");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos Começar?");

            P_INCIALIZA_JOGO();

   


            this.MusicaMais80 = HDatabase.F_LiberaTraduzir(TheGame.GetInstance().GetTipo());


            TheGame.GetInstance().AcertouPalavra += P_ACERTOU_PALAVRA;
            TheGame.GetInstance().FimDoJogo += P_FIM_DO_JOGO;

            typedWord.Focus();
        }
    }
}








