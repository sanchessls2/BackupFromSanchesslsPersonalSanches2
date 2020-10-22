using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglishWords
{
    public partial class ProgressBarD : Form
    {
        public ProgressBarD()
        {
            InitializeComponent();
        }

        internal void IniciaStatus(int pInicial, int pTotal)
        {
            progressBar1.Maximum = pTotal;
            progressBar1.Value = pInicial;
            Application.DoEvents();
        }
    }

    public static class ExibeProgresso 
    {
        private static LearnEnglishWords.ProgressBarD formulario;

        public static void iniciaStatus(int pInicial, int pTotal) 
        {
            formulario = null;

            Instancia().IniciaStatus(pInicial,pTotal);
            Instancia().Show();
        }

        private static ProgressBarD Instancia()
        {
            if (formulario == null) 
            {
                formulario = new ProgressBarD();
            }

            return formulario;
        }

        public static void atualizaStatus(int pInicial, int pTotal)
        {
            Instancia().IniciaStatus(pInicial, pTotal);
        }
    }
}
