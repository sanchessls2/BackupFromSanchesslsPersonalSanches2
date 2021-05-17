using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoronaGetData
{
    internal class ClassGit
    {
        const string dir = @"C:\RepoAutomatico\";
        const string username = "sanchessls";
        const string email = "sanchessls@gmail.com";
        const string password = "asls12asls12";
        internal static void Adiciona(objDados dados)
        {
            int gambiarra = 0;

            string folder = dir + "v_" + gambiarra + "\\";
            
            while (Directory.Exists(folder))
            {
                gambiarra += 1;

                folder = dir + "v_" + gambiarra + "\\";
            }
          
            Repository.Clone("https://github.com/sanchessls/sanchessls.github.io.git", folder);


            var alterou = P_ALTERA_ARQUIVO(dados,folder);

            if (alterou)
            {
                Repository rep = new Repository(folder);
                
                StageChanges(rep);
                CommitChanges(rep);
                PushChanges(rep);
            }


        }

        private static bool P_ALTERA_ARQUIVO(objDados dados, string direc)
        {
            string GetArquivo = GetFile(direc +  "DadosAdicionaisCorona.js");

            if (GetArquivo.Contains(Convert.ToDateTime(dados.datee).ToString("yyyy-MM-dd")))
            {
                return false;
            }

            string NovoArquivo = AdicionaData(dados,GetArquivo);

            File.WriteAllText(direc + "DadosAdicionaisCorona.js", NovoArquivo);

            return true;
        }

        private static string AdicionaData(objDados dados, string getArquivo)
        {
            int position = getArquivo.IndexOf("//FIM AUTOMATICOS");

            string primeiraParte = getArquivo.Substring(0, position);
            string segundaParte = getArquivo.Substring(position);
            string LinhaNova = dados.LinhaNova();

            return primeiraParte + Environment.NewLine + LinhaNova + Environment.NewLine + segundaParte;
        }

        private static string GetFile(string v)
        {
            return File.ReadAllText(v);
        }

        public static void StageChanges(Repository repo)
        {
            try
            {
                RepositoryStatus status = repo.RetrieveStatus();
                List<string> filePaths = status.Modified.Select(mods => mods.FilePath).ToList();
                foreach (var item in filePaths)
                {
                    repo.Index.Add(item);
                    repo.Index.Write();
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:RepoActions:StageChanges " + ex.Message);
            }
        }

        public static void CommitChanges(Repository repo)
        {
            try
            {

                repo.Commit(DateTime.Now.ToString("dd-MM-yyyy HH-mm Automatico"), new Signature(username, email, DateTimeOffset.Now),
                    new Signature(username, email, DateTimeOffset.Now));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:RepoActions:CommitChanges " + e.Message);
            }
        }

        public static void PushChanges(Repository repo)
        {
            try
            {           
                CredentialsHandler newt =
new CredentialsHandler((url, fromUrl, types) =>
new UsernamePasswordCredentials { Username = username, Password = password });

                var options = new PushOptions();
                options.CredentialsProvider = newt;
                //options.OnPackBuilderProgress = packBuilderProgressHandler;
                //options.OnPushTransferProgress = pushTransferProgressHandler;
                //options.OnPushStatusError = pushStatusErrorHandler;

                repo.Network.Push(
                    repo.Network.Remotes["origin"],
                    @"refs/heads/main",
                    options);


                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:RepoActions:PushChanges " + e.Message);
            }
        }
    }
}