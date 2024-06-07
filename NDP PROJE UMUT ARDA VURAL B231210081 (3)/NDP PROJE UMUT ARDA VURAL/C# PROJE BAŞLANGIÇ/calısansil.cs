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
    public partial class calısansil : Form
    {
        public calısansil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosyaAdıCalısan = "calısan.txt";
            calısan CALISAN = new calısan(dosyaAdıCalısan);

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                int kimlikno = Convert.ToInt32(textBox1.Text);
                string ad = Convert.ToString(textBox2.Text);
                string soyad = Convert.ToString(textBox3.Text);

                CALISAN.CalısanSil(kimlikno, ad, soyad, dosyaAdıCalısan);


            }
            else
            {
                MessageBox.Show(" HATA !!!Doldurmanız gereken heryeri doldurunuz  ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5aç = new Form5();

            this.Close();
            f5aç.Show();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }
    }
}
