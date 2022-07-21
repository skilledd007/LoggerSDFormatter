﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;


namespace LoggerSDFormatter
{
    public partial class Form1 : Form
    {
        string sdFolder = "";
        string comPort = "";
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

        private void listCOMPorts_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            String[] ports = SerialPort.GetPortNames();

            for (int i = 0; i < ports.Length; i++)
            {
                comboBox1.Items.Add(ports[i]);
            }
            

        }

        private void upload_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C \"python.exe\" \"esptool.py\" --chip esp32 --port \"" + comboBox1.GetItemText(comboBox1.SelectedItem) + "\" --baud 460800 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 40m --flash_size detect 0x1000 bootloader_dio_40m.bin 0x8000 partitions.bin 0xe000 boot_app0.bin";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
