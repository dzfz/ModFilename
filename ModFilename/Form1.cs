using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace ModFilename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_run_Click(object sender, EventArgs e)
        {
            string filePath = this.textBox_filePath.Text;
            if (filePath != "" && filePath != null)
            {
                string[] filenames = Directory.GetDirectories(filePath);
                if (filenames.Length > 0)
                {
                    foreach (string pathName in filenames)
                    {
                        DirectoryInfo info = new DirectoryInfo(pathName);
                        if (info != null)
                        {
                            string name = info.Name;
                            string newName = Regex.Replace(name, @"([\S\s]+?)[ ]{1,}([\d]{4}-[\d]+-[\d]+)[ ]{1,}([\s\S]+)", @"$2 $1 $3");
                            //MessageBox.Show(filePath+"\\"+newName);
                            if (newName != "" && newName != null && !name.Equals(newName))
                            {
                                try
                                {
                                    info.MoveTo(filePath + @"\" + newName);
                                }
                                catch (IOException ioe)
                                {
                                    MessageBox.Show(ioe.Message);
                                }

                            }

                        }
                        //MessageBox.Show(name);
                        //Directory.Move()
                    }
                    MessageBox.Show("重命名完成！");
                }
                else
                {
                    MessageBox.Show("该目录中没有文件夹！");
                }

            }
            else
            {
                MessageBox.Show("文件目录不能为空！");
            }

        }

        private void button_selectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            this.textBox_filePath.Text = fbd.SelectedPath;
        }
    }
}
