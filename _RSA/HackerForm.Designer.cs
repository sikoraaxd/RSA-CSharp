namespace _RSA
{
    partial class HackeForm
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
            this.FactorizeNum = new System.Windows.Forms.Button();
            this.QNum = new System.Windows.Forms.TextBox();
            this.PNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecretN = new System.Windows.Forms.TextBox();
            this.SecretE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SecretD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FactorizeNum
            // 
            this.FactorizeNum.Location = new System.Drawing.Point(70, 180);
            this.FactorizeNum.Name = "FactorizeNum";
            this.FactorizeNum.Size = new System.Drawing.Size(289, 45);
            this.FactorizeNum.TabIndex = 0;
            this.FactorizeNum.Text = "Разложить";
            this.FactorizeNum.UseVisualStyleBackColor = true;
            this.FactorizeNum.Click += new System.EventHandler(this.FactorizeNum_Click);
            // 
            // QNum
            // 
            this.QNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QNum.Location = new System.Drawing.Point(70, 313);
            this.QNum.Name = "QNum";
            this.QNum.ReadOnly = true;
            this.QNum.Size = new System.Drawing.Size(298, 32);
            this.QNum.TabIndex = 12;
            // 
            // PNum
            // 
            this.PNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PNum.Location = new System.Drawing.Point(70, 263);
            this.PNum.Name = "PNum";
            this.PNum.ReadOnly = true;
            this.PNum.Size = new System.Drawing.Size(298, 32);
            this.PNum.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "q:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "p:";
            // 
            // SecretN
            // 
            this.SecretN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretN.Location = new System.Drawing.Point(70, 115);
            this.SecretN.Name = "SecretN";
            this.SecretN.Size = new System.Drawing.Size(298, 32);
            this.SecretN.TabIndex = 16;
            // 
            // SecretE
            // 
            this.SecretE.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretE.Location = new System.Drawing.Point(70, 65);
            this.SecretE.Name = "SecretE";
            this.SecretE.Size = new System.Drawing.Size(298, 32);
            this.SecretE.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "e:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(117, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 30);
            this.label12.TabIndex = 29;
            this.label12.Text = "Открытый ключ";
            // 
            // SecretD
            // 
            this.SecretD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretD.Location = new System.Drawing.Point(70, 363);
            this.SecretD.Name = "SecretD";
            this.SecretD.ReadOnly = true;
            this.SecretD.Size = new System.Drawing.Size(298, 32);
            this.SecretD.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "d:";
            // 
            // HackeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 435);
            this.Controls.Add(this.SecretD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SecretN);
            this.Controls.Add(this.SecretE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QNum);
            this.Controls.Add(this.PNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FactorizeNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HackeForm";
            this.Text = "Взлом";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FactorizeNum;
        private TextBox QNum;
        private TextBox PNum;
        private Label label3;
        private Label label2;
        private TextBox SecretN;
        private TextBox SecretE;
        private Label label1;
        private Label label4;
        private Label label12;
        private TextBox SecretD;
        private Label label5;
    }
}