using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Kategori k = new Kategori();           
            k.KategoriAdi = "telefon";

            UrunContext db = new UrunContext();

            db.Kategoriler.Add(k);
            db.SaveChanges();

            Console.WriteLine("veri kayıt edildi");

            Console.ReadLine();

        }
    }
}
