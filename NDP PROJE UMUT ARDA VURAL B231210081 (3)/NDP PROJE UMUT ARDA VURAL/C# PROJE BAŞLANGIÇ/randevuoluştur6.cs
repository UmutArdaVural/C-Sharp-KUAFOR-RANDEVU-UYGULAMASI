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
    public partial class randevuoluştur6 : Form
    {
        public randevuoluştur6()
        {
            InitializeComponent();
        }

        private void randevuoluştur6_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ShowUpDown = false; // Saat seçimini kapatma

            string dosyaAdıCalısan = "calısan.txt";
            calısan CALISAN = new calısan(dosyaAdıCalısan);
            CALISAN.calısan_combobox_ekle(comboBox3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaAdi = "müşteri.txt"; // Dosya adı
            musteri nesnemusteri = new musteri(dosyaAdi);

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox3.SelectedIndex !=1)
            {
                string ad = Convert.ToString(textBox1.Text);
                string soyad = Convert.ToString(textBox2.Text);
                int randevuno = Convert.ToInt32(textBox3.Text);
                int iletişimno = Convert.ToInt32(textBox4.Text);

                // yapılcak işlem
                string işlem = comboBox1.SelectedItem.ToString();

                // uzman işlem
                string güzellikuzmnaı = comboBox3.SelectedItem.ToString();

                // ücret
                string stringücret = comboBox2.SelectedItem.ToString();
                int ücret = Convert.ToInt32(stringücret);


                // zaman
                DateTime secilenZaman = dateTimePicker1.Value;
                string secilensaat = comboBox4.SelectedItem.ToString();
                int sevilensaat = Convert.ToInt32(secilensaat);
                int hour = sevilensaat;
                int minute = 0;

                // Seçilen tarih ve dışardan verilen saat ile yeni bir DateTime oluşturma
                DateTime combinedDateTime = new DateTime(secilenZaman.Year, secilenZaman.Month, secilenZaman.Day, hour, minute, 0);

                nesnemusteri.VeriYaz(randevuno, ad, soyad, güzellikuzmnaı, işlem, ücret, combinedDateTime, iletişimno); // nesneden fonksiyon çağırılır 


            }
            else
            {
                MessageBox.Show(" HATA !!!Doldurmanız gereken heryeri doldurunuz");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4geç = new Form4();
            this.Hide();
            form4geç.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
