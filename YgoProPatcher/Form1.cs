using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YgoProPatcher
{

    public partial class YgoProPatcher : Form
    {
        public YgoProPatcher()
        {
            InitializeComponent();
            string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "YgoProPatcher");
            string saveFile = Path.Combine(saveLocation, "paths.txt");
            if (Directory.Exists(saveLocation) && File.Exists(saveFile))
            {
                string[] paths = File.ReadAllLines(saveFile);
                YgoProLinksPath.Text = paths[0];
                YgoPro2Path.Text = paths[1];
            }
            _pool = new Semaphore(0, 7);
            _pool.Release(7);

        }

        bool threadRunning = false;
        int concurrentDownloads=0;
        private static Semaphore _pool;
        private void YgoProLinksButton_Click(object sender, EventArgs e)
        {
            FolderSelection("YGOPro Links");
        }

        private void YGOPRO2Button_Click(object sender, EventArgs e)
        {
            FolderSelection("YGOPRO2");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            internetCheckbox.Enabled = false;
            progressBar.Visible = true;
            cancel.Visible = true;
            threadRunning = true;
            backgroundWorker1.RunWorkerAsync();
            string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "YgoProPatcher");
            string[] locationPaths = { YgoProLinksPath.Text, YgoPro2Path.Text };
            if (!Directory.Exists(saveLocation))
            {
                Directory.CreateDirectory(saveLocation);
            }
            File.WriteAllLines(Path.Combine(saveLocation, "paths.txt"), locationPaths);


        }

        private void Copy(string type)
        {
            string sourcePath = YgoProLinksPath.Text;
            string targetPath = YgoPro2Path.Text;
            string filePathYgoPro1 = "";
            string filePathYgoPro2 = "";
            string fileName;
            string destFile;

            if (type == "cdb")
            {
                filePathYgoPro1 = @"expansions\live2017links";
                filePathYgoPro2 = type;
            }
            if (type == "script")
            {
                filePathYgoPro1 = @"expansions\live2017links\" + type;
                filePathYgoPro2 = type;
            }
            if (type == "pic")
            {
                filePathYgoPro1 = type + "s";
                filePathYgoPro2 = @"picture\card";
            }
            if (type == "script2")
            {
                filePathYgoPro1 = type.Remove(type.Length - 1);

                filePathYgoPro2 = filePathYgoPro1;

            }
            try
            {
                string fileSource = System.IO.Path.Combine(sourcePath, filePathYgoPro1);
                string fileDestination = Path.Combine(targetPath, filePathYgoPro2);
                if (!(type == "script2"))
                {
                    Status.Invoke(new Action(() => { Status.Text = "Updating YGOPRO2 " + type + "s"; }));
                }
                else
                {
                    Status.Invoke(new Action(() => { Status.Text = "Updating old scripts"; }));
                }
                Status.Invoke(new Action(() => { progressBar.Value = 0; }));
                if (Directory.Exists(fileSource) && Directory.Exists(fileDestination))
                {
                    string partialName = "";
                    if (type == "cdb")
                    {
                        partialName = "prere*";
                    }
                    if (type == "pic")
                    {
                        partialName = "*.jpg";
                    }
                    if (type == "script" || type == "script2")
                    {
                        partialName = "*.lua";
                    }

                    string[] files = Directory.GetFiles(fileSource, partialName);

                    progressBar.Invoke(new Action(() => { progressBar.Maximum = files.Length; }));
                    foreach (string s in files)
                    {
                        if (threadRunning)
                        {
                            fileName = Path.GetFileName(s);

                            destFile = System.IO.Path.Combine(fileDestination, fileName);
                            if (type == "pic")
                            {
                                if (internetCheckbox.Checked)
                                {
                                    string website = "https://ygoprodeck.com/pics/";
                                    if (!FileDownload(fileName, fileDestination, website, false).Result)
                                    {
                                        destFile = Path.ChangeExtension(destFile, ".png");
                                        if (!File.Exists(destFile))
                                        {
                                            System.IO.File.Copy(s, destFile, false);
                                        }
                                    }
                                }
                                else
                                {
                                    destFile = Path.ChangeExtension(destFile, ".png");
                                    if (!File.Exists(destFile))
                                    {
                                        System.IO.File.Copy(s, destFile, false);
                                    }
                                }
                            }
                            else
                            {
                                System.IO.File.Copy(s, destFile, true);
                            }
                                progressBar.Invoke(new Action(() => { progressBar.Increment(1); }));
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (type == "cdb")
                    {
                        fileName = "lflist.conf";
                        destFile = System.IO.Path.Combine(System.IO.Path.Combine(targetPath, "config"), fileName);
                        System.IO.File.Copy(Path.Combine(fileSource, fileName), destFile, true);

                        fileName = "official.cdb";
                        destFile = System.IO.Path.Combine(fileDestination, fileName);
                        System.IO.File.Copy(Path.Combine(fileSource, fileName), destFile, true);

                        fileName = "cards.cdb";
                        fileDestination = Path.Combine(targetPath, type + @"\English");
                        destFile = System.IO.Path.Combine(fileDestination, fileName);
                        System.IO.File.Copy(Path.Combine(sourcePath, fileName), destFile, true);
                        fileName = "cards.cdb";
                        fileDestination = Path.Combine(targetPath, type);
                        destFile = System.IO.Path.Combine(fileDestination, fileName);
                        System.IO.File.Copy(Path.Combine(sourcePath, fileName), destFile, true);
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private string FolderSelection(string versionOfYGO)
        {
            string folderString = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Select main folder of " + versionOfYGO;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (versionOfYGO == "YGOPRO2")
                {
                    YgoPro2Path.Text = fbd.SelectedPath;
                }
                else
                {
                    YgoProLinksPath.Text = fbd.SelectedPath;
                }


            }

            return folderString;
        }

        private async Task<bool> FileDownload(string fileName, string destinationFolder, string website, bool overwrite)
        {
            _pool.WaitOne();
            string webFile = website + fileName;
            string destFile;
            if (Path.GetExtension(fileName) == ".jpg")
            {
                destFile = Path.Combine(destinationFolder, Path.ChangeExtension(fileName, ".png"));
            }
            else
            {
                destFile = Path.Combine(destinationFolder, fileName);
            }

            try
            {
                
                if (!File.Exists(destFile) || overwrite)
                {
                    using (var client = new WebClient())
                    {
                        await Task.Run(()=> { client.DownloadFile(new Uri(webFile), destFile); });
                    }

                }
                
                return true;
            }
            catch
            {
                
               return false;
            }
            finally
            {
                
                _pool.Release();
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            threadRunning = false;
            backgroundWorker1.CancelAsync();
            cancel.Visible = false;
            internetCheckbox.Enabled = true;
            Status.Text = "Operation Canceled!";
            Status.Update();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!gitHubDownloadCheckbox.Checked)
            {
                if (threadRunning) { Copy("cdb"); ; }
                if (threadRunning) { Copy("script"); }
                if (threadRunning) { Copy("script2"); }
                if (threadRunning) { Copy("pic"); ; }
            }
            else
            {
                if (threadRunning)
                {
                    await GitHubDownload(YgoPro2Path.Text);
                }
            }
            if (threadRunning)
            {

                Status.Invoke(new Action(() => { Status.Text = "Update Complete!"; cancel.Visible = false; internetCheckbox.Enabled = true; debug.Update(); }));
                threadRunning = false;
            }
        }
        private async Task<List<string>> connectToGithub(string path, string extension)
        {
            var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
            var result = await github.Repository.Content.GetAllContents("Ygoproco", "Live2017Links", path);


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

        private async Task<List<string>> DownloadCDBSFromGithub(string destinationFolder)
        {
            List<string> listOfCDBs = await connectToGithub("/", ".cdb");
            string cdbFolder = Path.Combine(destinationFolder, "cdb");
            progressBar.Invoke(new Action(() => progressBar.Maximum = listOfCDBs.Count));
            List<string> listOfDownloadedCDBS = new List<string>(); //{ Path.Combine(cdbFolder, "cards.cdb") };
            List<Task> downloadList = new List<Task>();
            foreach (string cdb in listOfCDBs)
            {
                FileDownload(cdb, cdbFolder, "https://github.com/Ygoproco/Live2017Links/raw/master/", true);
                listOfDownloadedCDBS.Add(Path.Combine(cdbFolder, cdb));
                progressBar.Invoke(new Action(() => progressBar.Increment(1)));
            }
            return listOfDownloadedCDBS;
        }
        private void downloadUsingCDB(List<string> listOfDownloadedCDBS, string destinationFolder)
        {
           
            foreach (string cdb in listOfDownloadedCDBS)
            {
                if (threadRunning)
                {
                    DataClass db = new DataClass(cdb);
                    DataTable dt = db.selectQuery("SELECT id FROM datas");
                    Status.Invoke(new Action(() => Status.Text = "Updating Pics and Scripts using " + Path.GetFileName(cdb)));
                    progressBar.Invoke(new Action(() => progressBar.Maximum = (dt.Rows.Count)));
                    progressBar.Invoke(new Action(() => progressBar.Value = 0));
                    string dlWebsitePics = "https://ygoprodeck.com/pics/";
                    string dlWebsiteLua = "https://raw.githubusercontent.com/Ygoproco/Live2017Links/master/script/";
                    string dFPics = Path.Combine(destinationFolder, @"picture\card");
                    string dFLua = Path.Combine(destinationFolder, "script");
                    List<string> downloadList = new List<string>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (threadRunning)
                        {
                            downloadList.Add(dt.Rows[i][0].ToString());
                        } 
                        else
                        {
                            break;
                        }

                    }
                    foreach (string Value in downloadList)
                    {

                        if (threadRunning)
                        {
                            FileDownload(Value.ToString() + ".jpg", dFPics, dlWebsitePics, false);
                            FileDownload("c" + Value.ToString() + ".lua", dFLua, dlWebsiteLua, true);
                            progressBar.Invoke(new Action(() => progressBar.Increment(1)));

                        }
                    }

                }
            }
        }



        private async Task GitHubDownload(string destinationFolder)
        {
            Status.Invoke(new Action(() => { Status.Text = "Updating CDBS from Live2017Links"; }));
            List<string> CDBS = new List<string>();//{ @"D:\TestYGOPRO2\cdb\prerelease.cdb" };

           CDBS= await DownloadCDBSFromGithub(destinationFolder);
            progressBar.Invoke(new Action(() => { progressBar.Value = progressBar.Maximum; }));
            downloadUsingCDB(CDBS, destinationFolder);
            await FileDownload("lflist.conf", Path.Combine(YgoPro2Path.Text, "config"), "https://raw.githubusercontent.com/Ygoproco/Live2017Links/master/", true);
        }



        private void gitHubDownloadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            YgoProLinksPath.Enabled = !YgoProLinksPath.Enabled;
            pathButtonYGOPRO1.Enabled = !pathButtonYGOPRO1.Enabled;
            internetCheckbox.Enabled = !internetCheckbox.Enabled;
            if (gitHubDownloadCheckbox.Checked&&!internetCheckbox.Checked)
            {
                
                internetCheckbox.Checked = !internetCheckbox.Checked;
            }


        }
    }
    class DataClass
    {
        private SQLiteConnection sqlite;
        public DataClass(string dbPath)
        {
            sqlite = new SQLiteConnection("Data Source=" + dbPath);
        }
        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            try
            {
                SQLiteCommand cmd;
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Can't open the DB: "+ex.ToString());
            }
            sqlite.Close();
            return dt;
        }

    }

}
