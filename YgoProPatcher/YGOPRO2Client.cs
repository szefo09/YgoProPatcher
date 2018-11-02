using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;


namespace YgoProPatcher
{
    static public class YGOPRO2Client
    {

        static public void Download(string path)
        {
            string tempFolder = Path.Combine(path, "temp");
            DirectoryInfo directory = new DirectoryInfo(tempFolder);
            try
            {
                
                if (!directory.Exists)
                {
                    directory.Create();
                    directory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
                else
                {
                    foreach (var info in directory.GetFileSystemInfos("*", SearchOption.AllDirectories))
                    {
                        info.Attributes = FileAttributes.Normal;
                    }
                    directory.Delete(true);
                }
               
                Repository.Clone(GitAccess.GetURLofRepo(Data.YgoPro2Owner, "ygopro2"), directory.FullName);
                DirectoryInfo gitFolder = new DirectoryInfo(Path.Combine(tempFolder, ".git"));
                if (gitFolder.Exists)
                {
                    foreach (var info in gitFolder.GetFileSystemInfos("*", SearchOption.AllDirectories))
                    {
                        info.Attributes = FileAttributes.Normal;
                    }
                    gitFolder.Delete(true);
                }

                Copy(tempFolder, path);
                return;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("There was an error during the download of the new client. Please try launching this program as an Administrator.\n\nError Code:\n"+e.ToString());
            }
            finally
            {
                foreach (var info in directory.GetFileSystemInfos("*", SearchOption.AllDirectories))
                {
                    info.Attributes = FileAttributes.Normal;
                }
                directory.Delete(true);
            }
            
        }

        static private void Copy(string source_dir, string destination_dir)
        {

            // substring is to remove destination_dir absolute path (E:\).

            // Create subdirectory structure in destination    
            foreach (string dir in System.IO.Directory.GetDirectories(source_dir, "*", System.IO.SearchOption.AllDirectories))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(destination_dir, dir.Substring(source_dir.Length + 1)));
                }
                catch
                {

                }
            }

            foreach (string file_name in System.IO.Directory.GetFiles(source_dir, "*", System.IO.SearchOption.AllDirectories))
            {
                try
                {
                    System.IO.File.Copy(file_name, System.IO.Path.Combine(destination_dir, file_name.Substring(source_dir.Length + 1)), true);
                }
                catch
                {

                }
            }
            DirectoryInfo directory;
            List<string> directories = new List<string> { "script", "picture","picture/field","picture/card","picture/closeup"};
            foreach (string dir in directories)
            {
                try
                {
                    directory = new DirectoryInfo(Path.Combine(destination_dir, dir));
                    if (!directory.Exists)
                    {
                        directory.Create();
                    }
                }
                catch
                {

                }
            }
        }
        
    }
}
