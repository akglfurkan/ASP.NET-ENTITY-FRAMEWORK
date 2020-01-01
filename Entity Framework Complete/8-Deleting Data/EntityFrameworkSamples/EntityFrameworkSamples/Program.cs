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

            UrunContext db = new UrunContext();

            //var urun = db.Urunler.Find(2);

            //if (urun != null)
            //{
            //    db.Urunler.Remove(urun);
            //}

            //db.SaveChanges();

            var urunler = db.Urunler.ToList();

            foreach (var urun in urunler)
            {
                db.Urunler.Remove(urun);
            }

            db.SaveChanges();

            if (db.Urunler.Count() == 0)
            {
                Console.WriteLine("veritabanında ürün bulunamadı");
            }
            else
            {
                foreach (var item in db.Urunler)
                {
                    Console.WriteLine("urun id : {0} urun adı : {1}", item.Id, item.UrunAdi);
                }
            }

            Console.ReadLine();

        }
    }
}
