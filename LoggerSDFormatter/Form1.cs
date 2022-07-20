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

namespace LoggerSDFormatter
{
    public partial class Form1 : Form
    {
        string sdFolder = "";
        public Form1()
        {
            InitializeComponent();
            SDFilePath.Text = "Select SD card";
        }
        private void chooseSDCardButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // shows the path to the selected folder in the folder dialog
                sdFolder = fbd.SelectedPath;
            SDFilePath.Text = sdFolder;
        }
        private void FormatSD_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(sdFolder);
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo subDirectory in di.EnumerateDirectories())
            {
                subDirectory.Delete(true);
            }
            di.CreateSubdirectory("batteryinfo");
            di.CreateSubdirectory("customerinfo");
            di.CreateSubdirectory("data");
            di.CreateSubdirectory("logs");
            di.CreateSubdirectory("settings");
            di.CreateSubdirectory("tests");
            di.CreateSubdirectory("webapp");
            string[] dirs = Directory.GetDirectories(sdFolder, "*", SearchOption.AllDirectories);
            File.Create(Path.Combine(dirs[0], "batteryinfo.txt"));
            File.Create(Path.Combine(dirs[1], "customerinfo.txt"));
            File.Create(Path.Combine(dirs[1], "infofilled.txt"));
            File.Create(Path.Combine(dirs[1], "installerinfo.txt")); 
            FileStream settingsFile = File.Create(Path.Combine(dirs[4], "settings.txt"));
            Byte[] title = new UTF8Encoding(true).GetBytes("Battery Wizard\n");
            settingsFile.Write(title, 0, title.Length);
            settingsFile.Close();
            StatusMessage.Text = "Success!!";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
