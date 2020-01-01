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
            // LINQ  (language integrated Query)

            UrunContext context = new UrunContext();

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){ UrunAdi="Samsung S4",Fiyat=2000, StokAdeti=100, Satistami=true},
                new Urun(){ UrunAdi="Samsung S5",Fiyat=3000, StokAdeti=100, Satistami=true},
                new Urun(){ UrunAdi="Samsung S6",Fiyat=4000, StokAdeti=100, Satistami=true},
                new Urun(){ UrunAdi="Samsung S7",Fiyat=5000, StokAdeti=100, Satistami=true},
                new Urun(){ UrunAdi="Samsung S8",Fiyat=6000, StokAdeti=100, Satistami=true},
            };

            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);
            }

            context.SaveChanges();

            Console.WriteLine("kayıt edildi.");
            Console.ReadLine();

        }
    }
}
