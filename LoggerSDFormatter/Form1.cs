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
using System.IO.Ports;
using System.Diagnostics;
using SharpCompress.Writers;
using Aspose.Zip.Tar;

namespace LoggerSDFormatter
{
    public partial class Form1 : Form
    {
        string sdFolder = "";
        string comPort = "";
        string binFilePath = "";
        string buildFolder = "";
        string serialNumber = "";
        Boolean isProduction=false;
        public Form1()
        {
            InitializeComponent();
            buildFolder = Directory.GetCurrentDirectory();
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
        private void FormatSDCard()
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please enter in a serial number!!", "ERROR!");
            }
            else
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
                di.CreateSubdirectory("time");
                di.CreateSubdirectory("defaultpage");
                di.CreateSubdirectory("flags");
                di.CreateSubdirectory("state");
                di.CreateSubdirectory("webapp_alt");
                string[] dirs = Directory.GetDirectories(sdFolder, "*", SearchOption.AllDirectories);
                File.Create(Path.Combine(dirs[0], "batteryinfo.txt")).Dispose();
                File.Create(Path.Combine(dirs[0], "batteryinfofilled.txt")).Dispose();
                File.Create(Path.Combine(dirs[1], "customerinfo.txt")).Dispose();
                File.Create(Path.Combine(dirs[1], "customerinfofilled.txt")).Dispose();
                File.Create(Path.Combine(dirs[1], "installerinfo.txt")).Dispose();
                File.Create(Path.Combine(dirs[1], "installerinfofilled.txt")).Dispose();
                File.Create(Path.Combine(dirs[3],"changelog.txt")).Dispose();
                File.Create(Path.Combine(dirs[8], "buttonchecked.txt")).Dispose();
                File.Create(Path.Combine(dirs[9], "curr_snsr_cal.txt")).Dispose();
                File.Create(Path.Combine(dirs[10], "calibration.txt")).Dispose();
                File.Create(Path.Combine(dirs[10], "amp_hours.txt")).Dispose();
                File.Create(Path.Combine(dirs[10], "update_status.txt")).Dispose();


                FileStream rtcFile = File.Create(Path.Combine(dirs[9], "rtc.txt"));
                Byte[] stringasbytes = new UTF8Encoding(true).GetBytes("0\n");
                rtcFile.Write(stringasbytes, 0, stringasbytes.Length);
                rtcFile.Close();

                FileStream settingsFile = File.Create(Path.Combine(dirs[4], "settings.txt"));
                Byte[] title = new UTF8Encoding(true).GetBytes("Battery Wizard " + serialNumber + "\n");
                settingsFile.Write(title, 0, title.Length);
                settingsFile.Close();
                FileStream timeFile = File.Create(Path.Combine(dirs[7], "starting_time.txt"));
                //Get Unix time
                String timeString = DateTimeOffset.Now.ToUnixTimeSeconds().ToString() + "\n";
                Byte[] timestamp = new UTF8Encoding(true).GetBytes(timeString);
                timeFile.Write(timestamp, 0, timestamp.Length);
                timeFile.Close();
                DirectoryInfo di2 = new DirectoryInfo(Path.Combine(sdFolder, "webapp"));
                foreach (FileInfo file in di2.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo subDirectory in di2.EnumerateDirectories())
                {
                    subDirectory.Delete(true);
                }
                foreach (string dirPath in Directory.GetDirectories(Path.Combine(Directory.GetCurrentDirectory(), "build"), "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(Path.Combine(Directory.GetCurrentDirectory(), "build"), Path.Combine(sdFolder, "webapp")));
                }
                var allFiles = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "build"), "*.*", SearchOption.AllDirectories);

                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(Path.Combine(Directory.GetCurrentDirectory(), "build"), Path.Combine(sdFolder, "webapp")));
                }
                string[] paths = { Directory.GetCurrentDirectory(), "dne_webpage", "index.html" };
                string[] paths2 = { sdFolder, "webapp_alt", "index.html" };
                File.Copy(Path.Combine(paths), Path.Combine(paths2)); 

                DialogResult res = MessageBox.Show("Formatted SD Card Successfully and Loaded Webapp! ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text = "";
                serialNumber = richTextBox1.Text;
                if (res == DialogResult.OK)
                {


                }
            }
        }
        private void FormatSD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isProductionCheckbox.Checked)
                {
                    DialogResult ressy = MessageBox.Show("Are you sure you want to format the SD card? Doing so will delete All existing Data", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (ressy == DialogResult.OK)
                    {
                        FormatSDCard();

                    }
                }
                else
                {
                    FormatSDCard();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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
            //strCmdText = "/C python -m esptool --chip esp32 --port \"" + comboBox1.GetItemText(comboBox1.SelectedItem) + "\" --baud 460800 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 40m --flash_size detect 0x1000 bootloader_dio_40m.bin 0x8000 partitions.bin 0xe000 boot_app0.bin 0x10000 firmware.bin";
            string[] paths = { Directory.GetCurrentDirectory(), "v1.1.0a", "firmware.bin" };
            String[] paths2 = { Directory.GetCurrentDirectory(), "4MBPart", "partitions.bin" };

            strCmdText = "/K python -m esptool --chip esp32 --port \"" + comboBox1.GetItemText(comboBox1.SelectedItem) + "\" --baud 460800 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 40m --flash_size detect 0x1000 bootloader_dio_40m.bin 0x8000 " + Path.Combine(paths2) + " 0xe000 boot_app0.bin 0x10000 " +  Path.Combine(paths);

            try
            {
                //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                ProcessStartInfo info = new ProcessStartInfo("Process.exe");
                info.UseShellExecute = false;
                info.Verb = "runas";
                Process.Start("CMD.exe",strCmdText);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectBinFilePath_Click(object sender, EventArgs e)
        {
            
        }

        private void chooseBuildFolder_Click(object sender, EventArgs e)
        {
            
        }

        private void UploadFrontEnd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string newPath in Directory.GetFiles(buildFolder, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(buildFolder, sdFolder), true);
                }
                MessageBox.Show("Successfully Updated Front-End","SUCCESS");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void UpdateTimeStampButton_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories(sdFolder, "*", SearchOption.AllDirectories);
           
           if(!dirs.Contains("time"))
            {
                DirectoryInfo di = new DirectoryInfo(sdFolder);
                di.CreateSubdirectory("time");
            }
            dirs = Directory.GetDirectories(sdFolder, "*", SearchOption.AllDirectories); // Run it again if the time directory did not exist anymore.
            FileStream timeFile = File.Create(Path.Combine(dirs[7], "starting_time.txt"));
            //Get Unix time
            String timeString = DateTimeOffset.Now.ToUnixTimeSeconds().ToString() + "\n";
            Byte[] timestamp = new UTF8Encoding(true).GetBytes(timeString);
            timeFile.Write(timestamp, 0, timestamp.Length);
            timeFile.Close();

        }

        private void isProductionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void upload113_Click(object sender, EventArgs e)
        {
            string strCmdText;
            //strCmdText = "/C python -m esptool --chip esp32 --port \"" + comboBox1.GetItemText(comboBox1.SelectedItem) + "\" --baud 460800 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 40m --flash_size detect 0x1000 bootloader_dio_40m.bin 0x8000 partitions.bin 0xe000 boot_app0.bin 0x10000 firmware.bin";
            string[] paths = { Directory.GetCurrentDirectory(), "v1.1.3", "firmware.bin" };
            String[] paths2 = { Directory.GetCurrentDirectory(), "8MBPart", "partitions.bin" };
            if (is4MB.Checked.Equals(true))
            {
                paths2[1] = "4MBPart";

            }
            strCmdText = "/K python -m esptool --chip esp32 --port \"" + comboBox1.GetItemText(comboBox1.SelectedItem) + "\" --baud 460800 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 40m --flash_size detect 0x1000 bootloader_dio_40m.bin 0x8000 " + Path.Combine(paths2) + " 0xe000 boot_app0.bin 0x10000 " + Path.Combine(paths);

            try
            {
                //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                ProcessStartInfo info = new ProcessStartInfo("Process.exe");
                info.UseShellExecute = false;
                info.Verb = "runas";
                Process.Start("CMD.exe", strCmdText);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upload120_Click(object sender, EventArgs e)
        {
            string strCmdText;
            //strCmdText = "/C python -m esptool --chip esp32 --port \"" + comboBox1.GetItemText(comboBox1.SelectedItem) + "\" --baud 460800 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 40m --flash_size detect 0x1000 bootloader_dio_40m.bin 0x8000 partitions.bin 0xe000 boot_app0.bin 0x10000 firmware.bin";
            String[] paths = { Directory.GetCurrentDirectory(), "v1.2.0-8MB", "firmware.bin" };
            String[] paths2 = { Directory.GetCurrentDirectory(), "8MBPart", "partitions.bin" };
            if (is4MB.Checked.Equals(true))
            {
                paths[1] = "v1.2.0-4MB";
                paths2[1] = "4MBPart";

            } 
            strCmdText = "/K python -m esptool --chip esp32 --port \"" + comboBox1.GetItemText(comboBox1.SelectedItem) + "\" --baud 460800 --before default_reset --after hard_reset write_flash -z --flash_mode dio --flash_freq 40m --flash_size detect 0x1000 bootloader_dio_40m.bin 0x8000 " +  Path.Combine(paths2) + " 0xe000 boot_app0.bin 0x10000 " + Path.Combine(paths);

            try
            {
                //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                ProcessStartInfo info = new ProcessStartInfo("Process.exe");
                info.UseShellExecute = false;
                info.Verb = "runas";
                Process.Start("CMD.exe", strCmdText);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectBuildFolder_Click(object sender, EventArgs e)
        {
           
        }

        private void createTarFile_Click(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "webapp_update.tar")))
                {
                    File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "webapp_update.tar"));
                }
                string strCmdText1 = "/K set PATH=%PATH%;C:\\Program Files\\7-Zip\\";
                string strCmdText2 = "/K 7z a webapp_update.tar ";
                DirectoryInfo di2 = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "build"));
                foreach (FileInfo file in di2.EnumerateFiles())
                {
                    strCmdText2 = strCmdText2 + " " + file.FullName;
                }
                foreach (DirectoryInfo subDirectory in di2.EnumerateDirectories())
                {
                    strCmdText2 = strCmdText2 + " " + subDirectory.FullName;
                }
                ProcessStartInfo info = new ProcessStartInfo("Process.exe");
                info.UseShellExecute = false;
                info.Verb = "runas";
                Process.Start("CMD.exe", strCmdText1);
                Process.Start("CMD.exe", strCmdText2);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serialEnterOK_Click(object sender, EventArgs e)
        {
            
            
                DialogResult ressy = MessageBox.Show("The serial Number entered is " + richTextBox1.Text, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ressy == DialogResult.OK)
                {
                    serialNumber = richTextBox1.Text;
                }
            
         
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void GoToDevVersion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoggerTool_DeveloperEdition form = new LoggerTool_DeveloperEdition(this);
            form.Show();
        }
    }
}
