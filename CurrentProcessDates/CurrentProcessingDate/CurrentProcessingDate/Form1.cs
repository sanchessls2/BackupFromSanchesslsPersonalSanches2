using LearnEnglishWords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentProcessingDate
{
    public partial class Form1 : Form
    {
        
        DateTime data1 = DateTime.MinValue;
        DateTime data2 = DateTime.MinValue;
        DateTime DiaDeHoje = DateTime.Now;
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            P_Executa();
        }

        private void P_Executa()
        {
            Tuple<DateTime, DateTime> novas = getNovasDatas();
            if (novas != null)
            {
                if (data1 != novas.Item1 || data2 != novas.Item2 || !MesmoDia())
                {
                    data1 = novas.Item1;
                    data2 = novas.Item2;
                    DiaDeHoje = DateTime.Now;

                    P_Envia_Email(data1,data2);
                }
            }
        }

        private bool MesmoDia()
        {
            string diaDeHoje = DiaDeHoje.Year +""+ DiaDeHoje.Month +""+ DiaDeHoje.Day;


            string diaDeHoje2 = DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day;

            return diaDeHoje == diaDeHoje2;


        }

        private void P_Envia_Email(DateTime data1, DateTime data2)
        {
            var dataFinal = new DateTime(2021,06,03);
            
            var diferencaDatas = data1 - data2; //Tempo entre elas

            var vIndice = 30 / diferencaDatas.TotalDays; // Taxa de analise diaria

            var DiasFaltandoNoGeral = dataFinal - data2;  //Do dia da aplicacao ate o dia q ta analizando hj

            var diasPraChegarNoMeu = DiasFaltandoNoGeral.TotalDays + (DiasFaltandoNoGeral.TotalDays * vIndice); //Dias a mais por que nao olha um por dia sacou?;

            var datafinal = DateTime.Now.AddDays(diasPraChegarNoMeu);


            var Cabecalho = @"Data Prevista @" + datafinal.ToShortDateString() + "Melhor :" + DateTime.Now.AddDays(DiasFaltandoNoGeral.TotalDays).ToShortDateString();

            var textoEmail = @"Atualizacao Visto : " + datafinal.ToShortDateString() + Environment.NewLine +
                              "Dias Faltando Sem Indice :  " + DiasFaltandoNoGeral.TotalDays + Environment.NewLine +
                              "Indice : " + vIndice.ToString("0.00") + Environment.NewLine +
                              "Melhor Data : " + DateTime.Now.AddDays(DiasFaltandoNoGeral.TotalDays).ToShortDateString();

            Email.SendReport(Cabecalho, textoEmail);
            label1.Text = "Ultima Vez atualizado : " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private Tuple<DateTime, DateTime> getNovasDatas()
        {
            try
            {
                using (WebClient web1 = new WebClient())
                {
                    string data = web1.DownloadString("https://enterprise.gov.ie/en/What-We-Do/Workplace-and-Skills/Employment-Permits/Current-Application-Processing-Dates/Current-Processing-Dates-for-Employment-Permits.html");
                    return GarimpaDados(data);

                }

            }
            catch (Exception)
            {

                return null;
            }

        }

        private Tuple<DateTime, DateTime> GarimpaDados(string data)
        {
            string result1 = "";
            string result2 = "";


            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            StreamReader r = new StreamReader(_filePath + "/mockresult.txt");
            var a = r.ReadToEnd();


            var from = "></p><p>As of";
            var to = "we are processing applications";

            var pos1 = a.IndexOf(from);

            if (pos1 < 0)            
            {
                return null;
            }

            var pos2 = a.IndexOf(to);

            if (pos2 < 0)
            {
                return null;
            }

            var data1 = a.Substring(pos1 , pos2 - pos1).Trim();

            result1 = GetdateFrom(data1);
                      
            var from2 = "Trusted Partner</td><td class=\"left\">";
            var to2 = "</td></tr><tr><td>Standard";


            var pos12 = a.IndexOf(from2);

            if (pos12 < 0)
            {
                return null;
            }

            var pos22 = a.IndexOf(to2);

            if (pos22 < 0)
            {
                return null;
            }

            var data2 = a.Substring(pos12, pos22 - pos12).Trim();

            result2 = GetdateFrom(data2);

            if (result1 != "" && result2 != "")
            {

                return new Tuple<DateTime, DateTime>(Convert.ToDateTime(result1), Convert.ToDateTime(result2));
            }

            return null;
        }

        private string GetdateFrom(string date1)
        {
            var regex = new Regex("[0-9]{1,2} [A-z]+ [0-9]{4}");
            return regex.Match(date1).Value;


        }
    }
}
