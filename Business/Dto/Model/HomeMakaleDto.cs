using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto.Model
{
   public class HomeMakaleDto
    {
        public int id { get; set; }
        public string yazar { get; set; }
        public string yazaraciklama { get; set; }

        public string baslik { get; set; }
        public int yorumSayisi { get; set; }
        public string etiket { get; set; }
        public string resimUrl { get; set; }
        public string kategori { get; set; }

        public DateTime? UploDateTime { get; set; }
        public string aciklama { get; set; }

    }
}
