using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Package4CS
{
    public partial class Form1 : Form
    {
        private int nMode = 2;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.txtSource.Text = Properties.Settings.Default.Source;
            this.txtDest.Text = Properties.Settings.Default.Dest;
            this.txtPackageId.Text = Properties.Settings.Default.PackageID;
            nMode = Properties.Settings.Default.Mode;
            if (nMode == 1) radioButton1.Checked = true;
            if (nMode == 2) radioButton2.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var dia = new FolderBrowserDialog();
            if (dia.ShowDialog() == DialogResult.OK)
            {
                this.txtSource.Text = dia.SelectedPath;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var dia = new FolderBrowserDialog();
            if (dia.ShowDialog() == DialogResult.OK)
            {
                this.txtDest.Text = dia.SelectedPath;
            }
        }

        List<string> soureList = new List<string>() { "src", "cssrc", "sys", "cssys", "web" };

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var destPath = this.txtDest.Text;
            var sourcePath = this.txtSource.Text;
            var packageIds = txtPackageId.Lines;

            if (string.IsNullOrEmpty(destPath) || string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("Folder is Empty!!!");
                return;
            }

            if (packageIds.Length == 0 || packageIds.FirstOrDefault(o => o.Length > 0) == null)
            {
                MessageBox.Show("Please input condition!!!");
                return;
            }

            var dirInfo = Directory.GetDirectories(sourcePath);

            int count = 0;
            foreach (var src in soureList)
            {
                foreach (var item in dirInfo)
                {
                    if (item.Contains(src))
                    {
                        count++;
                    }
                }
            }
            //if (count == 0)
            //{
            //    MessageBox.Show("Please select CIS Source Folder!!");
            //    return;
            //}

            destPath = (destPath + "\\").Replace("\\\\", "\\");
            sourcePath = (sourcePath + "\\").Replace("\\\\", "\\");

            Properties.Settings.Default.Source = sourcePath;
            Properties.Settings.Default.Dest = destPath;
            Properties.Settings.Default.PackageID = this.txtPackageId.Text;
            Properties.Settings.Default.Mode = nMode;
            Properties.Settings.Default.Save();

            var fileInfoList = new List<FileInfo>();
            //foreach (var item in soureList)
            //{
                fileInfoList.AddRange(getFiles(sourcePath));
            //}

            if (!Directory.Exists(destPath + "Document"))
            {
                Directory.CreateDirectory(destPath + "Document");
            }

            if (!Directory.Exists(destPath + "Test"))
            {
                Directory.CreateDirectory(destPath + "Test");
            }

            if (!Directory.Exists(destPath + "Source"))
            {
                Directory.CreateDirectory(destPath + "Source");
            }

            destPath = destPath + "Source";
            TextBox1.Text = string.Empty;
            if (nMode == 2)
            {
                foreach (var packageId in packageIds)
                {
                    ProgressBar1.Maximum = fileInfoList.Count;
                    ProgressBar1.Value = 0;
                    foreach (var fileinfo in fileInfoList)
                    {
                        ProgressBar1.Value += 1;
                        string alltext = string.Empty;
                        try
                        {
                            alltext = File.ReadAllText(fileinfo.FullName);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                        if (alltext.Contains(packageId))
                        {
                            var dir = fileinfo.Directory.FullName.Replace(sourcePath, "");
                            var destDir = (destPath + "\\" + dir + "\\").Replace("\\\\", "\\");
                            if (!Directory.Exists(destDir))
                            {
                                Directory.CreateDirectory(destDir);
                            }
                            File.Copy(fileinfo.FullName, destDir + fileinfo.Name, true);
                            TextBox1.Text += fileinfo.FullName + Environment.NewLine;
                        }
                        Application.DoEvents();
                    }
                }
            }
            else if (nMode == 1)
            {
                ProgressBar1.Maximum = packageIds.Length;
                ProgressBar1.Value = 0;
                foreach (var packageId in packageIds)
                {
                    ProgressBar1.Value += 1;
                    if (string.IsNullOrEmpty(packageId))
                    {
                        continue;
                    }
                    var fileName = packageId.Replace("/", "\\");
                    var fullName = sourcePath + fileName;
                    if (File.Exists(fullName))
                    {
                        var fileinfo = new FileInfo(fullName);
                        var dir = fileinfo.Directory.FullName.Replace(sourcePath, "");
                        var destDir = (destPath + "\\" + dir + "\\").Replace("\\\\", "\\");
                        if (!Directory.Exists(destDir))
                        {
                            Directory.CreateDirectory(destDir);
                        }
                        File.Copy(fileinfo.FullName, destDir + fileinfo.Name, true);
                        TextBox1.Text += fileinfo.FullName + Environment.NewLine;
                    }
                    else
                    {
                        TextBox1.Text += packageId + "*********************NoFound***************" + Environment.NewLine;
                    }
                    Application.DoEvents();
                }
            }
            MessageBox.Show("Completed!!");
        }

        public List<FileInfo> getFiles(string path)
        {
            try
            {
                List<FileInfo> lst = new List<FileInfo>();
                if (Directory.Exists(path))
                {
                    string[] dir = Directory.GetDirectories(path);
                    DirectoryInfo fdir = new DirectoryInfo(path);
                    FileInfo[] files = fdir.GetFiles();
                    if (files.Length != 0 || dir.Length != 0)
                    {
                        lst.AddRange(files);
                        foreach (string d in dir)
                        {
                            lst.AddRange(getFiles(d));
                        }
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var rdo = sender as RadioButton;
            if (rdo.Name == "radioButton1")
            {
                nMode = 1;
            }
            else if (rdo.Name == "radioButton2")
            {
                nMode = 2;
            }
        }
    }
}
