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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FormatSD = new System.Windows.Forms.Button();
            this.chooseSDCard = new System.Windows.Forms.Button();
            this.SDFilePath = new System.Windows.Forms.Label();
            this.StatusMessage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listCOMPorts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormatSD
            // 
            this.FormatSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatSD.Location = new System.Drawing.Point(330, 366);
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
            this.chooseSDCard.Location = new System.Drawing.Point(330, 183);
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
            this.SDFilePath.Location = new System.Drawing.Point(390, 287);
            this.SDFilePath.Name = "SDFilePath";
            this.SDFilePath.Size = new System.Drawing.Size(152, 31);
            this.SDFilePath.TabIndex = 3;
            this.SDFilePath.Text = "SDFilePath";
            // 
            // StatusMessage
            // 
            this.StatusMessage.AutoSize = true;
            this.StatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusMessage.Location = new System.Drawing.Point(390, 465);
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(202, 31);
            this.StatusMessage.TabIndex = 4;
            this.StatusMessage.Text = "StatusMessage";
            this.StatusMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(508, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 62);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Logger SD Formatter";
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
            this.comboBox1.Location = new System.Drawing.Point(330, 534);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // listCOMPorts
            // 
            this.listCOMPorts.Location = new System.Drawing.Point(690, 532);
            this.listCOMPorts.Name = "listCOMPorts";
            this.listCOMPorts.Size = new System.Drawing.Size(195, 23);
            this.listCOMPorts.TabIndex = 8;
            this.listCOMPorts.Text = "List COM Ports";
            this.listCOMPorts.UseVisualStyleBackColor = true;
            this.listCOMPorts.Click += new System.EventHandler(this.listCOMPorts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(330, 641);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(303, 44);
            this.upload.TabIndex = 10;
            this.upload.Text = "upload";
            this.upload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 919);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listCOMPorts);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StatusMessage);
            this.Controls.Add(this.SDFilePath);
            this.Controls.Add(this.chooseSDCard);
            this.Controls.Add(this.FormatSD);
            this.Name = "Form1";
            this.Text = "LoggerSDFormatter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormatSD;
        private System.Windows.Forms.Button chooseSDCard;
        private System.Windows.Forms.Label SDFilePath;
        private System.Windows.Forms.Label StatusMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button listCOMPorts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button upload;
    }
}

