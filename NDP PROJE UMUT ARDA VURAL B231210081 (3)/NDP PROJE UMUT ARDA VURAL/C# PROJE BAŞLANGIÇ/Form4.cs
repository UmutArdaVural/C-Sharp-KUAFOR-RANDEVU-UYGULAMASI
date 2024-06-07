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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randevuoluştur6 randevuıoluşturaç = new randevuoluştur6();

            this.Hide();
            randevuıoluşturaç.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            randevugörünüle randevuaç = new randevugörünüle();
            this.Hide();
            randevuaç.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1aç = new Form1();
            this.Hide();
            f1aç.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tarihegörerandevu aç = new tarihegörerandevu();
            this.Hide();
            aç.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            randevusil açsilrand = new randevusil();
            this.Hide();
            açsilrand.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            randevudüzenle rdaç = new randevudüzenle();

            this.Hide();
            rdaç.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
