using Octokit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YgoProPatcher
{
     public class LocalData
    {
        private readonly static string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "YgoProPatcher");
     static private void CreateDirIfMissing()
        {
            if (!Directory.Exists(saveLocation))
            {
                Directory.CreateDirectory(saveLocation);
            }
        }

        static public List<string> LoadFileToList(string fileName)
        {
            string saveFile = Path.Combine(saveLocation, fileName);
            if (Directory.Exists(saveLocation) && File.Exists(saveFile))
            {
               return File.ReadAllLines(saveFile).ToList<string>();
            }
            else
            {
                //returns null to use array?[]
                return null;
            }

        }
        static public void SaveFile(List<string> List,string fileName)
        {
            CreateDirIfMissing();
            File.WriteAllLines(Path.Combine(saveLocation, fileName), List);
        }
        static public void SaveSHA(List<GitHubCommit> commits)
        {
            List<string> commitSHA = new List<string>();
            foreach(var commit in commits)
            {
                commitSHA.Add(commit.Sha);
            }
            SaveFile(commitSHA, "SHAs");
        }

    }
}
