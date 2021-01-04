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

        public static string commonpath = GetFolderPath(SpecialFolder.CommonApplicationData);
        public static void GravaRegistro(Exam exam, ListType type) 
        {
            lock(objectBlock)
            {
                var objAtual = GetFile(type);
                objAtual.Add(exam);
                SetFile(objAtual, type);
            }
        }


        public static List<Exam> RetornaTodosTypo(ListType type)
        {
            lock (objectBlock)
            {
                return GetFile(type);
            }
        }

        private static string GetFileName(ListType type)
        {
            string path = commonpath + "\\" + "LearnEnglish" + "\\";
            Directory.CreateDirectory(path);
            return path + type.ToString() + ".dll";
        }


        private static List<Exam> GetFile(ListType type)
        {
            lock (objectBlock)
            {
                var file = GetFileName(type);
                if (!File.Exists(file))
                {
                    return new List<Exam>();
                }
                var obj = File.ReadAllText(file);

                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Exam>>(obj);
            }
        }

        private static void SetFile(List<Exam> objAtual, ListType type)
        {
            lock (objectBlock)
            {
                var obj = Newtonsoft.Json.JsonConvert.SerializeObject(objAtual);

                File.WriteAllText(GetFileName(type),obj);

            }
        }
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
