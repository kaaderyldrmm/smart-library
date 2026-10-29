using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLibrary.Models
{
   
        public class Ogrenci : Kullanici
        {
     
        public Ogrenci(string ad, int numara)
                : base(ad, numara)
            {
            }
            public override void BilgiGoster()
            {
                Console.WriteLine($"Öğrenci adı: {Ad}");
                Console.WriteLine($"Öğrenci numarası: {Numara}");
            }
        }
    }

