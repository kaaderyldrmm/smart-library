using SmartLibrary.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLibrary.Models
{
    public class Kitap : IOduncAlinabilir
    {
        public string KitapAdi { get; set; }
        public string Yazari { get; set; }
        private int sayfaSayisi;

        public int SayfaSayisi
        {
            get { return sayfaSayisi; }
            set
            {
                if (value > 0)
                {
                    sayfaSayisi = value;
                }
                else
                {
                    Console.WriteLine("Sayfa sayısı 0'dan büyük olmalıdır.");
                }
            }
        }
        public bool OduncteMi { get; private set; }


        public Kitap(string kitapAdi, string yazari)
        {
            KitapAdi = kitapAdi;
            Yazari = yazari;
        }
        public Kitap(string kitapAdi, string yazari, int sayfaSayisi)
        {
            KitapAdi = kitapAdi;
            Yazari = yazari;
            SayfaSayisi = sayfaSayisi;
        }
        public Kitap(string kitapAdi)
        {
            KitapAdi = kitapAdi;
            OduncteMi = false;
        }
        public void OduncAl()
        {
            if (OduncteMi)
            {
                Console.WriteLine("Bu kitap zaten ödünç alınmış..");
            }
            else
            {
                OduncteMi = true;
                Console.WriteLine($"\n{KitapAdi} ÖDÜNÇ ALINDI...\n");
            }
        }

        public void IadeEt()
        {
            if (!OduncteMi)
            {
                Console.WriteLine("Bu kitap zaten kütüphanede!..");
            }
            else
            {
                OduncteMi = false;
                Console.WriteLine($"{KitapAdi} başarıyla teslim edildi!..");
            }
        }
        public virtual void BilgiGetir()
        {
            if (string.IsNullOrWhiteSpace(KitapAdi))
            {
                Console.WriteLine("Kitap kaydı bulunamadı.");
                return;
            }

            Console.WriteLine($"{KitapAdi} - " +
                $"{Yazari} - " +
                $"{SayfaSayisi}");
        }
    }
}
    

