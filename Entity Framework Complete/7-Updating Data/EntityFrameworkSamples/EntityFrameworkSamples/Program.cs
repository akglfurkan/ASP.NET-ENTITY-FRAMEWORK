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
            UrunContext context = new UrunContext();

            //var urun = context.Urunler.Find(1);

            //Console.WriteLine("urun id : {0} urun adı: {1} fiyat : {2}", urun.Id, urun.UrunAdi, urun.Fiyat);

            //urun.Fiyat = urun.Fiyat + (urun.Fiyat * 0.5);
            //urun.UrunAdi = "Samsung S6";
            //urun.StokAdeti += 100;          

            //context.SaveChanges();

            //urun = context.Urunler.Find(1);

            //Console.WriteLine("urun id : {0} urun adı: {1} fiyat : {2}", urun.Id, urun.UrunAdi, urun.Fiyat);


            var urunler = context.Urunler.ToList();

            foreach (var item in urunler)
            {
                Console.WriteLine("fiyat : {0}", item.Fiyat);
            }

            Console.WriteLine("--------------------------------");

            foreach (var urun in urunler)
            {
                urun.Fiyat *= 1.5;
            }

            context.SaveChanges();

            urunler = context.Urunler.ToList();

            foreach (var item in urunler)
            {
                Console.WriteLine("fiyat : {0}", item.Fiyat);
            }

            Console.ReadLine();

        }
    }
}
