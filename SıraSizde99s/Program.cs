using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıraSizde99s
{
    class Bilgi
    {
        public void Ad(ref string isim,ref string soyad,ref int yas)
            
        {
            isim = "Levent";
            soyad = "Yanık";
            yas = 15;
        }

    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            string isim = "efe";
            string soyad = "dokumaci";
            int yas = 17;
            Bilgi bilgi = new Bilgi();
            bilgi.Ad(ref isim, ref soyad, ref yas);

            Console.WriteLine("Önceki değerler");
            Console.WriteLine("ad="+isim);
            Console.WriteLine(  "soyad="+soyad );
            Console.WriteLine("yas=" + yas);
        }
    }
}
