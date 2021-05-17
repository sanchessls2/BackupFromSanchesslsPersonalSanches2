using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetLogAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int counter = 0;
            string line;

            // Read the file and display it line by line.  

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Sanches\PersonalSanches2\TargetLogAnalyzer\Target-192.168.4.84.log");

            //System.IO.StreamReader file =
                //new System.IO.StreamReader(@"C:\Sanches\PersonalSanches2\TargetLogAnalyzer\test.txt");





            string regex = @"/Scan-\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b/\[[0-9]+\]\[\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b\] <.+> A\(([^)]+)\).S\(([^)]+)\).P\(([^)]+)\)";
            Regex regexToSelect = new Regex(regex);

            string regex2 = @"/Scan-\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b/\[[0-9]+\]\[\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b\] <.+> A\(([^)]+)\).S\(([^)]+)\)";
            Regex regexToSelect2 = new Regex(regex2);

            //            string[] strings = Regex.Split(testing, Environment.NewLine);

            List<ScanEngine> TotalScans = new List<ScanEngine>();

            try
            {

                string itemAnterior = "";

                while ((line = file.ReadLine()) != null)
                {
                    if (line == "<?xml version=\"1.0\" encoding=\"utf-16\"?>")
                    {
                        var newScan = new ScanEngine();
                        TotalScans.Add(newScan);

                        itemAnterior = "";
                    }

                    var test = regexToSelect.Match(line);


                    if (test.Success)
                    {
                        TotalScans.Last().SimpleAddLine(test, itemAnterior);

                        itemAnterior = test.Value;
                    }
                    else
                    {
                        var test2 = regexToSelect2.Match(line);

                        if (test2.Success)
                        {
                            TotalScans.Last().SimpleAddLine(test2, itemAnterior, ".P(NOPROTOCOL)");

                            itemAnterior = test2.Value + ".P(NOPROTOCOL)";
                        }

                    }





                    counter++;
                }

            }
            catch (Exception abc)
            {

                MessageBox.Show("deu erro : " + abc.Message);

            }
            finally
            {
                file.Close();
            }


            richTextBox1.Clear();
            foreach (var item in TotalScans)
            {
                item.ExibeInRichText(richTextBox1);
            }
        }
    }
}
