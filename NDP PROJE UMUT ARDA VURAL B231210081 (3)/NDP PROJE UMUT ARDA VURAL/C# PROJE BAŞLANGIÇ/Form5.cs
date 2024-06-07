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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6aç = new Form6();
            this.Close();
            f6aç.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalışanEkle aç = new CalışanEkle();
            this.Close();
            aç.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calısansil aç = new calısansil();
            this.Close();
            aç.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calışanlarıgörüntüle aç = new calışanlarıgörüntüle();
            this.Close();
            aç.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { 
            
            calışandüzenle a = new calışandüzenle();
            this.Hide();
            a.Show();

        }


    }
}
