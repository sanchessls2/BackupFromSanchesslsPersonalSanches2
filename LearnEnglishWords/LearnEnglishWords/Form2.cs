﻿using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using XCoolForm;
using XCoolFormTest;

namespace LearnEnglishWords
{
    public partial class Form2 : XCoolForm.XCoolForm
    {
        private XmlThemeLoader xtl = new XmlThemeLoader();
        public Form2()
        {
            InitializeComponent();

            AutoUpdater.Start(@"https://raw.githubusercontent.com/sanchessls2/PersonalSanches2/main/Atualizador.txt");

            this.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            xtl.ThemeForm = this;
            xtl.ApplyTheme(@"Themes\BlueWinterTheme.xml");
        }

        public static List<TheGame.ListType> ListaEscolhada;

        public static TheGame.Prova ProvaEscolhida = TheGame.Prova.Nenhuma;

        public static bool HardModeOnBool;

        private void Form2_Load(object sender, EventArgs e)
        {
            checkedListBox1.DataSource = Enum.GetValues(typeof(TheGame.ListType));

            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, true);
            //}


            comboBox1.DataSource = Enum.GetValues(typeof(TheGame.Prova));
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, true);
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // new add
            ListaEscolhada = new List<TheGame.ListType>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                ListaEscolhada.Add((TheGame.ListType)item);
            }
            Form2.HardModeOnBool = HardMode.Checked;

            this.Hide();
            Form1 form = new Form1();
            form.Text = this.Text;
            form.FormClosed += p_a;
            form.ShowDialog();




        }

        private void p_a(object sender, FormClosedEventArgs e)
        {
            this.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProvaEscolhida = (TheGame.Prova)comboBox1.SelectedItem;

            this.Hide();
            Form3 form = new Form3();
            form.Text = this.Text;
            form.FormClosed += p_a;
            form.ShowDialog();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            xtl.ApplyTheme(@"Themes\AdobeMediaPlayerTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\AlienTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\AnimalKingdomTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\BlackTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\BlueWinterTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\DarkSystemTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\MacOSTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\StandardWindowsTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\ValentineTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\VistaTheme.xml");
            Application.DoEvents();
            Thread.Sleep(5000);
            xtl.ApplyTheme(@"Themes\WhiteTheme.xml");
            Application.DoEvents();





        }

        internal static bool HardModeOn()
        {
            return HardModeOnBool;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormQuizz form = new FormQuizz
            {
                Text = this.Text
            };
            form.FormClosed += p_a;
            form.ShowDialog();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //    SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();

        //    Grammar dictationGrammar = new DictationGrammar();            
        //    try
        //    {
        //        recognizer.LoadGrammar(dictationGrammar);
        //        button3.Text = "Speak Now";
        //        recognizer.SetInputToDefaultAudioDevice();
        //        RecognitionResult result = recognizer.Recognize(new TimeSpan(0,0,0,5));
        //        richTextBox1.Text = result.Text;
        //    }
        //    catch (InvalidOperationException exception)
        //    {
        //        richTextBox1.Text = String.Format("Could not recognize input from default aduio device. Is a microphone or sound card available?\r\n{0} - {1}.", exception.Source, exception.Message);
        //    }
        //    finally
        //    {
        //        recognizer.UnloadAllGrammars();
        //    }

        //}

    }
}