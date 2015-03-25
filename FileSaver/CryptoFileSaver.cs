using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileSaver
{
    public partial class CryptoFileSaver : Form
    {
        private string formattedFilePath;
        List<string> encryptedFiles = new List<string>();

        public CryptoFileSaver()
        {
            InitializeComponent();
        }

        private void loadRegistryFileBtn_Click(object sender, EventArgs e)
        {
            registryFileBrowser.ShowDialog();
        }

        private void registryFileBrowser_FileOk(object sender, CancelEventArgs e)
        {
            registryFile.Text = registryFileBrowser.FileName;
        }

        private void processRegistryFile_Click(object sender, EventArgs e)
        {
            List<string> files = new List<string>();

            using (StreamReader r = new StreamReader(registryFile.Text))
            {
                string file;

                while ((file = r.ReadLine()) != null)
                {
                    if (file.StartsWith("\""))
                    {                                     
                        Match temp = Regex.Match(file.Replace("\\\\", "\\"), "[^\"]*[^\"]");
                        files.Add(temp.ToString());
                    }
                }
            }

            files.Sort();

            saveFormattedRegFileLocation.ShowDialog();

            formattedFilePath = saveFormattedRegFileLocation.SelectedPath + "\\FormattedReg.txt";

            File.WriteAllLines(formattedFilePath, files);

            formattedFile.Text = formattedFilePath;
        }

        private void copySafe_Click(object sender, EventArgs e)
        {
            if (orignalDriveLetter.Text == "")
            {
                MessageBox.Show("Please selected original drive letter.");
                return;
            }

            using (StreamReader r = new StreamReader(formattedFile.Text))
            {
                string file;

                while ((file = r.ReadLine()) != null)
                {
                    if (file.StartsWith(orignalDriveLetter.Text))
                    {
                        string temp = file.Replace(orignalDriveLetter.Text, currentLocationEncrptedFiles.Text);
                        encryptedFiles.Add(temp.ToString());
                    }
                }
            }

            CopyFiles();
        }

        private void CopyFiles()
        {
            string currDir;

            List<string> excludedFiles = new List<string>();

            foreach (string p in exclusionList.Items)
            {
                excludedFiles.Add(p);
            }


            DirectoryInfo dir = new DirectoryInfo(targetDir.Text);

            if(dir.Exists == false)
            {
                dir.Create();
            }

            int count = 0;

            foreach(string item in encryptedFiles)
            {

                currDir = Path.GetDirectoryName(item);
                string currPath = currDir.Replace(currentLocationEncrptedFiles.Text + "\\", "");

                if(Directory.Exists(currDir))
                {
                     
                    foreach (var file in Directory.GetFiles(currDir))
                    {
                        DirectoryInfo destDir = new DirectoryInfo(targetDir.Text + currPath);

                        if (!destDir.Exists)
                        {
                            destDir.Create();
                        }

                        if (!encryptedFiles.Any(f => f.Contains(file))
                            && !excludedFiles.Any(f => f.Contains(Path.GetFileName(file))))
                        {                       
                            File.Copy(file, Path.Combine(targetDir.Text + currPath, Path.GetFileName(file)), true);
                            count++;
                        };
                    }
                }
                else
                {
                    continue;

                }
            }

            MessageBox.Show(count.ToString() + " files copied");
        }

        private void loadFormattedRegistryFileBtn_Click(object sender, EventArgs e)
        {
            formattedRegBrowser.ShowDialog();
        }

        private void formattedRegBrowser_FileOk(object sender, CancelEventArgs e)
        {
            currentLocationEncrptedFiles.Text = formattedRegBrowser.FileName;
        }

        private void loadLocationOfEncryptedFiles_Click(object sender, EventArgs e)
        {
            currentLocationOfFiles.ShowDialog();

            currentLocationEncrptedFiles.Text = currentLocationOfFiles.SelectedPath;
        }

        private void loadDestinationLocationBtn_Click(object sender, EventArgs e)
        {
            targetLocationBrowser.ShowDialog();

            targetDir.Text = targetLocationBrowser.SelectedPath;
        }

        private void excludeFileBtn_Click(object sender, EventArgs e)
        {
            exclusionList.Items.Add(excludeFile.Text);
        }

        private void removeFromExclusion_Click(object sender, EventArgs e)
        {
            ArrayList selected = new ArrayList(exclusionList.SelectedItems);
            foreach (string s in selected)
            {
                exclusionList.Items.Remove(s);
            }
        }
       

    }
}
