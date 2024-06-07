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





namespace C__PROJE_BAŞLANGIÇ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dosyaAdi = "müşteri.txt";
            string dosyaAdıCalısan = "calısan.txt";
            if (!File.Exists(dosyaAdi))
            {
                File.Create(dosyaAdi).Close();
            }
            if (!File.Exists(dosyaAdıCalısan))
            {
                File.Create(dosyaAdıCalısan).Close();
            }
            musteri nesnemusteri = new musteri(dosyaAdi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 FORM2AÇ = new Form2();
            this.Hide();
            FORM2AÇ.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 FORM3AÇ = new Form3();
            this.Hide();
            FORM3AÇ.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
