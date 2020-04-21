using System;
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
    public partial class Form2 : Form
    {
        public static string isim;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fsSkor = new FileStream(@"skor.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fsSkor.Close();
            if (textBox1.Text.Length > 0 && (String.IsNullOrWhiteSpace(textBox1.Text)) != true)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                isim = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Lütfen isminizi giriniz");
            }
        }
    }
}
