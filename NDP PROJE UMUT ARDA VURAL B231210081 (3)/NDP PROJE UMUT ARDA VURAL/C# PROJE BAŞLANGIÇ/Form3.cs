/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				PROJE NUMARASI..........: 1
**				ÖĞRENCİ ADI............: UMUT ARDA VURAL 
**				ÖĞRENCİ NUMARASI.......: b231210081
**              DERSİN ALINDIĞI GRUP...: B 
****************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__PROJE_BAŞLANGIÇ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kuladı = "yönetici";
            string şifre = "yönetici";

            if (textBox1.Text == kuladı && textBox2.Text == şifre && doğrulamalbl.Text == textBox3.Text)
            {
                Form6 f6aç = new Form6();
                this.Hide();
                f6aç.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgiler ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Random doğrulamakodu = new Random();

            int Ydoğrulamakodu = doğrulamakodu.Next(1000, 9999);

            doğrulamalbl.Text = Ydoğrulamakodu.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
