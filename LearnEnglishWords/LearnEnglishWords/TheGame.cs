using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace LearnEnglishWords
{
    public class TheGame
    {

        public enum GameStatus
        {
            NonInitialized,
            Started
        }
        public enum Prova
        {
            Nenhuma = 0,
            [Description("I'm With you Avril lavigne")]
            ImWithYouAvrilLavigne = 1,
            [Description("Naked -  Avril lavigne")]
            Naked = 2,
            [Description("Anything but ordinary -  Avril lavigne")]
            AnythingButOrdinary = 3,
            Tomorrow = 4
        }
        public enum ListType
        { 
            SetTheRainOnFire,
            TheClimb,
            MrJones,
            EndOfWorld,
            TheReasonHoobastank,
            WhitneyIHaveNothing,
            Aerosmith_IDontWantToMissAThing,
            OneU2,
            SheLovesYouTheBeatles,
            RayMillencolin,
            Marron5Memories,
            OthersideRedHot,
            SayYouWontLetGoJamesArthur,
            ArianaDangerousWoman,
             QueenLoveOfMyLife,
            SundayBloodySunday,
            Avril_Complicated,
            Beatles_Help,
            Breakaway,
            JackJohnsonBananaPancakes,            
            AVRILNakedAvrilLavigne ,
            AVRILAnythingButOrdinary ,
            AVRILTomorrow,
            Letter,
            AndreWords,
            NumberAndHour,
            MinimalPairs_i_ee_EASY,
            MinimalPairs_i_ee_MEDIUM,
            MinimalPairs_i_ee_HARD,
            General,
            HarryPotter1,
            DriverLessons,
            Detran,
            AVRILImWithYouAvrilLavigne,
        }

        internal ListType GetTipo()
        {
            return ActualType;
        }

        private string TheReport = "";
        private DateTime TheReportBeggining = DateTime.MinValue;
     
        private static TheGame TheGameInstance;
        public GameStatus Status = GameStatus.NonInitialized;

        public ListType ActualType { get; private set; }

        private WordDatabase Database;
        public int CurrentWordIndex = 0;
        private Word RunningWord;

        public bool HardModeOn = false;

        public Action AcertouPalavra { get; set; }
        public Action FimDoJogo { get; set; }
        

        public static TheGame GetInstance()
        {
            if (TheGameInstance == null)
            {                
                TheGameInstance = new TheGame();
                TheGameInstance.TheReportBeggining = DateTime.Now;
                TheGameInstance.AdicionaReport("Criando o jogo");                
            }

            return TheGameInstance;
        }

        internal void ClickPulou(string tentou)
        {
            this.RunningWord.Pulou = true;

        }

        internal void AdicionaTentativa(string tentou) 
        {
            tentou = tentou.Trim();
            if (this.RunningWord.TentouDigitar == null)
            {
                this.RunningWord.TentouDigitar = new List<string>();
            }

            if (!this.RunningWord.TentouDigitar.Any(x => x == tentou))
            {
                this.RunningWord.TentouDigitar.Add(tentou);
            }
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
            TheGameInstance.AdicionaReport("Start no Jogo");
            Status = GameStatus.Started;
            LoadDatabase(Form2.ListaEscolhada.First());
            this.HardModeOn = Form2.HardModeOn();

            TheGameInstance.AdicionaReport("Selecionou : ");
            foreach (var item in Form2.ListaEscolhada)
            {
                TheGameInstance.AdicionaReport(item.ToString());
            }
            
            LoadFirstQuestion();
            
        }

        internal static void LimpaJogo()
        {
            TheGameInstance = null;
        }

        private void LoadFirstQuestion()
        {
            CurrentWordIndex = 0;
            RunningWord = Database.Words[CurrentWordIndex];
        }

        internal Exam Report(bool onlytotal, TheGame.ListType tipo)
        {
            Exam retorno = new Exam
            {
                Date = DateTime.Now,
                Percentage = 0,
                Duracao = ""
            };

            double acertou = 0;
            double Errou = 0;
            double total = 0;
            if (!onlytotal)
            {
                


                acertou = this.Database.Words.Where(x => !x.Pulou).Count();
                Errou = this.Database.Words.Where(x => x.Pulou).Count();

                total = acertou + Errou;

                if (total == 0) { return null; }

                AdicionaReport("Resumo das palavras");
            }
            else 
            {



                acertou = this.Database.Words.Where(x => x.WordType.Contains(tipo)).Where(x => !x.Pulou).Count();
                Errou = this.Database.Words.Where(x => x.WordType.Contains(tipo)).Where(x => x.Pulou).Count();

                total = acertou + Errou;

                if (total == 0) { return null; }

                AdicionaReport("");
                AdicionaReport("");
                AdicionaReport("*              * TIPO  *                   ** ");
                AdicionaReport("*              * " + tipo.ToString() + "  *                   ** ");

            }





            AdicionaReport("Total de Questoes : " + total);
            AdicionaReport("");
            AdicionaReport("Acertou : " + acertou);
            AdicionaReport("Pulou : " + Errou);

            if (!onlytotal)
            {


                AdicionaReport("*****************Erros*********************");
                foreach (var item in this.Database.Words.Where(x => x.Pulou).OrderByDescending(x => x.Ouvir).ThenBy(x => x.VerDescricao))
                {
                    AdicionaReport(item.TheWord + " Ouviu : " + item.Ouvir + " Viu descricao: " + (item.VerDescricao ? "Sim" : "Não"));

                    if (item.TentouDigitar != null)
                    {
                        foreach (var item2 in item.TentouDigitar)
                        {
                            if (item2.Trim() != "")
                            {
                                AdicionaReport(" Tentou Digitar : " + item2.Trim());
                            }
                        }
                    }
                  
                }

                AdicionaReport("***************Acertos*********************");
                foreach (var item in this.Database.Words.Where(x => !x.Pulou))
                {
                    AdicionaReport(item.TheWord + " Ouviu : " + item.Ouvir + " Viu descricao: " + (item.VerDescricao ? "Sim" : "Não"));
                }
            }

            AdicionaReport("");
            double percent =  ((acertou / (total)) * 100);
            AdicionaReport("Percentual de acerto : " + (percent.ToString("0.00")) + "%");

            retorno.Percentage = percent;

            var TempoDemorou = DateTime.Now - TheReportBeggining;

            var duracao = new DateTime(TempoDemorou.Ticks).ToString("HH:mm:ss");

            retorno.Duracao = duracao;


            if (!onlytotal)
            {
                AdicionaReport("Duracao : " + duracao);
            }


            return retorno;
        }

        public double GetPercentRight()
        {
            try
            {
                var lista = Database.Words.Take(CurrentWordIndex);

                double acertou = lista.Where(x => !x.Pulou).Count();
                double Errou = lista.Where(x => x.Pulou).Count();
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

        public string GetDescription() 
        {
            return RunningWord.Description;        
        }

        private void LoadDatabase(TheGame.ListType somente)
        {
            this.ActualType = somente;
            this.Database = new WordDatabase(new List<TheGame.ListType>() { somente });
        }
   
        internal bool CheckWord(string text)
        {
            if (text.ToUpper().Trim() == RunningWord.TheWord.ToUpper().Trim())
            {
                AcertouPalavra.Invoke();
                return true;
            }

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

        internal void AddClickOuvir()
        {
            this.RunningWord.Ouvir += 1;
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

        internal void ClickVerDescricao()
        {
            this.RunningWord.VerDescricao = true;
        }

        private void P_FIM_DO_JOGO()
        {
            this.Status = GameStatus.NonInitialized;
            TheGameInstance.AdicionaReport("Fim Do Jogo");
            FimDoJogo.Invoke();
        }

        public string GetRunningWord()
        {
            return RunningWord.TheWord;
        }

        public string GetRunningWordToSpeak()
        {
            if (RunningWord.WhatToSay != "") { return RunningWord.WhatToSay; };
            return RunningWord.TheWord;
        }
    }
}
