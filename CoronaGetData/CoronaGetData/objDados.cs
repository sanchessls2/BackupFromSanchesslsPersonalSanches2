using System;

namespace CoronaGetData
{
    public class objDados
    {
        public string datee;
        internal string total1dose;
        internal string total2dose;
        internal string totalgeral;

        public bool Success { get; internal set; }

        internal string LinhaNova()
        {

            DateTime datanova = Convert.ToDateTime(this.datee);            

            return @" myList.push(JSON.parse('{""location"":""Ireland"",""date"":"""+ datanova.ToString("yyyy-MM-dd") + @""",""vaccine"":"""",""source_url"":"""",""total_vaccinations"":"+ Convert.ToDouble(totalgeral).ToString("0") + @",""people_vaccinated"":" + Convert.ToDouble(total1dose).ToString("0") + @",""people_fully_vaccinated"":" + Convert.ToDouble(total2dose).ToString("0") + "}'));	 ";
        }
    }
}