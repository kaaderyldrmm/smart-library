using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLibrary.Models
{
    public class Kullanici
    {
        public string Ad { get; set; }
         private int numara;

     public int Numara
    {
        get { return numara; }
        set
        {
            if (value > 0)
            {
                numara = value;
            }
            else
            {
                Console.WriteLine("Numara 0'dan büyük olmalı!");
            }
        }
    }


        public Kullanici(string ad, int numara)
        {
            Ad = ad;
            Numara = numara;
        }

        public virtual void BilgiGoster()
        {
            Console.WriteLine($"Kullanıcı:{Ad}");
            Console.WriteLine($"Numara: {Numara}");
        }

    }
}
