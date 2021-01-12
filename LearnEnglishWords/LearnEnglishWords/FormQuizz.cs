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
    public partial class FormQuizz : XCoolForm.XCoolForm
    {
        public static string Lockado = "";
        private XmlThemeLoader xtl = new XmlThemeLoader();
        public FormQuizz()
        {
            InitializeComponent();
            
            xtl.ThemeForm = this;
            xtl.ApplyTheme(@"Themes\BlueWinterTheme.xml");

            P_ESPERA_RESPOSTA();
            
    }

        private void FormQuizz_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void P_FIM_DO_JOGO()
        {
            TheGameMP.GetInstance().Report();

            string report = TheGameMP.GetInstance().GetReport();
            Email.SendReport(report,new List<MemoryStream>());

            button3.Enabled = false;


            string windowsTempPath = Path.GetTempPath();

            var filePath = Path.Combine(windowsTempPath, "file_" + DateTime.Now.ToFileTimeUtc() + ".txt");

            using (StreamWriter sr = new StreamWriter(filePath))
            {
                sr.Write(report);
                sr.Flush();
                sr.Close();
            }
                
            Process.Start(filePath);
            MessageBox.Show("Fim do jogo, Te amo.!");
            Thread.Sleep(1000);
            this.Close();

        }

        private void P_INCIALIZA_JOGO()
        {
            TheGameMP.LimpaJogo();
            TheGameMP.GetInstance().Start();

            P_INICIA_PERGUNTA();
        }

        private void P_INICIA_PERGUNTA()
        {
            P_ATUALIZA_OPCOES();
            
            P_ATUALIZA_STATUS();

            if (checkBox1.Checked) 
            {
                p_ouvir();
            }
        }

        private void P_ATUALIZA_OPCOES()
        {
            Word1.Text = TheGameMP.GetInstance().GetRunningWord().TheWord;
            Word2.Text = TheGameMP.GetInstance().GetRunningWord().TheWord2;
        }

        private void P_ESPERA_RESPOSTA()
        {
        }

        private void P_TEXT_CHANGED(object sender, EventArgs e)
        {
        }


        private void P_ATUALIZA_STATUS()
        {
            label3.Text = TheGameMP.GetInstance().GetTxtStatus();
            label6.Text = TheGameMP.GetInstance().GetPercentRight().ToString("0.00") + "%";
            LastWord.Text = "Ultima Palavra : " + TheGameMP.GetInstance().GetLastWord();
            Application.DoEvents();
        }

        private void P_ACERTOU_PALAVRA()
        {
            Console.WriteLine("0002   - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            TheGameMP.GetInstance().NextQuestion();
            P_INICIA_PERGUNTA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (INLOCK()) { return; }
            P_LOCK();
            try
            {
                p_ouvir();
            }
            finally
            {
                P_UNLOCK();

            }
        }

        private void p_ouvir()
        {
           if (TheGameMP.GetInstance().Status == TheGameMP.GameStatus.Started)
           {
               Speaker.Speak(TheGameMP.GetInstance().GetRunningWordToSpeak(), Convert.ToInt32(numericUpDown1.Value));
                Thread.Sleep(1000);
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

        }

        private void typedWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void typedWord_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button3_MouseClick_1(object sender, MouseEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void FormQuizz_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos Começar?");

            P_INCIALIZA_JOGO();

            TheGameMP.GetInstance().AcertouPalavra += P_ACERTOU_PALAVRA;
            TheGameMP.GetInstance().FimDoJogo += P_FIM_DO_JOGO;

        }

        private void Word1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("0001   - "  + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


            if (INLOCK()) { return; }
            P_LOCK();

            try
            {
                TheGameMP.GetInstance().CheckWord(((Button)sender).Text);
            }
            finally
            {
                P_UNLOCK();              
            }
        }

        private void P_LOCK()
        {
            Lockado = "SIM";
            Word1.Enabled = false;
            Word2.Enabled = false;
            button3.Enabled = false;
            Application.DoEvents();
            Thread.Sleep(1);
            Application.DoEvents();
        }

        private void P_UNLOCK()
        {
            Word1.Enabled = true;
            Word2.Enabled = true;
            button3.Enabled = true;
            Lockado = "";
        }

        private void Word2_Click(object sender, EventArgs e)
        {
            if (INLOCK()) { return; }
            P_LOCK();
            try
            {
                TheGameMP.GetInstance().CheckWord(((Button)sender).Text);
            }
            finally
            {
                P_UNLOCK();

            }
        }

        private bool INLOCK()
        {
            return Lockado != "";
        }
    }
}








