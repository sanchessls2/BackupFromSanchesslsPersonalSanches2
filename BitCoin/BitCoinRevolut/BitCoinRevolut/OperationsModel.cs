﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoinRevolut
{
    public class OperationsModel
    {
        public static string moneyFormat = "0.00€";
        public static string PercentualFormat = "0.000%";
        public double BitCoinsComprado { get; set; }
        public double ValorComprado {get;set;}
        public double PercentualRevolut { get; set; }
        public Return ValuesToReturn { get; set; }

        internal string TextResult()
        {
            List<string> toReturn = new List<string>();

            toReturn.Add("*********************" + DateTime.Now.ToString() + "***********************");
            toReturn.Add("Valor Comprado    : " + this.ValorComprado.ToString(moneyFormat));
            toReturn.Add("Bit Coins Total   : " + this.BitCoinsComprado.ToString());
            toReturn.Add("Percentual Revolut: " + (this.PercentualRevolut/100).ToString(PercentualFormat));
            toReturn.Add("Valor Atual       :" + this.ValuesToReturn.ValorVenda.ToString(moneyFormat));

            toReturn.Add("Valor Comprado    :" + this.ValorCompradoFinal().ToString(moneyFormat));
            toReturn.Add("Valor Venda       :" + this.ValorVendaFinal().ToString(moneyFormat));
            toReturn.Add("Valor Revolut     :" + this.ValorRevolut().ToString(moneyFormat));
            toReturn.Add("Valor Final       :" + this.ValorFinal().ToString(moneyFormat));
            toReturn.Add("Valor Diff        :" + this.ValorDiff().ToString(moneyFormat));
            toReturn.Add("Percentual Diff   :" + (this.PercentualDiff()/100).ToString(PercentualFormat));
            toReturn.Add("\n");

            return String.Join("\n",toReturn);


        }

        private double ValorRevolut()
        {
            return this.ValorVendaFinal() * this.PercentualRevolut / 100;
        }

        private double PercentualDiff()
        {
            var value = ((this.ValorFinal() / this.ValorComprado));
            var value2 = value - 1;
            return value2 *100;
        }

        private double ValorDiff()
        {
            return this.ValorFinal() - this.ValorComprado;
        }

        private double ValorFinal()
        {
            return this.ValorVendaFinal() - this.ValorRevolut();
        }

        private double ValorVendaFinal()
        {
            return this.BitCoinsComprado * this.ValuesToReturn.ValorVenda;
        }

        private double ValorCompradoFinal()
        {
            return this.ValorComprado / this.BitCoinsComprado;
        }
    }

    public class Return
    {
        public double ValorVenda { get; internal set; }
//        public double ValorRevolut { get; internal set; }


    }
}