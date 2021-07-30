using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace LearnEnglishWords
{
    public class Separador_de_palavras
    {


        public static List<string> Separar2()
        {
            List<string> wordsOnly = new List<string>();
            List<string> retorno = new List<string>();

            //1 ao 27
          
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                //Titulo
            P_POPULA(wordsOnly, WordDatabase.LazySong);

            int count = 0;
            int max = wordsOnly.Distinct().Count();
            ExibeProgresso.iniciaStatus(count,max);
            foreach (var item in wordsOnly.Distinct())
            {
                count++;
                ExibeProgresso.atualizaStatus(count, max);
                P_ADICIONA_STRING_COM_TRAD(retorno, item);
            }



            return retorno;
        }
      
        private static void P_ADICIONA_STRING_COM_TRAD(List<string> retorno, string item)
        {             
            string teste = Translate(item);

            string str2 = teste;//"Clique em solicitar traducao para ver a traducao";
                string str = "P_Adiciona_palavra(ListofWords,\""+ item +"\",\""+str2+""+"\""+ ", new List<ListType>() { ListType.LazySong });";
                retorno.Add(str);
        }

        public static string Translate(String word)
        {
            try
            {
                System.Threading.Thread.Sleep(1300);




                var toLanguage = "pt-br";//English
                var fromLanguage = "en";//Deutsch
                var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
                var webClient = new WebClient
                {
                    Encoding = System.Text.Encoding.UTF8
                };
                var result = webClient.DownloadString(url);
                try
                {
                    result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                    return result;
                }
                catch (Exception abd)
                {
                    return "Error" + abd;
                }


            }
            catch (Exception abc)
            {

                return "";
            }
        }

        private static void P_POPULA(List<string> wordsOnly, string titulo)
        {
            var lista = F_TratarListaString(titulo);
            foreach (var item in lista)
            {
                if (!wordsOnly.Where(x => x.ToLower() == item.ToLower()).Any()) 
                {
                    wordsOnly.Add(item.ToLower());
                }
            }
        }

        public static List<Word> Separar() 
        {
            List<Word> retorno = new List<Word>();
            using(System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Users\andre.sanches\Desktop\DeFacto\aaaaaaaa.txt"))
{
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    retorno.AddRange(F_TratarLista(line));
                }
            }

            return retorno;
        }

        private static List<Word> F_TratarLista(string texto)
        {
            Regex a = new Regex(@"([a-zA-Z-']+)");
            var b = a.Matches(texto);            
            List<Word> retorno = new List<Word>();

            var x = b.Cast<Match>().Select(k => TrataStr(k.Value)).Where(asd => asd != "").Distinct();

            foreach (string item in x)
            {
                retorno.Add(P_CRIA_PALAVRA(item));
            }

            return retorno;
        }

        private static List<string> F_TratarListaString(string texto)
        {
            return F_TratarLista(texto).Select(x => x.TheWord).Distinct().ToList();
        }
        private static Word P_CRIA_PALAVRA(string item)
        {
            Word palavra = new Word();
            palavra.TheWord = item;
            palavra.Description = "Descricao da palavra";
            //palavra.WordType = new List<TheGame.ListType>() { TheGame.ListType.Detran};
            palavra.WhatToSay = "";
            return palavra;
        }

        private static string TrataStr(string value)
        {
            return value.Replace("in'", "ing").Replace("'Cause","Cause").Replace("  ", " ").Trim();
        }
    }
}
