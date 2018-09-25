using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;

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
                YgoProLinksPath.Text= paths[0];
                YgoPro2Path.Text = paths[1];
            }

        }

        bool threadRunning = false;
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
            string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"YgoProPatcher");
            string[] locationPaths = { YgoProLinksPath.Text, YgoPro2Path.Text };
            if (!Directory.Exists(saveLocation))
            {
                Directory.CreateDirectory(saveLocation);
            }
            File.WriteAllLines(Path.Combine(saveLocation,"paths.txt"),locationPaths);
          

        }

        private void Copy(string type)
        {
            string sourcePath = YgoProLinksPath.Text;
            string targetPath = YgoPro2Path.Text;
            string filePathYgoPro1="";
            string filePathYgoPro2="";
            string fileName;
            string destFile;
            
            if (type == "cdb")
            {
                filePathYgoPro1 = @"expansions\live2017links";
                filePathYgoPro2 = type;
            }
            if (type == "script")
            {
                filePathYgoPro1 = @"expansions\live2017links\"+type;
                filePathYgoPro2 = type;
            }
            if (type == "pic")
            {
                filePathYgoPro1 = type+"s";
                filePathYgoPro2 = @"picture\card";
            }
            if (type == "script2")
            {
                filePathYgoPro1 = type.Remove(type.Length-1);
                
                filePathYgoPro2 = filePathYgoPro1;
               
            }
            try
            {
                string fileSource = System.IO.Path.Combine(sourcePath, filePathYgoPro1);
                string fileDestination = Path.Combine(targetPath, filePathYgoPro2);
                //Status.Text = "Updating YGOPRO2 "+type+"s";
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
                    if (type == "script"||type=="script2")
                    {
                        partialName = "*.lua";
                    }

                    string[] files = Directory.GetFiles(fileSource, partialName);
                    
                    Status.Invoke(new Action(() => { progressBar.Maximum = files.Length; }));
                    foreach (string s in files)
                    {
                    if (threadRunning) { 
                            fileName = Path.GetFileName(s);

                        destFile = System.IO.Path.Combine(fileDestination, fileName);
                            if (type == "pic")
                            {
                                if (internetCheckbox.Checked)
                                {
                                    if(! PicDownload(fileName, fileDestination))
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
                        destFile = System.IO.Path.Combine(System.IO.Path.Combine(targetPath, "config"),fileName);
                        System.IO.File.Copy(Path.Combine(fileSource, fileName), destFile, true);

                      fileName = "official.cdb";
                        destFile = System.IO.Path.Combine(fileDestination, fileName);
                        System.IO.File.Copy(Path.Combine(fileSource, fileName), destFile, true);

                        fileName = "cards.cdb";
                        fileDestination = Path.Combine(targetPath, type+@"\English");
                        destFile = System.IO.Path.Combine(fileDestination, fileName);
                        System.IO.File.Copy(Path.Combine(sourcePath, fileName), destFile, true);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error, check YGOPRO Folder Paths");
            }
        }

        private string FolderSelection(string versionOfYGO)
        {
            string folderString = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Select main folder of " + versionOfYGO;
            DialogResult result = fbd.ShowDialog();
            if(result == DialogResult.OK)
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

        private bool PicDownload(string picName, string destinationFolder)
        {
            string website = "https://ygoprodeck.com/pics/";
            string webFile = website + picName;

            string destFile = Path.Combine(destinationFolder, Path.ChangeExtension(picName, ".png"));
            try
            {
                if (!File.Exists(destFile))
                {
                    using (var client = new WebClient())
                    {

                        client.DownloadFile(webFile, destFile);
                    }

                }
                return true;
            }
            catch
            {
                return false;
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (threadRunning) { Copy("cdb"); ; }
            if (threadRunning) { Copy("script"); }
            if (threadRunning) { Copy("script2"); }
            if (threadRunning) { Copy("pic"); ; }
            
            if (threadRunning)
            {
                
                Status.Invoke(new Action(() => { Status.Text = "Update Complete!"; cancel.Visible = false; internetCheckbox.Enabled = true; }));
                threadRunning = false;
            }
        }
    }
}
