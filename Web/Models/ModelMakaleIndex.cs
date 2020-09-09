using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class ModelMakaleIndex
    {
        public int Id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public DateTime? yuklemetarihi { get; set; }
        public int yazarId { get; set; }
        public int KategoriId { get; set; }

    }
}