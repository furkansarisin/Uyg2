using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap();
            k1.adi = "Fareler ve Insanlar";
            k1.yazari = "John Steinbeck";
            k1.oduncVer();

            Kitap k2 = new Kitap();
            k2.adi = "Hayvan Ciftligi";
            k2.yazari = "George Orwell";
            k2.oduncVer();

            Kitap.statikMetot();
        }
    }
}