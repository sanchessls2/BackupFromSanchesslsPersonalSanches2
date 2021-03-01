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

            return model;
        }


        internal static OperationsModel Calculate(List<OperationsModel> lists)
        {
            OperationsModel newReturn = new OperationsModel();

            BitCoinModel btCalc = GetValue();
            foreach (var item in lists)
            {
                item.ValuesToReturn = new Return();
                item.ValuesToReturn.ValorVenda = btCalc.EUR.Sell;



            }

            newReturn.BitCoinsComprado = lists.Sum(x => x.BitCoinsComprado);
            newReturn.BitCoinsFee = lists.Sum(x => x.BitCoinsFee);
            newReturn.ValorComprado = lists.Sum(x => x.ValorComprado);
            newReturn.ValuesToReturn = new Return() { ValorVenda = btCalc.EUR.Sell };
            newReturn.PercentualRevolut = lists[0].PercentualRevolut;

            return newReturn;

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
