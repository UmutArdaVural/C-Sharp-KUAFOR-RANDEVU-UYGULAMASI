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
    public partial class randevugörünüle : Form
    {
        public randevugörünüle()
        {
            InitializeComponent();
            string dosyaAdi = "müşteri.txt"; // Dosya adı
            musteri nesnemusteri = new musteri(dosyaAdi);
            nesnemusteri.VeriOkuVeListVieweEkle(dosyaAdi, listView1);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4geç = new Form4();
            this.Hide();
            form4geç.Show();

        }

        private void randevugörünüle_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
