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

namespace YgoProPatcher
{
    
    public partial class Form1 : Form
    {
        public Form1()
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
            progressBar.Visible = true;
            Copy("cdb");
           
            Copy("script");
           
            Copy("pic");
            string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"YgoProPatcher");
            string[] locationPaths = { YgoProLinksPath.Text, YgoPro2Path.Text };
            if (!Directory.Exists(saveLocation))
            {
                Directory.CreateDirectory(saveLocation);
            }
            File.WriteAllLines(Path.Combine(saveLocation,"paths.txt"),locationPaths);
            Status.Text = "Done!";

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
            try
            {
                string fileSource = System.IO.Path.Combine(sourcePath, filePathYgoPro1);
                string fileDestination = Path.Combine(targetPath, filePathYgoPro2);
                Status.Text = "Copying "+type+"s";
                progressBar.Value = 0;
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
                    if (type == "script")
                    {
                        partialName = "*.lua";
                    }
                    string[] files = Directory.GetFiles(fileSource, partialName);
                    progressBar.Maximum = files.Length;
                    foreach (string s in files)
                    {
                        if (type == "pic")
                        {
                            fileName = Path.ChangeExtension(Path.GetFileName(s), ".png");
                        }
                        else
                        {
                            fileName = Path.GetFileName(s);
                        }
                        destFile = System.IO.Path.Combine(fileDestination, fileName);
                        if (type == "pic")
                        {
                            if (!File.Exists(destFile))
                            {
                                System.IO.File.Copy(s, destFile, false);
                            }
                        }
                        else
                        {
                            System.IO.File.Copy(s, destFile, true);
                        }
                        
                        
                        progressBar.Increment(1);
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
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
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
    }
}
