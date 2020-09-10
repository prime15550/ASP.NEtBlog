using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class Tblyazar : IEntity
    {
        public Tblyazar()
        {
            TblMakale = new HashSet<TblMakale>();
        }

        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Mail { get; set; }
        public string Aciklama { get; set; }

        public virtual ICollection<TblMakale> TblMakale { get; set; }
    }
}
