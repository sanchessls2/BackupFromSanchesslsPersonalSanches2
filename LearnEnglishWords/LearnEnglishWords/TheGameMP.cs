using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading;

namespace LearnEnglishWords
{
    public class TheGameMP
    {

        public enum GameStatus
        {
            NonInitialized,
            Started
        }

        private string TheReport = "";
        private DateTime TheReportBeggining = DateTime.MinValue;
     
        private static TheGameMP TheGameMinimalParsInstance;
        public GameStatus Status = GameStatus.NonInitialized;
        private WordDatabaseMP Database;
        public int CurrentWordIndex = 0;
        private WordMP RunningWord;

        public bool HardModeOn = false;

        public Action AcertouPalavra { get; set; }
        public Action FimDoJogo { get; set; }
        

        public static TheGameMP GetInstance()
        {
            if (TheGameMinimalParsInstance == null)
            {                
                TheGameMinimalParsInstance = new TheGameMP();
                TheGameMinimalParsInstance.TheReportBeggining = DateTime.Now;
                TheGameMinimalParsInstance.AdicionaReport("Criando o jogo");                
            }

            return TheGameMinimalParsInstance;
        }

        internal string GetReport()
        {
            return TheReport;
        }

        private void AdicionaReport(string v)
        {
            TheReport += "(" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ") -  " + v + Environment.NewLine;

        }

        internal void Start()
        {
            TheGameMinimalParsInstance.AdicionaReport("Start no Jogo");
            Status = GameStatus.Started;
            LoadDatabase();           
            LoadFirstQuestion();
            
        }

        internal static void LimpaJogo()
        {
            TheGameMinimalParsInstance = null;
        }

        private void LoadFirstQuestion()
        {
            CurrentWordIndex = 0;
            RunningWord = Database.Words[CurrentWordIndex];
        }

        internal void Report()
        {

            double acertou = 0;
            double Errou = 0;
            double total = 0;
                


                acertou = this.Database.Words.Where(x => !x.Acertou).Count();
                Errou = this.Database.Words.Where(x => x.Acertou).Count();

                total = acertou + Errou;

                if (total == 0) { return; }

                AdicionaReport("Resumo das palavras");
         




            AdicionaReport("Total de Questoes : " + total);
            AdicionaReport("");
            AdicionaReport("Acertou : " + acertou);
            AdicionaReport("Pulou : " + Errou);

           

                AdicionaReport("*****************Erros*********************");
                foreach (var item in this.Database.Words.Where(x => x.Acertou).OrderByDescending(x => x.Acertou))
                {
                    AdicionaReport(item.TheWord);
                }

                AdicionaReport("***************Acertos*********************");
                foreach (var item in this.Database.Words.Where(x => !x.Acertou))
                {
                    AdicionaReport(item.TheWord);
                }
            

            AdicionaReport("");
            double percent =  ((acertou / (total)) * 100);
            AdicionaReport("Percentual de acerto : " + (percent.ToString("0.00")) + "%");

            var TempoDemorou = DateTime.Now - TheReportBeggining;

            
                AdicionaReport("Duracao : " + new DateTime(TempoDemorou.Ticks).ToString("HH:mm:ss"));
            
        }

        internal string GetRunningWordToSpeak()
        {
            return this.RunningWord.TheRightWord();
        }

        public double GetPercentRight()
        {
            try
            {
                var lista = Database.Words.Take(CurrentWordIndex);

                double acertou = lista.Where(x => !x.Acertou).Count();
                double Errou = lista.Where(x => x.Acertou).Count();
                double total = acertou + Errou;

                if (total > 0)
                {
                    double percent = ((acertou / (total)) * 100);

                    return percent;
                }
            }
            catch (Exception)
            {
            }

            return 0;

        }

        private void LoadDatabase()
        {
            this.Database = new WordDatabaseMP();
        }

   
        internal bool CheckWord(string text)
        {
            if (text.ToUpper().Trim() == RunningWord.TheRightWord().ToUpper().Trim())
            {
                Speaker.Acertou();
                AcertouPalavra.Invoke();
                this.RunningWord.Acertou = true;
                return true;
            }

            this.RunningWord.Acertou = false;

            Speaker.Errou();
            Thread.Sleep(1000);
            AcertouPalavra.Invoke();
            

            return false;
        }

        internal string GetTxtStatus()
        {            
            if (this.Status == GameStatus.Started)
            {
                return (CurrentWordIndex + 1) + " of " + Database.Words.Count;
            }
            else
            {
                return "";
            }
            
        }

        public void NextQuestion()
        {
            CurrentWordIndex += 1;

            if (CurrentWordIndex == Database.Words.Count)
            {
                P_FIM_DO_JOGO();
                return;
            }

            RunningWord = Database.Words[CurrentWordIndex];
        }

        internal string GetLastWord()
        {
            try
            {
                return Database.Words[CurrentWordIndex - 1].TheWord;
            }
            catch (Exception)
            {
                return "";                
            }
        }

        private void P_FIM_DO_JOGO()
        {
            this.Status = GameStatus.NonInitialized;
            TheGameMinimalParsInstance.AdicionaReport("Fim Do Jogo");
            FimDoJogo.Invoke();
        }

        public string GetRunningWord1()
        {
            return RunningWord.TheWord;
        }
        public string GetRunningWord2()
        {
            return RunningWord.TheWord2;
        }

        public WordMP GetRunningWord()
        {
            return RunningWord;
        }


    }
}
