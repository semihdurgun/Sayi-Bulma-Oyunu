using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıBulma
{
    public partial class Form1 : Form
    {
        int basamakSayisi;
        string isTekrarli;
        int hakSayisi;
        bool doluluk = true;
        int sayac;
        ArrayList girilenSayi = new ArrayList();
        Timer hakSüresi = new Timer();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox2.Text = comboBox2.Items[0].ToString();
            comboBox3.Text = comboBox3.Items[0].ToString();
            hakSüresi.Interval = 1000;
            hakSüresi.Tick += HakSüresi_Tick;
        }

        private void HakSüresi_Tick(object sender, EventArgs e)
        {
            sayac = Convert.ToInt32(lsecimSuresi.Text);
            sayac--;
            lsecimSuresi.Text = sayac.ToString();
            if (sayac == 0)
            {
                lsecimSuresi.Text = "10";
                hakSayisi--;
                lhakSayi.Text = hakSayisi.ToString();
                hakSüresi.Stop();
                if (hakSayisi != 0)
                {
                    hakSüresi.Start();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            basamakSayisi = Convert.ToInt32(comboBox1.SelectedItem);
            isTekrarli = comboBox2.SelectedItem.ToString();
            hakSayisi = Convert.ToInt32(comboBox3.SelectedItem);
            lsecimSuresi.Text = "10";
            lhakSayi.Text = hakSayisi.ToString();
            label1.Hide(); label2.Hide(); comboBox1.Hide(); comboBox2.Hide(); button1.Hide();comboBox3.Hide();label6.Hide();
            button3.Show();label4.Show();lsecimSuresi.Show();label5.Show();label7.Show();
            SayiOlustur(basamakSayisi, isTekrarli);
            yerlestir();
            hakSüresi.Start();  
        }
        string üretilen = "";
        public string SayiOlustur(int basamak, string tekrar)
        {
            ArrayList Liste = new ArrayList();
            int sayi;
            Random r = new Random();
            if (tekrar == "Tekrarsız")
            {
                for (int i = 0; i < basamak; i++)
                {
                    sayi = r.Next(10);
                    if (Liste.IndexOf(sayi) != -1 ) //Listenin içinde sayı yoksa -1 döndürür. 
                    {
                        i--;
                    }
                    else
                    {
                        Liste.Add(sayi);
                        üretilen += sayi.ToString();
                    }
                }
                return (üretilen);
            }
            else
            {
                for (int i = 0; i < basamak; i++)
                {
                    sayi = r.Next(10);
                    üretilen += sayi.ToString();
                }
                return (üretilen);
            }
        }
        public void yerlestir()
        {
            if (basamakSayisi == 2)
            {
                textBox1.Visible = true; textBox2.Visible = true;
            }
            if (basamakSayisi == 3) 
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true;
            }
            if(basamakSayisi == 4)
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true;
            }
            if (basamakSayisi == 5)
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true;
            }
            if (basamakSayisi == 6)
            {
                textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true;textBox6.Visible = true;
            }
        }
        public void boxAcma(int basamak)
        {
            if (basamak == 2)
            {
                if (textBox1.Text == "" || textBox2.Text == "") { doluluk = false; return; }
                if(textBox1.Text.Length != 1 || textBox2.Text.Length != 1 ) { doluluk = false; return; }
                girilenSayi.Insert(0, textBox1.Text);
                girilenSayi.Insert(1, textBox2.Text);
                if (textBox1.Enabled == true) { textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox2.Enabled == true) { textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (üretilen[0].ToString() == girilenSayi[0].ToString() && textBox1.Enabled != false)
                {
                    textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox1.Enabled = false;
                }
                else // girilen sayı üretilene eşit değil fakat üretilen sayının
                {    // içinde girilen sayı varsa rengini değiştirir.
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[0])) != -1) && textBox1.Enabled != false)
                    {
                        textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[1].ToString() == girilenSayi[1].ToString() && textBox2.Enabled != false)
                {
                    textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox2.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[1])) != -1) && textBox2.Enabled != false)
                    {
                        textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (textBox1.Enabled == false && textBox2.Enabled == false)
                {
                    int puan = hakSayisi * 10;
                    hakSüresi.Stop();
                    MessageBox.Show("Tebrikler, bildiniz. Puanınız: " + puan, "Oyun bitti");
                    StreamWriter swSkor = new StreamWriter(@"skor.txt", true);
                    swSkor.WriteLine(puan + " - " + Form2.isim.ToUpper());
                    swSkor.Close();
                    this.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
                    return;
                }
            }
            else if (basamak == 3)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") { doluluk = false; return; }
                if (textBox1.Text.Length != 1 || textBox2.Text.Length != 1 || textBox3.Text.Length != 1) { doluluk = false; return; }
                girilenSayi.Insert(0, textBox1.Text);
                girilenSayi.Insert(1, textBox2.Text);
                girilenSayi.Insert(2, textBox3.Text);
                if(textBox1.Enabled == true) { textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox2.Enabled == true) { textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox3.Enabled == true) { textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }

                if (üretilen[0].ToString() == girilenSayi[0].ToString() && textBox1.Enabled != false)
                {
                    textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox1.Enabled = false;
                }
                else // girilen sayı üretilene eşit değil fakat üretilen sayının
                {    // içinde girilen sayı varsa rengini değiştirir.
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[0])) != -1) && textBox1.Enabled != false )
                    {
                        textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[1].ToString() == girilenSayi[1].ToString() && textBox2.Enabled != false)
                {
                    textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox2.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[1])) != -1) && textBox2.Enabled != false)
                    {
                        textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[2].ToString() == girilenSayi[2].ToString() && textBox3.Enabled != false)
                {
                    textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox3.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[2])) != -1) && textBox3.Enabled != false)
                    {
                        textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (textBox1.Enabled == false && textBox2.Enabled == false && textBox3.Enabled == false)
                {
                    int puan = hakSayisi * 10;
                    hakSüresi.Stop();
                    MessageBox.Show("Tebrikler, bildiniz. Puanınız: " + puan, "Oyun bitti");
                    StreamWriter swSkor = new StreamWriter(@"skor.txt", true);
                    swSkor.WriteLine(puan + " - " + Form2.isim.ToUpper());
                    swSkor.Close();
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                    return;
                }
            }
            else if (basamak == 4)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") { doluluk = false; return; }
                if (textBox1.Text.Length != 1 || textBox2.Text.Length != 1 || textBox3.Text.Length != 1 || textBox4.Text.Length != 1) { doluluk = false; return; }
                girilenSayi.Insert(0, textBox1.Text);
                girilenSayi.Insert(1, textBox2.Text);
                girilenSayi.Insert(2, textBox3.Text);
                girilenSayi.Insert(3, textBox4.Text);
                if (textBox1.Enabled == true) { textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox2.Enabled == true) { textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox3.Enabled == true) { textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox4.Enabled == true) { textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (üretilen[0].ToString() == girilenSayi[0].ToString() && textBox1.Enabled != false)
                {
                    textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox1.Enabled = false;
                }
                else // girilen sayı üretilene eşit değil fakat üretilen sayının
                {    // içinde girilen sayı varsa rengini değiştirir.
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[0])) != -1) && textBox1.Enabled != false)
                    {
                        textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[1].ToString() == girilenSayi[1].ToString() && textBox2.Enabled != false)
                {
                    textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox2.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[1])) != -1) && textBox2.Enabled != false)
                    {
                        textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[2].ToString() == girilenSayi[2].ToString() && textBox3.Enabled != false)
                {
                    textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox3.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[2])) != -1) && textBox3.Enabled != false)
                    {
                        textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[3].ToString() == girilenSayi[3].ToString() && textBox4.Enabled != false)
                {
                    textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox4.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[3])) != -1) && textBox4.Enabled != false)
                    {
                        textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (textBox1.Enabled == false && textBox2.Enabled == false && textBox3.Enabled == false && textBox4.Enabled ==false)
                {
                    int puan = hakSayisi * 10;
                    hakSüresi.Stop();
                    MessageBox.Show("Tebrikler, bildiniz. Puanınız: " + puan, "Oyun bitti");
                    StreamWriter swSkor = new StreamWriter(@"skor.txt", true);
                    swSkor.WriteLine(puan + " - " + Form2.isim.ToUpper());
                    swSkor.Close();
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                    return;
                }
            }
            else if (basamak == 5)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "") { doluluk = false; return; }
                if (textBox1.Text.Length != 1 | textBox2.Text.Length != 1 || textBox3.Text.Length != 1 || textBox4.Text.Length != 1 || textBox5.Text.Length != 1) { doluluk = false; return; }
                girilenSayi.Insert(0, textBox1.Text);
                girilenSayi.Insert(1, textBox2.Text);
                girilenSayi.Insert(2, textBox3.Text);
                girilenSayi.Insert(3, textBox4.Text);
                girilenSayi.Insert(4, textBox5.Text);
                if (textBox1.Enabled == true) { textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox2.Enabled == true) { textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox3.Enabled == true) { textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox4.Enabled == true) { textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox5.Enabled == true) { textBox5.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (üretilen[0].ToString() == girilenSayi[0].ToString() && textBox1.Enabled != false)
                {
                    textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox1.Enabled = false;
                }
                else // girilen sayı üretilene eşit değil fakat üretilen sayının
                {    // içinde girilen sayı varsa rengini değiştirir.
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[0])) != -1) && textBox1.Enabled != false)
                    {
                        textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[1].ToString() == girilenSayi[1].ToString() && textBox2.Enabled != false)
                {
                    textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox2.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[1])) != -1) && textBox2.Enabled != false)
                    {
                        textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[2].ToString() == girilenSayi[2].ToString() && textBox3.Enabled != false)
                {
                    textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox3.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[2])) != -1) && textBox3.Enabled != false)
                    {
                        textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[3].ToString() == girilenSayi[3].ToString() && textBox4.Enabled != false)
                {
                    textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox4.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[3])) != -1) && textBox4.Enabled != false)
                    {
                        textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[4].ToString() == girilenSayi[4].ToString() && textBox5.Enabled != false)
                {
                    textBox5.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox5.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[4])) != -1) && textBox5.Enabled != false)
                    {
                        textBox5.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (textBox1.Enabled == false && textBox2.Enabled == false && textBox3.Enabled == false && textBox4.Enabled == false && textBox5.Enabled == false)
                {
                    int puan = hakSayisi * 10;
                    hakSüresi.Stop();
                    MessageBox.Show("Tebrikler, bildiniz. Puanınız: " + puan, "Oyun bitti");
                    StreamWriter swSkor = new StreamWriter(@"skor.txt", true);
                    swSkor.WriteLine(puan + " - " + Form2.isim.ToUpper());
                    swSkor.Close();
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                    return;
                }
            }
            else if (basamak == 6)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||textBox6.Text =="") { doluluk = false; return; }
                if (textBox1.Text.Length != 1 || textBox2.Text.Length != 1 || textBox3.Text.Length != 1 || textBox4.Text.Length != 1 || textBox5.Text.Length != 1 || textBox6.Text.Length != 1) { doluluk = false; return; }
                girilenSayi.Insert(0, textBox1.Text);
                girilenSayi.Insert(1, textBox2.Text);
                girilenSayi.Insert(2, textBox3.Text);
                girilenSayi.Insert(3, textBox3.Text);
                girilenSayi.Insert(4, textBox3.Text);
                girilenSayi.Insert(5, textBox3.Text);
                if (textBox1.Enabled == true) { textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox2.Enabled == true) { textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox3.Enabled == true) { textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox4.Enabled == true) { textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox5.Enabled == true) { textBox5.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (textBox6.Enabled == true) { textBox6.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); }
                if (üretilen[0].ToString() == girilenSayi[0].ToString() && textBox1.Enabled != false)
                {
                    textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox1.Enabled = false;
                }
                else // girilen sayı üretilene eşit değil fakat üretilen sayının
                {    // içinde girilen sayı varsa rengini değiştirir.
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[0])) != -1) && textBox1.Enabled != false)
                    {
                        textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[1].ToString() == girilenSayi[1].ToString() && textBox2.Enabled != false)
                {
                    textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox2.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[1])) != -1) && textBox2.Enabled != false)
                    {
                        textBox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[2].ToString() == girilenSayi[2].ToString() && textBox3.Enabled != false)
                {
                    textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox3.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[2])) != -1) && textBox3.Enabled != false)
                    {
                        textBox3.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[3].ToString() == girilenSayi[3].ToString() && textBox4.Enabled != false)
                {
                    textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox4.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[3])) != -1) && textBox4.Enabled != false)
                    {
                        textBox4.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[4].ToString() == girilenSayi[4].ToString() && textBox5.Enabled != false)
                {
                    textBox5.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox5.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[4])) != -1) && textBox5.Enabled != false)
                    {
                        textBox5.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (üretilen[5].ToString() == girilenSayi[5].ToString() && textBox6.Enabled != false)
                {
                    textBox6.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                    textBox6.Enabled = false;
                }
                else
                {
                    if ((üretilen.IndexOf(Convert.ToChar(girilenSayi[5])) != -1) && textBox6.Enabled != false)
                    {
                        textBox6.BackColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
                    }
                }
                if (textBox1.Enabled == false && textBox2.Enabled == false && textBox3.Enabled == false && textBox4.Enabled == false && textBox5.Enabled == false && textBox6.Enabled==false)
                {
                    int puan = hakSayisi * 10;
                    hakSüresi.Stop();
                    MessageBox.Show("Tebrikler, bildiniz. Puanınız: " + puan, "Oyun bitti");
                    StreamWriter swSkor = new StreamWriter(@"skor.txt", true);
                    swSkor.WriteLine(puan + " - " + Form2.isim.ToUpper());
                    swSkor.Close();
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                    return;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            boxAcma(basamakSayisi);
            if (hakSayisi == 1)
            {
                lhakSayi.Text = hakSayisi.ToString();
                hakSüresi.Stop();
                MessageBox.Show("Hakkınız Kalmadı.Yeni oyun için tıklayınız.", "Oyun Bitti!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                return;
            }
            if (doluluk != false)
            {
                hakSayisi--;
                lsecimSuresi.Text = "10";
                lhakSayi.Text = hakSayisi.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen her kutuya tek bir değer yazınız.","Uyarı!");
                doluluk = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int bas = Convert.ToInt32(e.KeyChar);
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
            if (bas >= 48 && bas <= 57)
            {
                e.Handled = false; //sadece sayı ise yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false; // backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa yazdırma.
            }
        }
    }   
} 
