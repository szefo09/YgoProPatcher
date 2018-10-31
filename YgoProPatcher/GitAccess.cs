using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YgoProPatcher
{
   public static class GitAccess
    {
       static GitHubClient github = new GitHubClient(new ProductHeaderValue("pics"))
        {
            Credentials = new Credentials(Data.GetToken())
        };
        static public List<RepositoryContent> GetRepositoryContent(string owner, string repo,string path)
        {

            List<RepositoryContent> result = new List<RepositoryContent>();
            if(path ==null || path == "")
            {
               result.AddRange(github.Repository.Content.GetAllContents(owner, repo).Result);
            }
            else
            {
               result.AddRange(github.Repository.Content.GetAllContents(owner, repo,path).Result);
            }
            
            return result;
        }
        static public string GetURLofRepo(string owner, string repo)
        {
            Repository repository = github.Repository.Get(owner, repo).Result;
            

            return repository.CloneUrl;
        }
        static public List<string> GetAllFilesWithExtensionFromYGOPRO(string path, string extension)
        {
            List<RepositoryContent> result = GitAccess.GetRepositoryContent("Ygoproco", "Live2017Links", path);
            List<string> fileNames = new List<string>();
            foreach (var c in result)
            {
                if (c.Name.Contains(extension))
                {
                    fileNames.Add(c.Name);

                }
            }
            return fileNames;
        }
        static public Release GetNewestYgoProPatcherRelease()
        {
          return github.Repository.Release.GetLatest("szefo09", "ygopropatcher").Result;
        }


    }
}
