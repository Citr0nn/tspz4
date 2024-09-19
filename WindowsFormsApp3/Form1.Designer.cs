namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttoninfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonclose = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rbGB = new System.Windows.Forms.RadioButton();
            this.rbMB = new System.Windows.Forms.RadioButton();
            this.rbKB = new System.Windows.Forms.RadioButton();
            this.rbBytes = new System.Windows.Forms.RadioButton();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.lblBytesResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoninfo
            // 
            this.buttoninfo.Location = new System.Drawing.Point(698, 12);
            this.buttoninfo.Name = "buttoninfo";
            this.buttoninfo.Size = new System.Drawing.Size(90, 23);
            this.buttoninfo.TabIndex = 0;
            this.buttoninfo.Text = "Про програму";
            this.buttoninfo.UseVisualStyleBackColor = true;
            this.buttoninfo.Click += new System.EventHandler(this.buttoninfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(180, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Розмір файлу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bytes:";
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(698, 415);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(90, 23);
            this.buttonclose.TabIndex = 4;
            this.buttonclose.Text = "Закрити";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click_1);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(602, 415);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(90, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Виконати";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rbGB
            // 
            this.rbGB.AutoSize = true;
            this.rbGB.Location = new System.Drawing.Point(85, 418);
            this.rbGB.Name = "rbGB";
            this.rbGB.Size = new System.Drawing.Size(40, 17);
            this.rbGB.TabIndex = 6;
            this.rbGB.TabStop = true;
            this.rbGB.Text = "GB";
            this.rbGB.UseVisualStyleBackColor = true;
            // 
            // rbMB
            // 
            this.rbMB.AutoSize = true;
            this.rbMB.Location = new System.Drawing.Point(131, 418);
            this.rbMB.Name = "rbMB";
            this.rbMB.Size = new System.Drawing.Size(41, 17);
            this.rbMB.TabIndex = 7;
            this.rbMB.TabStop = true;
            this.rbMB.Text = "MB";
            this.rbMB.UseVisualStyleBackColor = true;
            this.rbMB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbKB
            // 
            this.rbKB.AutoSize = true;
            this.rbKB.Location = new System.Drawing.Point(177, 418);
            this.rbKB.Name = "rbKB";
            this.rbKB.Size = new System.Drawing.Size(39, 17);
            this.rbKB.TabIndex = 8;
            this.rbKB.TabStop = true;
            this.rbKB.Text = "KB";
            this.rbKB.UseVisualStyleBackColor = true;
            // 
            // rbBytes
            // 
            this.rbBytes.AutoSize = true;
            this.rbBytes.Location = new System.Drawing.Point(223, 418);
            this.rbBytes.Name = "rbBytes";
            this.rbBytes.Size = new System.Drawing.Size(51, 17);
            this.rbBytes.TabIndex = 9;
            this.rbBytes.TabStop = true;
            this.rbBytes.Text = "Bytes";
            this.rbBytes.UseVisualStyleBackColor = true;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(131, 365);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(100, 20);
            this.txtFileSize.TabIndex = 10;
            // 
            // lblBytesResult
            // 
            this.lblBytesResult.AutoSize = true;
            this.lblBytesResult.Location = new System.Drawing.Point(655, 368);
            this.lblBytesResult.Name = "lblBytesResult";
            this.lblBytesResult.Size = new System.Drawing.Size(0, 13);
            this.lblBytesResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBytesResult);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.rbBytes);
            this.Controls.Add(this.rbKB);
            this.Controls.Add(this.rbMB);
            this.Controls.Add(this.rbGB);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttoninfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RadioButton rbGB;
        private System.Windows.Forms.RadioButton rbMB;
        private System.Windows.Forms.RadioButton rbKB;
        private System.Windows.Forms.RadioButton rbBytes;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Label lblBytesResult;
    }
}

