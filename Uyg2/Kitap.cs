using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2
{
    
    class Kitap
    {
        public string adi;
        public string yazari;
        static int oduncKitap = 0;


        public void oduncVer()
        {
            Console.WriteLine(yazari + "tarafindan yazilan " + adi +
                " isimli kitap odun verildi.");
            oduncKitap++;
            Console.WriteLine("Odunc verilen kitap sayısı: " + oduncKitap);
            
        }
        public static void statikMetot()
        {
            Console.WriteLine("Ben bir statik metodum");
            
            

        }

    }
}
