using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoronaGetData
{
    internal class ClassDados
    {
        public static objDados GetDados(string hTML)
        {
            objDados retorono = new objDados();            


            try
            {
                Regex newReg = new Regex("Vaccine Data up to.*COVID-19 14",RegexOptions.Singleline);

                var a = newReg.Match(hTML);

                if (a.Success)
                {
                    string text = a.Value;

                    string[] lines = text.Split(new[] { '\n' },StringSplitOptions.None);

                    retorono.datee = lines[1];
                    retorono.total1dose = lines[3];
                    retorono.total2dose = lines[5];
                    retorono.totalgeral = lines[7];

                    retorono.Success = true;


                }



                return retorono;
            }
            catch (Exception)
            {
                return new objDados() { Success = false};
            }


        }
    }
}