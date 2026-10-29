using SmartLibrary.Models;
using static SmartLibrary.Models.Kullanici;
List<Kitap> kitaplar = new List<Kitap>();
List<Kullanici>kullanicilar=new List<Kullanici>();

Kitap kitap1 = new Kitap("UĞULTULU TEPELER", "EMİLY BRONTE", 405);
Kitap kitap2 = new Kitap("İKİ ŞEHRİN HİKAYESİ","CHARLES DICKENS",494 );
Kitap kitap3 = new Kitap("MARTIN EDEN", "JACK LONDON", 494);
Kitap kitap4 = new Kitap("ALGERNON'A ÇİÇEKLER","DANIEL KEYES", 325);
Kitap kitap5 = new Kitap("DAVA", "FRANZ KAFKA",244);
Kitap kitap6 = new Kitap("AGATHA CHRİSTİE", "CİNAYETLER OTELİ",158);
Kitap kitap7 = new Kitap("BİLİNÇALTININ GÜCÜ" , "JOSEPH MURPHY", 286);

kitaplar.Add(kitap1);
kitaplar.Add(kitap2);
kitaplar.Add(kitap3);
kitaplar.Add(kitap4);
kitaplar.Add(kitap5);
kitaplar.Add(kitap6);
kitaplar.Add(kitap7);


bool devam = true;
while (devam)
{
    Console.WriteLine("\n============ AKILLI KÜTÜPHANE ===========\n");
    Console.WriteLine("1. Kitap Ekle");
    Console.WriteLine("2. Kitapları Listele");
    Console.WriteLine("3. Kitap Ödünç Al ");
    Console.WriteLine("4. Kitap İade Et");
    Console.WriteLine("5. Kullanıcı Bilgilerini Görüntüle");
    Console.WriteLine("6. Çıkış");
    Console.WriteLine("\n=========================================\n");
    
    Console.Write("Seçiminiz: ");
    int secim=Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.Write("\nEklemek istediğiniz kitap adı: ");
            string kitapAdi=Console.ReadLine();

            Console.Write("Eklem istediğiniz kitabın yazarı: ");
            string yazari=Console.ReadLine();

            Console.Write("Eklemek istediğiniz kitabın sayfa sayısı: ");
            int sayfaSayisi=Convert.ToInt32(Console.ReadLine());

            Kitap yeniKitap = new Kitap(kitapAdi, yazari, sayfaSayisi);
            kitaplar.Add(yeniKitap);

            Console.WriteLine("KİTABINIZ BAŞARIYLA EKLENDİ!..");

            break;

            case 2:

            Console.WriteLine("\n========= Kütüphanedeki Kitaplar ============\n");

             foreach(Kitap kitap in kitaplar)
            { 
                kitap.BilgiGetir();
                Console.WriteLine("---------------------------------------------\n");

            }

            break;

            case 3:

            Console.WriteLine("\n========= Kütüphanedeki Kitaplar ============\n");

            foreach (Kitap kitap in kitaplar)
            {
                kitap.BilgiGetir();
                Console.WriteLine("---------------------------------------------\n");

            }

            Console.Write("\nÖdünç Almak İstediğiniz Kitabın Adı: ");
            string oduncAl=Console.ReadLine();
            
            bool bulundu=false;
            foreach (Kitap kitap in kitaplar)
            {
                if (kitap.KitapAdi.Equals(oduncAl,StringComparison.OrdinalIgnoreCase))
                {
                    kitap.OduncAl();
                    bulundu = true;
                    break;
                }
            }
            if (!bulundu)
            {
                Console.WriteLine("ARANILAN KİTAP KÜTÜPHANEDE BULUNAMADI!..");
            }

            break;

            case 4:
            Console.Write("\nİade Etmek İstediğiniz Kitabın Adı: ");
            string IadeEt = Console.ReadLine();

            bool bul = false;
            foreach (Kitap kitap in kitaplar)
            {
                if (kitap.KitapAdi.Equals(IadeEt, StringComparison.OrdinalIgnoreCase))
                {
                    kitap.IadeEt();
                    bul = true;
                    break;
                }
            }
            if (!bul)
            {
                Console.WriteLine("ARANILAN KİTABIN KÜTÜPHANE KAYDI BULUNAMADI!..");
            }
            break;


        case 5:
            Console.WriteLine("\n=============== KULLANICI BİLGİLERİ ===============\n");

            Console.WriteLine("1. Öğrenci");
            Console.WriteLine("2. Öğretmen");
            Console.Write("\nKullanıcı Seçiniz: ");

            string seciminiz = Console.ReadLine();

            Console.Write("Adınızı girin: ");
            string ad = Console.ReadLine();

            Console.Write("Numaranızı girin: ");
            int numara = Convert.ToInt32(Console.ReadLine());

            Kullanici kullanici;

            if (seciminiz == "1")
            {
                kullanici = new Ogrenci(ad, numara);
            }
            else if (seciminiz == "2")
            {
                kullanici = new Ogretmen(ad, numara);
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı!");
                break;
            }
            kullanicilar.Add(kullanici);

            Console.WriteLine("Kullanıcı Kaydedildi...");
            kullanici.BilgiGoster();
            break;

        case 6:

            devam = false;
            Console.WriteLine("ÇIKIŞ YAPILIYOR...");
            Console.ReadKey();

            break;

        default: 
            Console.WriteLine("TANIMSIZ SEÇİM YAPTINIZ!..");
            break;
    }
}
Console.ReadKey();