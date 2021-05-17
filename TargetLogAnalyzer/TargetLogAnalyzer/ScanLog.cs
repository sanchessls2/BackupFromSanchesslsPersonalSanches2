using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetLogAnalyzer
{
    public class ScanEngine
    {
        public List<Stage> Stages { get; set; }

        public ScanEngine()
        {
            Stages = new List<Stage>();
        }

        internal void SimpleAddLine(Match item2,string itemAnterior,string addend = "")
        {
            bool forcaNewStrat = false;
            Identificator MatchAtual = GetIdentificator(item2.Value+addend);

            if (itemAnterior != "")
            {
                Identificator MatchAnterior = GetIdentificator(itemAnterior);

                if (MatchAtual.stageName != MatchAnterior.stageName)                
                {
                    this.AtualizaTempoStage(MatchAnterior.stageName, Convert.ToInt32(MatchAtual.time)/*Time Atual*/);
                }
                               
                if (MatchAtual.UniqueId() != MatchAnterior.UniqueId())
                {
                    this.AtualizaTempo(MatchAnterior.UniqueId(), Convert.ToInt32(MatchAtual.time)/*Time Atual*/);
                    forcaNewStrat = true;
                }


            }


            this.AddNewIfNeeded(MatchAtual, forcaNewStrat);
        }

        private Identificator GetIdentificator(string value)
        {
            string stageName = F_STAGE_NAME(value);
            string adapterName = F_ADAPTER_NAME(value);
            string strategyName = F_STRATEGY_NAME(value);
            string protocolName = F_PROTOCOL_NAME(value);
            string time = F_TIME(value);

            return new Identificator(stageName,adapterName,strategyName,protocolName,time);

        }

        private void AtualizaTempo(string uniqueID,int v)
        {
            var atualizarStrategy = this.Stages
                                .SelectMany(x => x.AdapterList)
                                .SelectMany(x => x.StrategyList)
                                .Where(b => b.UniqueId == uniqueID);
            atualizarStrategy.LastOrDefault().Finished = v;

            var atualizarAdaptor = this.Stages.SelectMany(x => x.AdapterList).Where(x => x.UniqueId == uniqueID);
            atualizarAdaptor.LastOrDefault().Finished = v;

            var atualizarProtocol = this.Stages.SelectMany(x => x.AdapterList)
                                               .SelectMany(x => x.StrategyList)
                                               .SelectMany(x => x.ProtocolList)
                                               .Where(x => x.UniqueId == uniqueID);
            atualizarProtocol.LastOrDefault().Finished = v;

        }


        private void AtualizaTempoStage(string stageNameANT, int v)
        {
            var atualizar = this.Stages.Where(x => x.Name == stageNameANT);

            atualizar.FirstOrDefault().Finished = v;
        }
    

        private string F_TIME(string value)
        {
            //\[[0-9]+\]
            string started1 = Regex.Match(value, @"\[[0-9]+\]").Value;
            started1 = started1.Substring(1, started1.Length - 2);
            return started1;
        }

        private string F_PROTOCOL_NAME(string value)
        {

            string protocol1 = Regex.Match(value, @"P\(([^)]+)\)").Value;
            protocol1 = protocol1.Substring(2, protocol1.Length - 3);
            return protocol1;
        }

        private string F_STRATEGY_NAME(string value)
        {

            string strat1 = Regex.Match(value, @"S\(([^)]+)\)").Value;
            strat1 = strat1.Substring(2, strat1.Length - 3);
            return strat1;
        }

        private string F_ADAPTER_NAME(string value)
        {
            string adapter1 = Regex.Match(value, @"A\(([^)]+)\)").Value;
            adapter1 = adapter1.Substring(2, adapter1.Length - 3);
            return adapter1;
        }

        private string F_STAGE_NAME(string valueStr)
        {
            string stage1 = Regex.Match(valueStr, "<.+>").Value;
            stage1 = stage1.Substring(1, stage1.Length - 2);
            return stage1;
        }

        private void AddNewIfNeeded(Identificator newIdentificator,bool forcastrat)
        {

            var stage = this.Stages.Where(x => x.Name == newIdentificator.stageName).LastOrDefault();

            if (stage == null)
            {
                stage = new Stage(newIdentificator.stageName, newIdentificator.timeInt());
                this.Stages.Add(stage);
            }
            else
            {
                stage.UpdateTime(newIdentificator.timeInt());
            }
            //Adapter

            var adapter = stage.AdapterList.Where(x => (x.Name == newIdentificator.adapterName) && (x.UniqueId == newIdentificator.UniqueId()));
            
            var strat = adapter.LastOrDefault();

            if (strat == null || forcastrat)
            {
                strat = new Adapter(newIdentificator.adapterName, newIdentificator.UniqueId(), newIdentificator.timeInt());
                stage.AdapterList.Add(strat);
            }
            else
            {
                strat.UpdateTime(newIdentificator.timeInt());
            }

            //strategy

            var strategy = strat.StrategyList.Where(x => (x.Name == newIdentificator.strategyName) && (x.UniqueId == newIdentificator.UniqueId())).LastOrDefault();

            if (strategy == null)
            {
                strategy = new Strategy(newIdentificator.strategyName, newIdentificator.UniqueId(), newIdentificator.timeInt());
                strat.StrategyList.Add(strategy);
            }
            else
            {
                strategy.UpdateTime(newIdentificator.timeInt());
            }
            //Protocol

            var protocol = strategy.ProtocolList.Where(x => (x.Name == newIdentificator.protocolName) && (x.UniqueId == newIdentificator.UniqueId())).LastOrDefault();

            if (protocol == null)
            {
                protocol = new Protocol(newIdentificator.protocolName, newIdentificator.UniqueId(), newIdentificator.timeInt());
                strategy.ProtocolList.Add(protocol);
            }
            else
            {
                protocol.UpdateTime(newIdentificator.timeInt());
            }

        }
        public class Stage
        {
            public Stage()
            {
                this.AdapterList = new List<Adapter>();
            }
            public Stage(string stageName,int started) : this()
            {
                this.Name = stageName;
                this.Started = started;
                this.Finished = started;
                this.Qntd = 1;
            }

            public string Name { get; set; }
            public int Started { get; private set; }
            public int Finished { get; set; }
            public int Qntd { get; private set; }
            public List<Adapter> AdapterList { get; set; }

            internal void UpdateTime(int started)
            {                
                Finished = started;
                Qntd += 1;
            }

            internal string ReportLine()
            {
                return "Stage: " + this.Name + "  " + SecondsToCompleteText(this.Duration(), this.Qntd);
            }

            internal int Duration()
            {
                return this.Finished - this.Started;
            }
        }
        public class Adapter
        {
            public Adapter(string UniqueId)
            {
                this.StrategyList = new List<Strategy>();
                this.UniqueId = UniqueId;
            }
            public Adapter(string adapterName,string UniqueId, int started) : this(UniqueId)
            {                
                this.Name = adapterName;
                this.Started = started;
                this.Finished = started;
                this.Qntd = 1;
            }

            public string Name { get; set; }
            public int Started { get; private set; }
            public List<Strategy> StrategyList { get; set; }
            public string UniqueId { get; }
            public int Finished { get; set; }
            public int Qntd { get; private set; }

            internal string ReportLine()
            {
                return "Adapter: " + this.Name + "  " + SecondsToCompleteText(this.TotalTime(), this.Qntd);
            }

            internal void UpdateTime(int started)
            {
                this.Finished = started;
                Qntd += 1;
            }

            private int TotalTime()
            {
                var total = this.Finished - this.Started;
                return total;
            }

            internal int Duration()
            {
                return this.Finished - this.Started;
            }
        }

        public class Strategy
        {
            public Strategy(string UniqueId)
            {
                this.ProtocolList = new List<Protocol>();
                this.UniqueId = UniqueId;
            }
            public Strategy(string strategyName,string UniqueId, int started) : this(UniqueId)
            {
                this.Name = strategyName;
                this.Started = started;
                this.Finished = started;
                this.Qntd = 1;
            }

            public string Name { get; set; }
            public int Started { get; private set; }
            public List<Protocol> ProtocolList { get; set; }
            public string UniqueId { get; }
            public int Finished { get; set; }
            public int Qntd { get; private set; }

            internal string ReportLine()
            {
                return "Strategy: " + this.Name + "  " + SecondsToCompleteText(this.TotalTime(), this.Qntd) + " " + this.UniqueId +" " + this.Started + " " + this.Finished ;
            }

            internal void UpdateTime(int started)
            {
                this.Finished = started;
                Qntd += 1;
            }

            private int TotalTime()
            {                
                return Duration();
            }

            internal int Duration()
            {
                return this.Finished - this.Started;
            }
        }

        public class Protocol
        {
            public Protocol(string UniqueId)
            {
                this.UniqueId = UniqueId;
            }
            public Protocol(string protocolName, string UniqueId, int started) :this(UniqueId)
            {
                this.Name = protocolName;
                this.Started = started;
                this.Finished = started;
                this.Qntd = 1;
            }

            public string Name { get; set; }
            public int Started { get; private set; }
            public int Finished { get; set; }
            public int Qntd { get; private set; }
            public string UniqueId { get; }

            internal string ReportLine()
            {
                return "Protocol: " + this.Name + "  " + SecondsToCompleteText(this.TotalTime(),this.Qntd);
            }

            internal void UpdateTime(int started)
            {
                this.Finished = started;
                Qntd += 1;
            }

            private int TotalTime()
            {
                var total = this.Finished - this.Started;
                return total;
            }

            internal int Duration()
            {
                return this.Finished - this.Started;
            }
        }

        internal void ExibeInRichText(RichTextBox richTextBox1)
        {
            
            p_add_line(richTextBox1, "********************************************************************************************************************************************************************************", 0);
            p_add_line(richTextBox1, Environment.NewLine, 0);
            p_add_line(richTextBox1, Environment.NewLine, 0);

            p_add_line(richTextBox1, "Scan total Time : " + this.ScanTotalTime(), 0);
            p_add_line(richTextBox1, Environment.NewLine, 0);



            //foreach (var item in this.Stages)
            //{
            //    p_add_line(richTextBox1, item.ReportLine(),0);
            //    p_add_line(richTextBox1, Environment.NewLine,0);


            //    foreach (var adapter in item.AdapterList)
            //    {
            //        p_add_line(richTextBox1, adapter.ReportLine(),1);
            //        p_add_line(richTextBox1, Environment.NewLine,1);

            //        foreach (var strategy in adapter.StrategyList)
            //        {
            //            p_add_line(richTextBox1, strategy.ReportLine(), 2);
            //            p_add_line(richTextBox1, Environment.NewLine, 2);

            //            foreach (var protocol in strategy.ProtocolList)
            //            {
            //                p_add_line(richTextBox1, protocol.ReportLine(), 3);
            //                p_add_line(richTextBox1, Environment.NewLine, 3);
            //            }

            //        }


            //    }
            //}


            p_add_line(richTextBox1, Environment.NewLine, 0);
            p_add_line(richTextBox1, "Strategies and times : ", 0);
            p_add_line(richTextBox1, Environment.NewLine, 0);

            var list = this.Stages.SelectMany(x => x.AdapterList).SelectMany(x => x.StrategyList).OrderBy(x => x.Duration());

            foreach (var item in list)
            {                
                p_add_line(richTextBox1, item.ReportLine(), 0);
                p_add_line(richTextBox1, Environment.NewLine, 0);
            }



            p_add_line(richTextBox1, Environment.NewLine, 0);
            p_add_line(richTextBox1, "Adapters and times : ", 0);
            p_add_line(richTextBox1, Environment.NewLine, 0);

            var list2 = this.Stages.SelectMany(x => x.AdapterList).OrderBy(x => x.Duration());

            foreach (var item in list2)
            {
                p_add_line(richTextBox1, item.ReportLine(), 0);
                p_add_line(richTextBox1, Environment.NewLine, 0);
            }


            p_add_line(richTextBox1, Environment.NewLine, 0);
            p_add_line(richTextBox1, "Protocol and times : ", 0);
            p_add_line(richTextBox1, Environment.NewLine, 0);

            var list3 = this.Stages.SelectMany(x => x.AdapterList).SelectMany(x => x.StrategyList).SelectMany(x => x.ProtocolList).OrderBy(x => x.Duration());

            foreach (var item in list3)
            {
                p_add_line(richTextBox1, item.ReportLine(), 0);
                p_add_line(richTextBox1, Environment.NewLine, 0);
            }




            p_add_line(richTextBox1, Environment.NewLine, 0);
            p_add_line(richTextBox1, "Stage and times : ", 0);
            p_add_line(richTextBox1, Environment.NewLine, 0);

            var list4 = this.Stages.OrderBy(x => x.Duration());

            foreach (var item in list4)
            {
                p_add_line(richTextBox1, item.ReportLine(), 0);
                p_add_line(richTextBox1, Environment.NewLine, 0);
            }

        }

        private string ScanTotalTime()
        {
            int minorTime = this.Stages.Min(x => x.Started);
            int majorTime = this.Stages.Max(x => x.Finished);



            return SecondsToCompleteText(majorTime - minorTime,1);
        }

        public static string SecondsToCompleteText(int seconds,int qntd)
        {

            double minutes = (double)seconds / 60;
            double hours = (double)seconds / 60 / 60;
            double mediaRasa = (double)seconds / qntd;

            string retorno = "************ Segundos " + (seconds).ToString() + " ************ Minutos "  +(minutes).ToString("0.00") + " ************ Horas   " + (hours).ToString("0.00")  ;
            return retorno;
        }

        private void p_add_line(RichTextBox richTextBox1, string stringTxt,int lvl)
        {
            string lvlstring = new String(' ', lvl*5);
            richTextBox1.AppendText(lvlstring + stringTxt);
        }
    }

    public class Identificator
    {
        public Identificator(string stageName,string adapterName, string strategyName, string protocolName,string time)
        {
            this.stageName = stageName;
            this.adapterName = adapterName;
            this.strategyName = strategyName;
            this.protocolName = protocolName;
            this.time = time;
        }

        public string stageName { get; }
        public string adapterName { get; }
        public string strategyName { get; }
        public string protocolName { get; }
        public string time { get; }

        internal int timeInt()
        {
            return Convert.ToInt32(time);
        }

        internal string UniqueId()
        {
            return stageName + adapterName + strategyName + protocolName;
        }
    }
}
