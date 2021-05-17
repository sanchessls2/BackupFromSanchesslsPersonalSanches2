using System;
using System.Collections.Generic;
using System.Linq;
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
                string OldItem = "";
                List<string> lines = new List<string>(hTML.Split(new[] { '\n' }, StringSplitOptions.None));

                foreach (var item in lines.Where(x => x.Trim() != ""))
                {                   
                 
                    
                    
                    if (OldItem == "Richard Stroud")
                    {
                        MessageBox.Show(item);
                    }

                    OldItem = item;
                }


                


                return retorono;
            }
            catch (Exception)
            {
                return new objDados() { Success = false };
            }


        }
    }
}