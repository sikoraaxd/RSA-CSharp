namespace _RSA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OriginalText = new System.Windows.Forms.TextBox();
            this.CipheredText = new System.Windows.Forms.TextBox();
            this.UncipheredText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GeneratePrimaries = new System.Windows.Forms.Button();
            this.PNum = new System.Windows.Forms.TextBox();
            this.QNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CipherText = new System.Windows.Forms.Button();
            this.UncipherText = new System.Windows.Forms.Button();
            this.FromFile = new System.Windows.Forms.Button();
            this.InFile = new System.Windows.Forms.Button();
            this.SecretN = new System.Windows.Forms.TextBox();
            this.SecretD = new System.Windows.Forms.TextBox();
            this.SoluteDandN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SecretE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.HackerForm = new System.Windows.Forms.Button();
            this.KeyLen = new System.Windows.Forms.TextBox();
            this.KeysGenerateOutput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OriginalText
            // 
            this.OriginalText.Location = new System.Drawing.Point(24, 349);
            this.OriginalText.Multiline = true;
            this.OriginalText.Name = "OriginalText";
            this.OriginalText.Size = new System.Drawing.Size(447, 298);
            this.OriginalText.TabIndex = 0;
            // 
            // CipheredText
            // 
            this.CipheredText.Location = new System.Drawing.Point(525, 349);
            this.CipheredText.Multiline = true;
            this.CipheredText.Name = "CipheredText";
            this.CipheredText.Size = new System.Drawing.Size(509, 298);
            this.CipheredText.TabIndex = 1;
            // 
            // UncipheredText
            // 
            this.UncipheredText.Location = new System.Drawing.Point(1082, 349);
            this.UncipheredText.Multiline = true;
            this.UncipheredText.Name = "UncipheredText";
            this.UncipheredText.Size = new System.Drawing.Size(498, 298);
            this.UncipheredText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Простые числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "p:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "q:";
            // 
            // GeneratePrimaries
            // 
            this.GeneratePrimaries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneratePrimaries.Location = new System.Drawing.Point(42, 221);
            this.GeneratePrimaries.Name = "GeneratePrimaries";
            this.GeneratePrimaries.Size = new System.Drawing.Size(339, 38);
            this.GeneratePrimaries.TabIndex = 6;
            this.GeneratePrimaries.Text = "Сгенерировать";
            this.GeneratePrimaries.UseVisualStyleBackColor = true;
            this.GeneratePrimaries.Click += new System.EventHandler(this.GeneratePrimaries_Click);
            // 
            // PNum
            // 
            this.PNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PNum.Location = new System.Drawing.Point(83, 75);
            this.PNum.Name = "PNum";
            this.PNum.ReadOnly = true;
            this.PNum.Size = new System.Drawing.Size(298, 32);
            this.PNum.TabIndex = 7;
            // 
            // QNum
            // 
            this.QNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QNum.Location = new System.Drawing.Point(83, 125);
            this.QNum.Name = "QNum";
            this.QNum.ReadOnly = true;
            this.QNum.Size = new System.Drawing.Size(298, 32);
            this.QNum.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(124, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Текст для зашифровки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(654, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Зашифрованный текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1259, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Расшифрованный текст";
            // 
            // CipherText
            // 
            this.CipherText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CipherText.Location = new System.Drawing.Point(24, 653);
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(381, 38);
            this.CipherText.TabIndex = 12;
            this.CipherText.Text = "Зашифровать";
            this.CipherText.UseVisualStyleBackColor = true;
            this.CipherText.Click += new System.EventHandler(this.CipherText_Click);
            // 
            // UncipherText
            // 
            this.UncipherText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UncipherText.Location = new System.Drawing.Point(1199, 653);
            this.UncipherText.Name = "UncipherText";
            this.UncipherText.Size = new System.Drawing.Size(381, 38);
            this.UncipherText.TabIndex = 13;
            this.UncipherText.Text = "Расшифровать";
            this.UncipherText.UseVisualStyleBackColor = true;
            this.UncipherText.Click += new System.EventHandler(this.UncipherText_Click);
            // 
            // FromFile
            // 
            this.FromFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromFile.Location = new System.Drawing.Point(583, 653);
            this.FromFile.Name = "FromFile";
            this.FromFile.Size = new System.Drawing.Size(181, 38);
            this.FromFile.TabIndex = 14;
            this.FromFile.Text = "Из файла";
            this.FromFile.UseVisualStyleBackColor = true;
            this.FromFile.Click += new System.EventHandler(this.FromFile_Click);
            // 
            // InFile
            // 
            this.InFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InFile.Location = new System.Drawing.Point(783, 653);
            this.InFile.Name = "InFile";
            this.InFile.Size = new System.Drawing.Size(181, 38);
            this.InFile.TabIndex = 15;
            this.InFile.Text = "В файл";
            this.InFile.UseVisualStyleBackColor = true;
            this.InFile.Click += new System.EventHandler(this.InFile_Click);
            // 
            // SecretN
            // 
            this.SecretN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretN.Location = new System.Drawing.Point(908, 125);
            this.SecretN.Name = "SecretN";
            this.SecretN.Size = new System.Drawing.Size(672, 32);
            this.SecretN.TabIndex = 21;
            this.SecretN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecretD
            // 
            this.SecretD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretD.Location = new System.Drawing.Point(1282, 75);
            this.SecretD.Name = "SecretD";
            this.SecretD.Size = new System.Drawing.Size(298, 32);
            this.SecretD.TabIndex = 20;
            // 
            // SoluteDandN
            // 
            this.SoluteDandN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoluteDandN.Location = new System.Drawing.Point(1082, 169);
            this.SoluteDandN.Name = "SoluteDandN";
            this.SoluteDandN.Size = new System.Drawing.Size(339, 38);
            this.SoluteDandN.TabIndex = 19;
            this.SoluteDandN.Text = "Вычислить";
            this.SoluteDandN.UseVisualStyleBackColor = true;
            this.SoluteDandN.Click += new System.EventHandler(this.SoluteDandN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(867, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "n:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1241, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "d:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1349, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Закрытый ключ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(42, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "Размер ключа:";
            // 
            // SecretE
            // 
            this.SecretE.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretE.Location = new System.Drawing.Point(908, 75);
            this.SecretE.Name = "SecretE";
            this.SecretE.Size = new System.Drawing.Size(298, 32);
            this.SecretE.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(867, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 30);
            this.label10.TabIndex = 26;
            this.label10.Text = "e:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(954, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 30);
            this.label12.TabIndex = 28;
            this.label12.Text = "Открытый ключ";
            // 
            // HackerForm
            // 
            this.HackerForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HackerForm.Location = new System.Drawing.Point(1082, 221);
            this.HackerForm.Name = "HackerForm";
            this.HackerForm.Size = new System.Drawing.Size(339, 38);
            this.HackerForm.TabIndex = 29;
            this.HackerForm.Text = "Взломщик";
            this.HackerForm.UseVisualStyleBackColor = true;
            this.HackerForm.Click += new System.EventHandler(this.HackerForm_Click);
            // 
            // KeyLen
            // 
            this.KeyLen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyLen.Location = new System.Drawing.Point(199, 173);
            this.KeyLen.Name = "KeyLen";
            this.KeyLen.Size = new System.Drawing.Size(182, 32);
            this.KeyLen.TabIndex = 30;
            // 
            // KeysGenerateOutput
            // 
            this.KeysGenerateOutput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeysGenerateOutput.Location = new System.Drawing.Point(446, 74);
            this.KeysGenerateOutput.Multiline = true;
            this.KeysGenerateOutput.Name = "KeysGenerateOutput";
            this.KeysGenerateOutput.ReadOnly = true;
            this.KeysGenerateOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeysGenerateOutput.Size = new System.Drawing.Size(381, 185);
            this.KeysGenerateOutput.TabIndex = 31;
            this.KeysGenerateOutput.TextChanged += new System.EventHandler(this.KeysGenerateOutput_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(536, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 30);
            this.label13.TabIndex = 32;
            this.label13.Text = "Генерация ключей";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 698);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.KeysGenerateOutput);
            this.Controls.Add(this.KeyLen);
            this.Controls.Add(this.HackerForm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SecretE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SecretN);
            this.Controls.Add(this.SecretD);
            this.Controls.Add(this.SoluteDandN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InFile);
            this.Controls.Add(this.FromFile);
            this.Controls.Add(this.UncipherText);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QNum);
            this.Controls.Add(this.PNum);
            this.Controls.Add(this.GeneratePrimaries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UncipheredText);
            this.Controls.Add(this.CipheredText);
            this.Controls.Add(this.OriginalText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OriginalText;
        private TextBox CipheredText;
        private TextBox UncipheredText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button GeneratePrimaries;
        private TextBox PNum;
        private TextBox QNum;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button CipherText;
        private Button UncipherText;
        private Button FromFile;
        private Button InFile;
        private TextBox SecretN;
        private TextBox SecretD;
        private Button SoluteDandN;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox SecretE;
        private Label label10;
        private Label label12;
        private Button HackerForm;
        private TextBox KeyLen;
        private TextBox KeysGenerateOutput;
        private Label label13;
    }
}