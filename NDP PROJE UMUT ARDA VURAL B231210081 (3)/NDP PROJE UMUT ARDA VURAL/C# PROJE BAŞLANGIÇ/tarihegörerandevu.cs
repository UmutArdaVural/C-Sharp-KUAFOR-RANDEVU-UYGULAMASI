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
    public partial class tarihegörerandevu : Form
    {

        public tarihegörerandevu()
        {
            InitializeComponent();
        }

        private void tarihegörerandevu_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            string dosyaAdi = "müşteri.txt"; // Dosya adı
            musteri nesnemusteri = new musteri(dosyaAdi);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime secilenZaman = dateTimePicker1.Value;

            string dosyaAdi = "müşteri.txt"; // Dosya adı
            musteri nesnemusteri = new musteri(dosyaAdi);
            nesnemusteri.TariheGoreRandevulariListeyeEkle(dosyaAdi, secilenZaman, listView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 for4aç = new Form4();
            this.Close();
            for4aç.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
