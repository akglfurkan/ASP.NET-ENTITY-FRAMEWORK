using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples
{
    public class Kategori
    {
        //Kategori tablosunun birincil anahtarı olarak işaretleniz.
        // varsayılan olarak otomatik sayı olarak ayarlanır.
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
    }
}
