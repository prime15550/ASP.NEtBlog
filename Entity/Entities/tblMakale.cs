using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class TblMakale : IEntity
    {
        public TblMakale()
        {
            Tblmakaleetiket = new HashSet<Tblmakaleetiket>();
            Tblresim = new HashSet<Tblresim>();
            Tblyorum = new HashSet<Tblyorum>();
        }

        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime? Yuklemetarihi { get; set; }
        public int YazarId { get; set; }
        public int KategoriId { get; set; }

        public virtual TblKategori Kategori { get; set; }
        public virtual Tblyazar Yazar { get; set; }
        public virtual ICollection<Tblmakaleetiket> Tblmakaleetiket { get; set; }
        public virtual ICollection<Tblresim> Tblresim { get; set; }
        public virtual ICollection<Tblyorum> Tblyorum { get; set; }
    }
}
