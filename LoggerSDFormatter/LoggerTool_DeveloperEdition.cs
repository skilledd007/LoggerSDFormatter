using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerSDFormatter
{
    public partial class LoggerTool_DeveloperEdition : Form
    {
        private readonly Form1 _form1;
        public LoggerTool_DeveloperEdition(Form1 form1)
        {
            InitializeComponent();
            this.FormClosing += LoggerTool_DeveloperEdition_FormClosing;
            _form1 = form1;
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerTool_DeveloperEdition));
            this.GoToDevVersion = new System.Windows.Forms.Button();
            this.serialEnterOK = new System.Windows.Forms.Button();
            this.serialNumLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.is4MB = new System.Windows.Forms.CheckBox();
            this.createTarFile = new System.Windows.Forms.Button();
            this.upload120 = new System.Windows.Forms.Button();
            this.upload113 = new System.Windows.Forms.Button();
            this.isProductionCheckbox = new System.Windows.Forms.CheckBox();
            this.UpdateTimeStampButton = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.listCOMPorts = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SDFilePath = new System.Windows.Forms.Label();
            this.chooseSDCard = new System.Windows.Forms.Button();
            this.FormatSD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToDevVersion
            // 
            this.GoToDevVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToDevVersion.Location = new System.Drawing.Point(729, 232);
            this.GoToDevVersion.Name = "GoToDevVersion";
            this.GoToDevVersion.Size = new System.Drawing.Size(303, 63);
            this.GoToDevVersion.TabIndex = 44;
            this.GoToDevVersion.Text = "I am Normal";
            this.GoToDevVersion.UseVisualStyleBackColor = true;
            this.GoToDevVersion.Click += new System.EventHandler(this.GoToDevVersion_Click);
            // 
            // serialEnterOK
            // 
            this.serialEnterOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialEnterOK.Location = new System.Drawing.Point(448, 335);
            this.serialEnterOK.Name = "serialEnterOK";
            this.serialEnterOK.Size = new System.Drawing.Size(122, 45);
            this.serialEnterOK.TabIndex = 43;
            this.serialEnterOK.Text = "OK";
            this.serialEnterOK.UseVisualStyleBackColor = true;
            // 
            // serialNumLabel
            // 
            this.serialNumLabel.AutoSize = true;
            this.serialNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumLabel.Location = new System.Drawing.Point(39, 291);
            this.serialNumLabel.Name = "serialNumLabel";
            this.serialNumLabel.Size = new System.Drawing.Size(98, 31);
            this.serialNumLabel.TabIndex = 42;
            this.serialNumLabel.Text = "Serial#";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(45, 335);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 31);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = "";
            // 
            // is4MB
            // 
            this.is4MB.AutoSize = true;
            this.is4MB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is4MB.Location = new System.Drawing.Point(81, 576);
            this.is4MB.Name = "is4MB";
            this.is4MB.Size = new System.Drawing.Size(130, 35);
            this.is4MB.TabIndex = 40;
            this.is4MB.Text = "is 4MB?";
            this.is4MB.UseVisualStyleBackColor = true;
            // 
            // createTarFile
            // 
            this.createTarFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTarFile.Location = new System.Drawing.Point(729, 122);
            this.createTarFile.Name = "createTarFile";
            this.createTarFile.Size = new System.Drawing.Size(303, 63);
            this.createTarFile.TabIndex = 39;
            this.createTarFile.Text = "createTarFile";
            this.createTarFile.UseVisualStyleBackColor = true;
            // 
            // upload120
            // 
            this.upload120.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload120.Location = new System.Drawing.Point(810, 646);
            this.upload120.Name = "upload120";
            this.upload120.Size = new System.Drawing.Size(303, 44);
            this.upload120.TabIndex = 38;
            this.upload120.Text = "upload_v1.2.0";
            this.upload120.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload120.UseVisualStyleBackColor = true;
            // 
            // upload113
            // 
            this.upload113.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload113.Location = new System.Drawing.Point(420, 646);
            this.upload113.Name = "upload113";
            this.upload113.Size = new System.Drawing.Size(303, 44);
            this.upload113.TabIndex = 37;
            this.upload113.Text = "upload_v1.1.3";
            this.upload113.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload113.UseVisualStyleBackColor = true;
            // 
            // isProductionCheckbox
            // 
            this.isProductionCheckbox.AutoSize = true;
            this.isProductionCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isProductionCheckbox.Location = new System.Drawing.Point(448, 122);
            this.isProductionCheckbox.Name = "isProductionCheckbox";
            this.isProductionCheckbox.Size = new System.Drawing.Size(205, 35);
            this.isProductionCheckbox.TabIndex = 36;
            this.isProductionCheckbox.Text = "is Production?";
            this.isProductionCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdateTimeStampButton
            // 
            this.UpdateTimeStampButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTimeStampButton.Location = new System.Drawing.Point(28, 773);
            this.UpdateTimeStampButton.Name = "UpdateTimeStampButton";
            this.UpdateTimeStampButton.Size = new System.Drawing.Size(303, 61);
            this.UpdateTimeStampButton.TabIndex = 35;
            this.UpdateTimeStampButton.Text = "Update Time Stamp";
            this.UpdateTimeStampButton.UseVisualStyleBackColor = true;
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(28, 646);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(303, 44);
            this.upload.TabIndex = 34;
            this.upload.Text = "upload_v1.1.0a";
            this.upload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload.UseVisualStyleBackColor = true;
            // 
            // listCOMPorts
            // 
            this.listCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCOMPorts.Location = new System.Drawing.Point(369, 500);
            this.listCOMPorts.Name = "listCOMPorts";
            this.listCOMPorts.Size = new System.Drawing.Size(322, 43);
            this.listCOMPorts.TabIndex = 33;
            this.listCOMPorts.Text = "List COM Ports";
            this.listCOMPorts.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 500);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoggerSDFormatter.Properties.Resources.Screenshot_2022_07_20_134445;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 109);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(511, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(697, 62);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Logger Tool Developer Edition";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SDFilePath
            // 
            this.SDFilePath.AutoSize = true;
            this.SDFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDFilePath.Location = new System.Drawing.Point(101, 214);
            this.SDFilePath.Name = "SDFilePath";
            this.SDFilePath.Size = new System.Drawing.Size(152, 31);
            this.SDFilePath.TabIndex = 29;
            this.SDFilePath.Text = "SDFilePath";
            // 
            // chooseSDCard
            // 
            this.chooseSDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseSDCard.Location = new System.Drawing.Point(41, 122);
            this.chooseSDCard.Name = "chooseSDCard";
            this.chooseSDCard.Size = new System.Drawing.Size(303, 63);
            this.chooseSDCard.TabIndex = 28;
            this.chooseSDCard.Text = "chooseSDCard";
            this.chooseSDCard.UseVisualStyleBackColor = true;
            this.chooseSDCard.Click += new System.EventHandler(this.chooseSDCard_Click);
            // 
            // FormatSD
            // 
            this.FormatSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatSD.Location = new System.Drawing.Point(41, 400);
            this.FormatSD.Name = "FormatSD";
            this.FormatSD.Size = new System.Drawing.Size(303, 61);
            this.FormatSD.TabIndex = 27;
            this.FormatSD.Text = "FormatSD";
            this.FormatSD.UseVisualStyleBackColor = true;
            // 
            // LoggerTool_DeveloperEdition
            // 
            this.ClientSize = new System.Drawing.Size(1229, 875);
            this.Controls.Add(this.GoToDevVersion);
            this.Controls.Add(this.serialEnterOK);
            this.Controls.Add(this.serialNumLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.is4MB);
            this.Controls.Add(this.createTarFile);
            this.Controls.Add(this.upload120);
            this.Controls.Add(this.upload113);
            this.Controls.Add(this.isProductionCheckbox);
            this.Controls.Add(this.UpdateTimeStampButton);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.listCOMPorts);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SDFilePath);
            this.Controls.Add(this.chooseSDCard);
            this.Controls.Add(this.FormatSD);
            this.Name = "LoggerTool_DeveloperEdition";
            this.Text = "LoggerTool -> Developer Edition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chooseSDCard_Click(object sender, EventArgs e)
        {
            
        }

        private void GoToDevVersion_Click(object sender, EventArgs e)
        {
            this.Close();
            _form1.Show();
        }
        private void LoggerTool_DeveloperEdition_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
