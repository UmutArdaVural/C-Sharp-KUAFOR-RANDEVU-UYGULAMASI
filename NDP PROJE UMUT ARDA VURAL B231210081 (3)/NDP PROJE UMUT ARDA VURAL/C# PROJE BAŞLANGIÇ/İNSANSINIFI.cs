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
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace C__PROJE_BAŞLANGIÇ
{
    interface Iinsan
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string güzellikuzmanı { get; set; }

        public string işlem { get; set; }
        public DateTime tarihDegisken { get; set; }

        public int çalışmayılı { get; set; }
        public int randevuno { get; set; }
        public int telefonno { get; set; }
        public abstract void VeriYaz(int randevuno, string ad, string soyad, string güzellikuzmanı, string işlem, int ücret, DateTime tarih, int telefonno);

        public abstract void VeriOkuVeListVieweEkle(string dosyaAdi, ListView listView);
        public abstract void TariheGoreRandevulariListeyeEkle(string dosyaAdi, DateTime hedefTarih, ListView listView);
        public abstract void RandevuSil(int randevuNo, string ad, string soyad, string dosyaAdi);

        public abstract void RandevuDuzenle(int randevuNo, string ad, string soyad, DateTime yeniTarih, string yeniAd, string yeniSoyad, string yeniGuzellikUzmani, string yeniIslem, int yeniUcret, int yeniTelefonNo, string dosyaAdi);

    }
    public abstract class İNSANSINIFI : Iinsan
    {
        public string ad { get; set; }
        public string soyad { get; set; }

        public DateTime tarihDegisken { get; set; }

        public string işlem { get; set; }

        public int çalışmayılı { get; set; }

        public int randevuno { get; set; }
        public int telefonno { get; set; }

        public string güzellikuzmanı { get; set; }

        public abstract void VeriYaz(int randevuno, string ad, string soyad, string güzellikuzmanı, string işlem, int ücret, DateTime tarih, int telefonno);

        public abstract void VeriOkuVeListVieweEkle(string dosyaAdi, ListView listView);

        public abstract void TariheGoreRandevulariListeyeEkle(string dosyaAdi, DateTime hedefTarih, ListView listView);
        public abstract void RandevuSil(int randevuNo, string ad, string soyad, string dosyaAdi);
        public abstract void RandevuDuzenle(int randevuNo, string ad, string soyad, DateTime yeniTarih, string yeniAd, string yeniSoyad, string yeniGuzellikUzmani, string yeniIslem, int yeniUcret, int yeniTelefonNo, string dosyaAdi);

    }


    public class musteri : İNSANSINIFI
    {
        private string dosyaadı;


        public override void VeriOkuVeListVieweEkle(string dosyaAdi, ListView listView)
        {
            // Eğer dosya yoksa işlem yapma
            if (!File.Exists(dosyaAdi))
            {
                MessageBox.Show("Dosya bulunamadı.");
                return;
            }

            // ListView'i temizle
            listView.Items.Clear();

            // Dosyadan okuma işlemi
            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    // Satırı parçala
                    string[] veri = satir.Split('_');

                    // ListView'e ekle
                    ListViewItem item = new ListViewItem(veri);
                    listView.Items.Add(item);
                }
            }
        }

        public musteri(string dosyaadı)
        {
            this.dosyaadı = dosyaadı;
        }


        public override void VeriYaz(int randevuno, string ad, string soyad, string güzellikuzmanı, string işlem, int ücret, DateTime tarih, int telefonno)
        {
            bool saatDolu = RandevuVeSaatDoluMu(tarih, güzellikuzmanı, dosyaadı, randevuno);
            if (saatDolu)
            {
                return;
            }
            else
            {
                using (StreamWriter yazici = new StreamWriter(dosyaadı, true)) // true parametresi varsa dosyayı varsa append mode da açar
                {
                    yazici.WriteLine(randevuno + "_" + ad + "_" + soyad + "_" + güzellikuzmanı + "_" + işlem + "_" + ücret + "_" + tarih + "_" + telefonno);
                }
                MessageBox.Show("RANDEVU OLUŞTURMA BAŞARILI\n" +
                               "Randevu no: " + randevuno + "\n" +
                               "Ad: " + ad + "\n" +
                               "Soyad: " + soyad + "\n" +
                               "Güzellik uzmanı: " + güzellikuzmanı + "\n" +
                               "İşlem: " + işlem + "\n" +
                               "Ücret: " + ücret + "\n" +
                               "Tarih: " + tarih + "\n" +
                               "Telefon no: " + telefonno);
            }

        }
        private bool RandevuVeSaatDoluMu(DateTime tarih, string guzellikUzmani, string dosyaAdi, int randevuno)
        {
            string kontroledicekrandevuno = Convert.ToString(randevuno);
            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    string[] veri = satir.Split('_');
                    DateTime randevuTarihi = DateTime.Parse(veri[6]);
                    string randevuGuzellikUzmani = veri[3];
                    string kontrolrandevuno = veri[0];
                    // Belirtilen tarih ve güzellik uzmanı ile eşleşen randevu bulunduysa, saat dolu olarak işaretle
                    if (randevuTarihi.Date == tarih.Date && randevuTarihi.TimeOfDay == tarih.TimeOfDay && randevuGuzellikUzmani == guzellikUzmani)
                    {
                        MessageBox.Show("Belirtilen tarihte ve aynı güzellik uzmanında başka bir randevu bulunmaktadır. Lütfen başka bir saat veya gün seçiniz.");
                        return true;
                    }
                    else if (kontrolrandevuno == kontroledicekrandevuno)
                    {
                        MessageBox.Show("Belirtilen Randevu numarasında  başka bir randevu bulunmaktadır. Lütfen başka bir numarasında seçiniz.");
                        return true;

                    }
                }
            }
            // Belirtilen tarih ve güzellik uzmanında başka bir randevu bulunamadıysa, saat dolu değil olarak işaretle
            return false;
        }
        private bool DüzenlemeRandevuVeSaatDoluMu(DateTime tarih, string guzellikUzmani, string dosyaAdi, int randevuno, string ad, string soyad)
        {
            string kontroledicekrandevuno = Convert.ToString(randevuno);
            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    string[] veri = satir.Split('_');
                    DateTime randevuTarihi = DateTime.Parse(veri[6]);
                    string randevuGuzellikUzmani = veri[3];
                    string kontrolrandevuno = veri[0];
                    string adı = veri[1];
                    string soyadı = veri[2];


                    // Belirtilen tarih ve güzellik uzmanı ile eşleşen randevu bulunduysa, saat dolu olarak işaretle
                    if (randevuTarihi.Date == tarih.Date && randevuTarihi.TimeOfDay == tarih.TimeOfDay && randevuGuzellikUzmani == guzellikUzmani && adı == ad && soyadı == soyad)
                    {
                        MessageBox.Show("Aynı tarihli randevunuz oluşturulmuştur");
                        return false;
                    }
                    else if (randevuTarihi.Date == tarih.Date && randevuTarihi.TimeOfDay == tarih.TimeOfDay && randevuGuzellikUzmani == guzellikUzmani)
                    {
                        MessageBox.Show("Belirtilen tarihte ve aynı güzellik uzmanında başka bir randevu bulunmaktadır. Lütfen başka bir saat veya gün seçiniz.");
                        return true;

                    }
                }
            }
            // Belirtilen tarih ve güzellik uzmanında başka bir randevu bulunamadıysa, saat dolu değil olarak işaretle
            return false;
        }



        public override void RandevuSil(int randevuNo, string ad, string soyad, string dosyaAdi)
        {// Dosyadan okunan randevuların geçici bir listesi oluşturuluyor
            List<string> randevuListesi = new List<string>();

            // Dosyadan randevuları oku ve silmek istenen randevuyu filtrele
            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                bool kayitBulundu = false;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    string[] veri = satir.Split('_');

                    int randevuNoDosya = int.Parse(veri[0]);
                    string adDosya = veri[1];
                    string soyadDosya = veri[2];

                    // Silmek istenen randevuyu bul
                    if (randevuNoDosya == randevuNo && adDosya == ad && soyadDosya == soyad)
                    {
                        kayitBulundu = true;
                        MessageBox.Show("Randevu başarıyla silindi.");
                    }
                    else
                    {
                        randevuListesi.Add(satir);
                    }
                }

                // Eğer silmek istenen randevu bulunamazsa kullanıcıya bilgi ver
                if (!kayitBulundu)
                {
                    MessageBox.Show("Randevu kaydı bulunamadı.");
                    return; // Silme işlemi yapılmadı, bu yüzden işlemi sonlandır
                }
            }

            // Dosyayı yeniden yazarak silme işlemini gerçekleştir
            using (StreamWriter yazici = new StreamWriter(dosyaAdi))
            {
                foreach (string randevu in randevuListesi)
                {
                    yazici.WriteLine(randevu);
                }
            }
        }

        public override void TariheGoreRandevulariListeyeEkle(string dosyaAdi, DateTime hedefTarih, ListView listView)
        {
            // Eğer dosya yoksa işlem yapma
            if (!File.Exists(dosyaAdi))
            {
                MessageBox.Show("Dosya bulunamadı.");
                return;
            }

            // ListView'i temizle
            listView.Items.Clear();

            // Dosyadan okuma işlemi
            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    // Satırı parçala
                    string[] veri = satir.Split('_');

                    // Randevu tarihini al
                    DateTime randevuTarihi;
                    if (DateTime.TryParse(veri[6], out randevuTarihi))
                    {
                        // Eğer randevu tarihi hedef tarih ile aynı ise ListViewe ekle
                        if (randevuTarihi.Date == hedefTarih.Date)
                        {
                            // ListViewe ekleme 
                            ListViewItem item = new ListViewItem(veri);
                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }

        public override void RandevuDuzenle(int randevuNo, string ad, string soyad, DateTime yeniTarih, string yeniAd, string yeniSoyad, string yeniGuzellikUzmani, string yeniIslem, int yeniUcret, int yeniTelefonNo, string dosyaAdi)
        {
            // Dosyadan okuma ve yazma için geçici bir liste oluştur
            List<string> randevuListesi = new List<string>();

            // Dosyadan randevuları oku ve düzenlemek istenen randevuyu bul
            bool randevuBulundu = false;
            bool saatDolu = DüzenlemeRandevuVeSaatDoluMu(yeniTarih, yeniGuzellikUzmani, dosyaadı, randevuno, ad, soyad);


            if (saatDolu)
            {
                return;
            }


            else
            {

                using (StreamReader okuyucu = new StreamReader(dosyaAdi))
                {
                    string satir;
                    while ((satir = okuyucu.ReadLine()) != null)
                    {
                        string[] veri = satir.Split('_');

                        int randevuNoDosya = int.Parse(veri[0]);
                        string adDosya = veri[1];
                        string soyadDosya = veri[2];
                        DateTime tarihDosya = DateTime.Parse(veri[6]);

                        // Düzenlemek istenen randevuyu bul
                        if (randevuNoDosya == randevuNo && adDosya == ad && soyadDosya == soyad)
                        {
                            // Yeni verilerle satırı güncelle
                            string yeniSatir = randevuNo + "_" + yeniAd + "_" + yeniSoyad + "_" + yeniGuzellikUzmani + "_" + yeniIslem + "_" + yeniUcret + "_" + yeniTarih + "_" + yeniTelefonNo;
                            randevuListesi.Add(yeniSatir);
                            randevuBulundu = true;
                        }
                        else
                        {
                            randevuListesi.Add(satir);
                        }
                    }
                }

                // Eğer randevu bulunamadıysa, işlem yapma ve mesaj kutusu göster
                if (!randevuBulundu)
                {
                    MessageBox.Show("Belirtilen randevu bulunamadı.");
                    return;
                }
                else
                {
                    MessageBox.Show("Randevu başarıyla düzenlendi.");

                }

                // Dosyaya geri yazma
                using (StreamWriter yazici = new StreamWriter(dosyaAdi))
                {
                    foreach (string randevu in randevuListesi)
                    {
                        yazici.WriteLine(randevu);
                    }
                }
            }
            return;
        }



    }









    interface ICALISANİNSANSINIFI
    {
        public string ad { get; set; }
        public string soyad { get; set; }

        public DateTime işegiriştarihi { get; set; }
        public int günlükçalışmsasaati { get; set; }

        public int kimlikno { get; set; }
        public int telefonno { get; set; }

        public int yıllıktatilhakkı { get; set; }


        public abstract void Calışanekle(string ad, string soyad, DateTime işegiriştarihi, int günlükçalışmsasaati, int kimlikno, int telefonno, int tatilhakkı, int ücret, string dosyaadı);

        public abstract void CalısanSil(int calısankimlik, string ad, string soyad, string dosyaAdi);

        public abstract void Calısanlistele(ListView listView, string dosyaAdi);

    }

    public abstract class CALISANİNSANSINIFI : ICALISANİNSANSINIFI
    {
        public string ad { get; set; }
        public string soyad { get; set; }

        public DateTime işegiriştarihi { get; set; }
        public int günlükçalışmsasaati { get; set; }

        public int kimlikno { get; set; }
        public int telefonno { get; set; }

        public int yıllıktatilhakkı { get; set; }


        public abstract void Calışanekle(string ad, string soyad, DateTime işegiriştarihi, int günlükçalışmsasaati, int kimlikno, int telefonno, int tatilhakkı, int ücret, string dosyaadı);

        public string dosyaadı;

        public abstract void CalısanSil(int calısankimlik, string ad, string soyad, string dosyaAdi);

        public abstract void Calısanlistele( ListView listView, string dosyaAdi);

    }



    public class calısan : CALISANİNSANSINIFI
    {
        public calısan(string dosyaadı)
        {
            this.dosyaadı = dosyaadı;
        }

        public void calısan_combobox_ekle(ComboBox comboBox)
        {
            List<string> calışanListesi = new List<string>();

            using(StreamReader okuyucu = new StreamReader(dosyaadı))
            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    string[] veri = satir.Split('_');

                    string DOSYANoAD = veri[0];
                    string SOYadDosya = veri[1];
                    string calısanisim = DOSYANoAD + SOYadDosya;

                    calışanListesi.Add(calısanisim);

                }
            }

            foreach (string calısann in calışanListesi)
            {
                comboBox.Items.Add(calısann);


            }

        }

        public void calısandüzenle(string ad, string soyad, int kimlikno, DateTime tarihDosya,int YENİtelefonno, int günlükçalışmsasaati, int YENİtatilhakkı, int YENİücret)
        {
            List<string> calışanListesi = new List<string>();
            bool calışanbulundumu = false;


            using (StreamReader okuyucu = new StreamReader(dosyaadı))
            {

                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {  

                    string[] veri = satir.Split('_');

                    string DOSYANoAD = veri[0];
                    string SOYadDosya = veri[1];
                    int DOSYAKİMLİKNO = int.Parse(veri[4]);


                    // Düzenlemek istenen randevuyu bul
                    if (DOSYANoAD == ad && SOYadDosya == soyad && DOSYAKİMLİKNO == kimlikno)
                    {
                        // Yeni verilerle satırı güncelle

                        string yeniSatir = ad + "_" + soyad + "_" + tarihDosya + "_" + günlükçalışmsasaati + "_" + kimlikno + "_" + YENİtelefonno + "_" + YENİtatilhakkı + "_" + YENİücret;
                        calışanListesi.Add(yeniSatir);
                        calışanbulundumu=true;
                    }
                    else
                    {
                        calışanListesi.Add(satir);
                    }
                }

                
            }

            // Dosyaya geri yazma           
            // Dosyayı yeniden yazarak silme işlemini gerçekleştir
            using (StreamWriter yazıcı = new StreamWriter(dosyaadı))
            {
                foreach (string calısann in calışanListesi)
                {
                    yazıcı.WriteLine(calısann);
                }
            }

            if (calışanbulundumu == true)
            {
                MessageBox.Show("Çalışan düzenlendi ");
            }
            else
            {
                MessageBox.Show("Kayıtlı Çalışan bulunmadı");

            }
        }





















        public override void Calışanekle(string ad, string soyad, DateTime işegiriştarihi, int günlükçalışmsasaati, int kimlikno, int telefonno, int tatilhakkı, int ücret, string dosyaadı)
        { 
            bool calışankayıtlımı = false;

            string dosyaAdi = "calısan.txt";

            List<int> calısanlistesi = new List<int>();

            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                bool kayitBulundu = false;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    string[] veri = satir.Split('_');

                    int dosyakimlikno = int.Parse(veri[4]);
                    string adDosya = veri[0];
                    string soyadDosya = veri[1];
                    if (dosyakimlikno== kimlikno)
                    {
                        calışankayıtlımı = true;

                    }

                }
            }




            if (calışankayıtlımı == true)
            {
                MessageBox.Show("BU ÇALIŞAN ZATEN ÇALIŞMAKTA ");
            }

            else if (calışankayıtlımı == false)
            {

                using (StreamWriter yazici = new StreamWriter(dosyaadı, true)) // true parametresi varsa dosyayı varsa append mode da açar
                {
                    yazici.WriteLine(ad + "_" + soyad + "_" + işegiriştarihi + "_" + günlükçalışmsasaati + "_" + kimlikno + "_" + telefonno + "_" + tatilhakkı + "_" + ücret);
                }
                MessageBox.Show("ÇALIŞAN  EKLEME BAŞARILI\n" +
                                "\n" +
                               "Ad: " + ad + "\n" +
                               "Soyad: " + soyad + "\n" +
                               "işe giriş tarihi : " + işegiriştarihi + "\n" +
                               "Günlük çalışmasaati: " + günlükçalışmsasaati + "\n" +
                               "Ücret: " + ücret + "\n" +
                               "Kimlik no: " + kimlikno + "\n" +
                               "Telefon no: " + telefonno + "\n" +
                               "Tatil hakkı: " + tatilhakkı + "\n"
                               );
            }
        
        }

        public override void CalısanSil (int calısankimlik, string ad, string soyad, string dosyaAdi)
        {
            List<string> calısanlistesi = new List<string>();

            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                bool kayitBulundu = false;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    string[] veri = satir.Split('_');

                    int dosyakimlikno = int.Parse(veri[4]);
                    string adDosya = veri[0];
                    string soyadDosya = veri[1];

                    if (dosyakimlikno == calısankimlik && adDosya == ad && soyadDosya == soyad)
                    {
                        kayitBulundu = true;
                        MessageBox.Show("Çalışan başarıyla silindi.");
                    }
                    else
                    {
                        calısanlistesi.Add(satir);
                    }
                }

                if (!kayitBulundu)
                {
                    MessageBox.Show("Çalışan kaydı bulunamadı.");
                    return; // Silme işlemi yapılmadı, bu yüzden işlemi sonlandır
                }
            }

            // Dosyayı yeniden yazarak silme işlemini gerçekleştir
            using (StreamWriter yazıcı = new StreamWriter(dosyaAdi))
            {
                foreach (string satir in calısanlistesi)
                {
                    yazıcı.WriteLine(satir);
                }
            }
        }

        public override void Calısanlistele(ListView listView, string dosyaAdi)
        {
            // Eğer dosya yoksa işlem yapma
            if (!File.Exists(dosyaAdi))
            {
                MessageBox.Show("Dosya bulunamadı.");
                return;
            }

            // ListView'i temizle
            listView.Items.Clear();

            // Dosyadan okuma işlemi
            using (StreamReader okuyucu = new StreamReader(dosyaAdi))
            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                    // Satırı parçala
                    string[] veri = satir.Split('_');

                    // ListView'e ekle
                    ListViewItem item = new ListViewItem(veri);
                    listView.Items.Add(item);
                }
            }
        }

    }
}