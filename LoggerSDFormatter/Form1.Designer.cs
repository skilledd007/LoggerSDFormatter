namespace LoggerSDFormatter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FormatSD = new System.Windows.Forms.Button();
            this.chooseSDCard = new System.Windows.Forms.Button();
            this.SDFilePath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listCOMPorts = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UpdateTimeStampButton = new System.Windows.Forms.Button();
            this.isProductionCheckbox = new System.Windows.Forms.CheckBox();
            this.upload113 = new System.Windows.Forms.Button();
            this.upload120 = new System.Windows.Forms.Button();
            this.createTarFile = new System.Windows.Forms.Button();
            this.is4MB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormatSD
            // 
            this.FormatSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatSD.Location = new System.Drawing.Point(39, 300);
            this.FormatSD.Name = "FormatSD";
            this.FormatSD.Size = new System.Drawing.Size(303, 61);
            this.FormatSD.TabIndex = 0;
            this.FormatSD.Text = "FormatSD";
            this.FormatSD.UseVisualStyleBackColor = true;
            this.FormatSD.Click += new System.EventHandler(this.FormatSD_Click);
            // 
            // chooseSDCard
            // 
            this.chooseSDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseSDCard.Location = new System.Drawing.Point(39, 146);
            this.chooseSDCard.Name = "chooseSDCard";
            this.chooseSDCard.Size = new System.Drawing.Size(303, 63);
            this.chooseSDCard.TabIndex = 2;
            this.chooseSDCard.Text = "chooseSDCard";
            this.chooseSDCard.UseVisualStyleBackColor = true;
            this.chooseSDCard.Click += new System.EventHandler(this.chooseSDCardButton_Click);
            // 
            // SDFilePath
            // 
            this.SDFilePath.AutoSize = true;
            this.SDFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDFilePath.Location = new System.Drawing.Point(99, 238);
            this.SDFilePath.Name = "SDFilePath";
            this.SDFilePath.Size = new System.Drawing.Size(152, 31);
            this.SDFilePath.TabIndex = 3;
            this.SDFilePath.Text = "SDFilePath";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(727, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 62);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Logger Tool";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoggerSDFormatter.Properties.Resources.Screenshot_2022_07_20_134445;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 109);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 407);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // listCOMPorts
            // 
            this.listCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCOMPorts.Location = new System.Drawing.Point(371, 407);
            this.listCOMPorts.Name = "listCOMPorts";
            this.listCOMPorts.Size = new System.Drawing.Size(322, 43);
            this.listCOMPorts.TabIndex = 8;
            this.listCOMPorts.Text = "List COM Ports";
            this.listCOMPorts.UseVisualStyleBackColor = true;
            this.listCOMPorts.Click += new System.EventHandler(this.listCOMPorts_Click);
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(30, 553);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(303, 44);
            this.upload.TabIndex = 10;
            this.upload.Text = "upload_v1.1.0a";
            this.upload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateTimeStampButton
            // 
            this.UpdateTimeStampButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTimeStampButton.Location = new System.Drawing.Point(30, 680);
            this.UpdateTimeStampButton.Name = "UpdateTimeStampButton";
            this.UpdateTimeStampButton.Size = new System.Drawing.Size(303, 61);
            this.UpdateTimeStampButton.TabIndex = 17;
            this.UpdateTimeStampButton.Text = "Update Time Stamp";
            this.UpdateTimeStampButton.UseVisualStyleBackColor = true;
            this.UpdateTimeStampButton.Click += new System.EventHandler(this.UpdateTimeStampButton_Click);
            // 
            // isProductionCheckbox
            // 
            this.isProductionCheckbox.AutoSize = true;
            this.isProductionCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isProductionCheckbox.Location = new System.Drawing.Point(446, 146);
            this.isProductionCheckbox.Name = "isProductionCheckbox";
            this.isProductionCheckbox.Size = new System.Drawing.Size(205, 35);
            this.isProductionCheckbox.TabIndex = 18;
            this.isProductionCheckbox.Text = "is Production?";
            this.isProductionCheckbox.UseVisualStyleBackColor = true;
            this.isProductionCheckbox.CheckedChanged += new System.EventHandler(this.isProductionCheckbox_CheckedChanged);
            // 
            // upload113
            // 
            this.upload113.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload113.Location = new System.Drawing.Point(422, 553);
            this.upload113.Name = "upload113";
            this.upload113.Size = new System.Drawing.Size(303, 44);
            this.upload113.TabIndex = 19;
            this.upload113.Text = "upload_v1.1.3";
            this.upload113.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload113.UseVisualStyleBackColor = true;
            this.upload113.Click += new System.EventHandler(this.upload113_Click);
            // 
            // upload120
            // 
            this.upload120.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload120.Location = new System.Drawing.Point(812, 553);
            this.upload120.Name = "upload120";
            this.upload120.Size = new System.Drawing.Size(303, 44);
            this.upload120.TabIndex = 20;
            this.upload120.Text = "upload_v1.2.0";
            this.upload120.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload120.UseVisualStyleBackColor = true;
            this.upload120.Click += new System.EventHandler(this.upload120_Click);
            // 
            // createTarFile
            // 
            this.createTarFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTarFile.Location = new System.Drawing.Point(727, 146);
            this.createTarFile.Name = "createTarFile";
            this.createTarFile.Size = new System.Drawing.Size(303, 63);
            this.createTarFile.TabIndex = 21;
            this.createTarFile.Text = "createTarFile";
            this.createTarFile.UseVisualStyleBackColor = true;
            this.createTarFile.Click += new System.EventHandler(this.createTarFile_Click);
            // 
            // is4MB
            // 
            this.is4MB.AutoSize = true;
            this.is4MB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is4MB.Location = new System.Drawing.Point(83, 483);
            this.is4MB.Name = "is4MB";
            this.is4MB.Size = new System.Drawing.Size(130, 35);
            this.is4MB.TabIndex = 22;
            this.is4MB.Text = "is 4MB?";
            this.is4MB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 919);
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
            this.Name = "Form1";
            this.Text = "Logger Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormatSD;
        private System.Windows.Forms.Button chooseSDCard;
        private System.Windows.Forms.Label SDFilePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button listCOMPorts;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UpdateTimeStampButton;
        private System.Windows.Forms.CheckBox isProductionCheckbox;
        private System.Windows.Forms.Button upload113;
        private System.Windows.Forms.Button upload120;
        private System.Windows.Forms.Button createTarFile;
        private System.Windows.Forms.CheckBox is4MB;
    }
}

