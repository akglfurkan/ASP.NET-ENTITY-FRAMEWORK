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

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){Id=1, KategoriAdi="telefon"},
                new Kategori(){Id=1, KategoriAdi="bilgisayar"},
                new Kategori(){Id=1, KategoriAdi="tablet"}
            };


        }
    }
}
