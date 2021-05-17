using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using CefSharp;
using LibGit2Sharp;

namespace CoronaGetData
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        CefSharp.WinForms.ChromiumWebBrowser browser = null;
        string lastDateFound = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            lastDateFound = "";

     

        }

        public void p_atualiza()
        {
            Console.WriteLine("p_atualiza " + DateTime.Now);

            browser = new CefSharp.WinForms.ChromiumWebBrowser("https://www.etoro.com/people/sanchessls/portfolio")
            {
                Dock = DockStyle.Fill,
            };

            this.Controls.Add(browser);
            
        }

        public void garimpaDados()
        {
            Console.WriteLine("garimpaDados " + DateTime.Now);
            try
            {
                string HTML = browser.GetMainFrame().GetTextAsync().Result;

                objDados dados = ClassDados.GetDados(HTML);

                if (dados.Success)
                {
                    ClassGit.Adiciona(dados);

                    TimerGarimpa.Interval = 1000 * 60 * 20 ;
                }

                

            }
            catch (Exception abc)
            {
                TimerGarimpa.Interval = 60000;
            }
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            garimpaDados();
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            p_atualiza();
            AtualizaSite.Interval = 1000 * 60 * 60; // 1hour
            garimpaDados();


        }
    }
}
