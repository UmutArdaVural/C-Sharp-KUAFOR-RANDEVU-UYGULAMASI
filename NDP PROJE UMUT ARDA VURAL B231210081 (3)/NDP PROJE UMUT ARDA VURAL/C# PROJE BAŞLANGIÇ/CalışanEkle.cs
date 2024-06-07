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
    public partial class CalışanEkle : Form
    {
        public CalışanEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaAdıCalısan = "calısan.txt";
            calısan CALISAN = new calısan(dosyaAdıCalısan);

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                string ad = Convert.ToString(textBox1.Text);
                string soyad = Convert.ToString(textBox2.Text);
                int kimlikno = Convert.ToInt32(textBox3.Text);
                int iletişimno = Convert.ToInt32(textBox4.Text);

                // yapılcak işlem
                string tatilhakkı = comboBox1.SelectedItem.ToString();
                int tatilhakkıı = Convert.ToInt32(tatilhakkı);


                // ücret
                string stringücret = comboBox2.SelectedItem.ToString();
                int ücret = Convert.ToInt32(stringücret);

                //CALISMASAATİ
                string calışmasaati = comboBox4.SelectedItem.ToString();
                int guncelcalışmasaati = Convert.ToInt32(calışmasaati);

                // zaman
                DateTime secilenZaman = dateTimePicker1.Value;
                int hour = 8;
                int minute = 0;


                DateTime combinedDateTime = new DateTime(secilenZaman.Year, secilenZaman.Month, secilenZaman.Day, hour, minute, 0);
                CALISAN.Calışanekle(ad, soyad, combinedDateTime, guncelcalışmasaati, kimlikno, iletişimno, tatilhakkıı, ücret, dosyaAdıCalısan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
