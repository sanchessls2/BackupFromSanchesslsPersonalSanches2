using FirstMachineLearningML.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureData
{
    public partial class Form1 : Form
    {
        DateTime[] times = new DateTime[9];
        float[] values = new float[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                times[textBox1.Text.Length - 1] = DateTime.Now;
            }

            if (textBox1.Text.Length == 9)
            {
                SetaOutput();
                textBox1.Clear();
            }
        }

        private void SetaOutput()
        {
            if (textBox2.TextLength > 0)
            {
                textBox2.Text += Environment.NewLine;
            }
            for (int i = 0; i < times.Length - 1; i++)
            {
                TimeSpan diffMilisec = times[i + 1] - times[i];
                textBox2.Text += diffMilisec.TotalMilliseconds + ",";
                values[i] = Convert.ToSingle(diffMilisec.TotalMilliseconds);
            }
            textBox2.Text += false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelInput sampleData = new ModelInput()
            {
                Col0 = values[0],
                Col1 = values[1],
                Col2 = values[2],
                Col3 = values[3],
                Col4 = values[4],
                Col5 = values[5],
                Col6 = values[6],
                Col7 = values[7]
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            if (predictionResult.Prediction =="1")
            {
                MessageBox.Show("Andre Sanches " + predictionResult.Score[0]);
            }
            else
            {
                MessageBox.Show("Nao Identificado" + predictionResult.Score[1]);
            }

            //List<string> returnTxt = new List<string>();

            //returnTxt.Add("Using model to make single prediction -- Comparing actual Col8 with predicted Col8 from sample data...\n\n");
            //returnTxt.Add($"Col0: {sampleData.Col0}");
            //returnTxt.Add($"Col1: {sampleData.Col1}");
            //returnTxt.Add($"Col2: {sampleData.Col2}");
            //returnTxt.Add($"Col3: {sampleData.Col3}");
            //returnTxt.Add($"Col4: {sampleData.Col4}");
            //returnTxt.Add($"Col5: {sampleData.Col5}");
            //returnTxt.Add($"Col6: {sampleData.Col6}");
            //returnTxt.Add($"Col7: {sampleData.Col7}");
            //returnTxt.Add($"\n\nPredicted Col8 value {predictionResult.Prediction} \nPredicted Col8 scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            //returnTxt.Add("=============== End of process, hit any key to finish ===============");
            //MessageBox.Show(String.Join(Environment.NewLine, returnTxt));
        }
    }
}
