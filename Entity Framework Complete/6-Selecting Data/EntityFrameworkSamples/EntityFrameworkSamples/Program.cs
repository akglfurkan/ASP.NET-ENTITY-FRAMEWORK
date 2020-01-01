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

            // List<Kategori> kategoriler = context.Kategoriler.ToList();
            //var kategoriler = context.Kategoriler.ToList();

            //foreach (var kategori in kategoriler)
            //{
            //    Console.WriteLine("kategori id : {0} kategori adı : {1}",kategori.Id,kategori.KategoriAdi);
            //}

            //var urunler = context.Urunler.ToList();

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("urun adı : {0} urun fiyatı : {1} urun stok adeti : {2}",urun.UrunAdi,urun.Fiyat,urun.StokAdeti);
            //}


            var urun = context.Urunler.Find(5);

            Console.WriteLine("urun id : {3} urun adı : {0} urun fiyatı : {1} urun stok adeti : {2}", urun.UrunAdi, urun.Fiyat, urun.StokAdeti,urun.Id);

            Console.ReadLine();

        }
    }
}
