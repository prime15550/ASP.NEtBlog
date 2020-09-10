using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class TblKategori : IEntity
    
    {
        public TblKategori()
        {
            TblMakale = new HashSet<TblMakale>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }

        public virtual ICollection<TblMakale> TblMakale { get; set; }
    }
}
