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
    public partial class randevudüzenle : Form
    {
        public randevudüzenle()
        {
            InitializeComponent();
        }

        private void randevudüzenle_Load(object sender, EventArgs e)
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

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {
                string ad = Convert.ToString(textBox5.Text);
                string soyad = Convert.ToString(textBox4.Text);
                int randevuno = Convert.ToInt32(textBox6.Text);

                string yeniad = Convert.ToString(textBox1.Text);
                string yenisoyad = Convert.ToString(textBox3.Text);
                string yeniişlem = comboBox1.SelectedItem.ToString();
                int yenitelefonno = Convert.ToInt32(textBox2.Text);
                // uzman işlem
                string yenigüzellikuzmnaı = comboBox3.SelectedItem.ToString();

                // ücret
                string yenistringücret = comboBox2.SelectedItem.ToString();
                int yeniücret = Convert.ToInt32(yenistringücret);

                // DateTime YENİsecilenZaman = dateTimePicker1.Value;
                DateTime secilenZaman = dateTimePicker1.Value;
                string secilensaat = comboBox4.SelectedItem.ToString();
                int sevilensaat = Convert.ToInt32(secilensaat);
                int hour = sevilensaat;
                int minute = 0;

                // Seçilen tarih ve dışardan verilen saat ile yeni bir DateTime oluşturma
                DateTime combinedDateTime = new DateTime(secilenZaman.Year, secilenZaman.Month, secilenZaman.Day, hour, minute, minute);

                nesnemusteri.RandevuDuzenle(randevuno, ad, soyad, combinedDateTime, yeniad, yenisoyad, yenigüzellikuzmnaı, yeniişlem, yeniücret, yenitelefonno, dosyaAdi);

            }

            else
            {
                MessageBox.Show(" HATA !!! Doldurmanız gereken heryeri doldurunuz");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4aç = new Form4();
            this.Hide();

            f4aç.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
