using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BitCoinRevolut
{
    public class BitCoinCalculator
    {
        public static OperationsModel Calculate(OperationsModel model)
        {
            BitCoinModel btCalc = GetValue();

            model.ValuesToReturn = new Return();
            model.ValuesToReturn.ValorVenda = btCalc.EUR.Sell;
            //model.ValuesToReturn.ValorRevolut = model.ValuesToReturn.ValorVenda * model.PercentualRevolut / 100;

            return model;
        }

        private static BitCoinModel GetValue()
        {
            var uri = "https://blockchain.info/ticker";

            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            var data = client.DownloadString(uri);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<BitCoinModel>(data);

        }
    }
}
