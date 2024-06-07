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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__PROJE_BAŞLANGIÇ
{
    public partial class randevusil : Form
    {
        public randevusil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4aç = new Form4();
            this.Close();
            f4aç.Show();
        }

        private void randevusil_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string dosyaAdi = "müşteri.txt"; // Dosya adı
            musteri nesnemusteri = new musteri(dosyaAdi);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                int randevuno = Convert.ToInt32(textBox1.Text);
                string ad = Convert.ToString(textBox2.Text);
                string soyad = Convert.ToString(textBox3.Text);

                nesnemusteri.RandevuSil(randevuno, ad, soyad, dosyaAdi);


            }
            else
            {
                MessageBox.Show(" HATA !!!Doldurmanız gereken heryeri doldurunuz  ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
