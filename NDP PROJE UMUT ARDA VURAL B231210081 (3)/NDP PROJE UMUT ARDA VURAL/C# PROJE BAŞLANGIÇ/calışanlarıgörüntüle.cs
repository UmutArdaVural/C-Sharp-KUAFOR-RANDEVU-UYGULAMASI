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
    public partial class calışanlarıgörüntüle : Form
    {
        public calışanlarıgörüntüle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 F5AÇ = new Form5();
            this.Hide();
            F5AÇ.Show();
        }

        private void calışanlarıgörüntüle_Load(object sender, EventArgs e)
        {
            string dosyaAdıCalısan = "calısan.txt";
            calısan CALISAN = new calısan(dosyaAdıCalısan);
            CALISAN.Calısanlistele(listView1, dosyaAdıCalısan);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
