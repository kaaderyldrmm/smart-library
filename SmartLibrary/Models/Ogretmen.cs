using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLibrary.Models
{
    public class Ogretmen : Kullanici
    {
        public Ogretmen(string ad, int numara)
            : base(ad, numara)
        {
        }
        public override void BilgiGoster()
        {
            Console.WriteLine($"Öğretmen adı: {Ad}");
            Console.WriteLine($"Öğretmen numarası: {Numara}");
        }
    }
}
