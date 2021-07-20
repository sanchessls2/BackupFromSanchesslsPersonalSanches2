using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static LearnEnglishWords.TheGame;
using static System.Environment;

namespace LearnEnglishWords
{
    public static class HDatabase
    {
        public static Object objectBlock = new Object();
        public static Object objectBlockPalavraErrada = new Object();
        

        public static string commonpath = GetFolderPath(SpecialFolder.CommonApplicationData);
        public static void GravaRegistro(Exam exam, ListType type) 
        {
            lock(objectBlock)
            {
                var objAtual = GetFile<Exam>(type);
                objAtual.Add(exam);
                SetFile(objAtual, type);
            }
        }


        public static List<Tuple<List<Exam>, string>> RetornaTodosTypo(ListType type)
        {
            return RetornaTodos(type.ToString());
        }

        private static string GetFileName(ListType type)
        {
            string path = commonpath + "\\" + "LearnEnglish" + "\\";
            Directory.CreateDirectory(path);
            return path + type.ToString() + ".dll";
        }


        private static List<T> GetFile<T>(ListType type)
        {
            lock (objectBlock)
            {
                var file = GetFileName(type);
                if (!File.Exists(file))
                {
                    return new List<T>();
                }
                var obj = File.ReadAllText(file);

                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(obj);
            }
        }



        internal static List<Tuple<List<Exam>,string>> RetornaTodos(string fileNameIfEspecific = "")
        {
            var retorno = new List<Tuple<List<Exam>, string>>();

            string path = commonpath + "\\" + "LearnEnglish" + "\\";
             
            var  getall = Directory.GetFiles(path);

            foreach (var item in getall)
            {
                string filename = Path.GetFileName(item);

                if (fileNameIfEspecific != "")
                {
                    string toCompare = Path.GetFileName(filename);

                    if (toCompare != (fileNameIfEspecific+ ".dll"))
                    {
                        continue;
                    }
                }                

                try
                {
                    var obj = File.ReadAllText(item);
                    var objConverted = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Exam>>(obj);
                    
                    retorno.Add(new Tuple<List<Exam>, string>(objConverted, filename));
                }
                catch (Exception abc)
                {
                    Console.WriteLine(abc.Message);
                }
            }

            return retorno;

        }

        private static void SetFile<T>(List<T> objAtual, ListType type)
        {
            lock (objectBlock)
            {
                var obj = Newtonsoft.Json.JsonConvert.SerializeObject(objAtual);             
                File.WriteAllText(GetFileName(type),obj);
            }
        }

        internal static void GravaPalavrasErradas(List<string> wrongWords)
        {
            foreach (var item in wrongWords)
            {
                P_GRAVA_PALAVRA_ERRADA(item);
            }
        }

        private static void P_GRAVA_PALAVRA_ERRADA(string item)
        {
            lock (objectBlockPalavraErrada)
            {
                List<WordWrong> objAtual = GetFile<WordWrong>(ListType.PalavrasErradasDATABASE);

                var palavra = objAtual.Where(x => x.TheWord.Trim().ToLower() == item.Trim().ToLower()).FirstOrDefault();

                if (palavra != null)
                {
                    palavra.QuantosErros += 1;
                }
                else
                {
                    palavra = new WordWrong() { TheWord = item.Trim(), QuantosErros = 1 };
                    objAtual.Add(palavra);
                }

                SetFile(objAtual, ListType.PalavrasErradasDATABASE);
            }
        }

        public static bool F_LiberaTraduzir( ListType type)
        {
            return true;
            /*
            var obj = GetFile(type);
            if (obj.Count() > 0)
            {
                return (obj.Max(x => x.Percentage) < 85);
            }
            else 
            {
                return true;   
            }
            */
        }

        internal static List<string> GetPalavrasErradas(int aboveX)
        {
            List<WordWrong> a = GetFile<WordWrong>(ListType.PalavrasErradasDATABASE);
            return a.Where(x => x.QuantosErros > aboveX).Select(x => x.TheWord).ToList();

        }
    }
    public class WordWrong
    {
        public string TheWord { get;  set; }
        public int QuantosErros { get;  set; }
    }

    public class Exam {
        public Exam()
        {
            Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        public DateTime Date { get; set; }
        public Double Percentage { get; set; }
        public string Duracao { get; set; }
        public string Version { get; set; }
    }
}
