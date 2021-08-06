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
                    palavra.UltimoErro = DateTime.Now;
                }
                else
                {
                    palavra = new WordWrong() { TheWord = item.Trim(), QuantosErros = 1,UltimoErro = DateTime.Now };
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


        internal static List<WordWrong> GetPalavrasErradas(int aboveX)
        {
            List<WordWrong> a = GetFile<WordWrong>(ListType.PalavrasErradasDATABASE);
            return a.Where(x => x.QuantosErros > aboveX).Select(x => x).ToList();

        }

        internal static List<WordWrong> GetPalavrasErradas()
        {
            List<WordWrong> a = GetFile<WordWrong>(ListType.PalavrasErradasDATABASE);
            return a;

        }

        public static void ExecutaScripts()
        {
            lock (objectBlock) 
            {
                P_SCRIPT_AJUSTE_DATA_PALAVRA_ERRADA(); 
            }

            
        }

        private static void P_SCRIPT_AJUSTE_DATA_PALAVRA_ERRADA()
        {
            string scriptName = "AjustePalavraErrada";
            
            bool Rodouscript = F_RodouScript(scriptName);

            if (!Rodouscript)
            {
                //Script

                var Palavras = GetPalavrasErradas();

                foreach (var item in Palavras)
                {
                    if (item.UltimoErro <= new DateTime(1900,1,1))
                    {
                        item.UltimoErro = DateTime.Now;
                    }
                }

                SetFile(Palavras, ListType.PalavrasErradasDATABASE);

                //Script

                P_ADICIONA_SCRIPT(scriptName);
            }

        }

        private static void P_ADICIONA_SCRIPT(string scriptName)
        {
            List<Script> a = GetFile<Script>(ListType.Script);

            var b = a.Where(x => x.ScriptName == scriptName);

            if (b.Count() <= 0)
            {
                a.Add(new Script() { ScriptName = scriptName});
            }

            SetFile<Script>(a,ListType.Script);
            
        }

        private static bool F_RodouScript(string scriptName)
        {
            List<Script> a = GetFile<Script>(ListType.Script);
            return a.Exists(x => x.ScriptName == scriptName);

        }
    }

    public class Script
    {
        public string ScriptName { get; set; }
    }

    public class WordWrong
    {
        public string TheWord { get;  set; }
        public int QuantosErros { get;  set; }
        public DateTime UltimoErro { get; set; }
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
