namespace SayıBulma
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lhakSayi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lsecimSuresi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(224, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basamak sayısını seçiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tekrarlı mı tekrarsız mı ?";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tekrarlı",
            "Tekrarsız"});
            this.comboBox2.Location = new System.Drawing.Point(224, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(63, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oyuna Başla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Visible = false;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(20, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Visible = false;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(20, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Visible = false;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(167, 121);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(20, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Visible = false;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox3.Location = new System.Drawing.Point(185, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kalan Hakkınız :";
            this.label4.Visible = false;
            // 
            // lhakSayi
            // 
            this.lhakSayi.AutoSize = true;
            this.lhakSayi.Location = new System.Drawing.Point(124, 174);
            this.lhakSayi.Name = "lhakSayi";
            this.lhakSayi.Size = new System.Drawing.Size(0, 13);
            this.lhakSayi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hak sayısını seçiniz.";
            // 
            // lsecimSuresi
            // 
            this.lsecimSuresi.AutoSize = true;
            this.lsecimSuresi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsecimSuresi.Location = new System.Drawing.Point(135, 315);
            this.lsecimSuresi.Name = "lsecimSuresi";
            this.lsecimSuresi.Size = new System.Drawing.Size(22, 16);
            this.lsecimSuresi.TabIndex = 11;
            this.lsecimSuresi.Text = "10";
            this.lsecimSuresi.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bu hak için";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(160, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "saniyeniz kaldı.";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 416);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsecimSuresi);
            this.Controls.Add(this.lhakSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Sayı Bulma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lhakSayi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lsecimSuresi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

