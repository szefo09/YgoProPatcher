using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using Octokit;

namespace YgoProPatcher
{
    public class UpdateChecker
    {
        public static bool CheckForUpdate()
        {
            try
            {
                List<GitHubCommit> gits = GitAccess.GetHeaderCommit();
                List<string> gitshas = new List<string>();
                foreach (GitHubCommit git in gits)
                {
                    gitshas.Add(git.Sha);
                }
                gitshas.Sort();
                List<string> shas = LocalData.LoadFileToList("SHAs");
                if (shas == null)
                {
                    LocalData.SaveFile(gitshas, "SHAs");
                    shas = LocalData.LoadFileToList("SHas");
                }
                shas?.Sort();
                if (!shas.SequenceEqual(gitshas))
                {
                    LocalData.SaveFile(gitshas, "SHAs");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't check for new updates!\n" + e.ToString());
            }
            return false;
        }
    }
}
