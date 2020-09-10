using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class Tblyorum : IEntity
    {
        public int Id { get; set; }
        public string Yorum { get; set; }
        public DateTime? Date { get; set; }
        public int UserId { get; set; }
        public int MakaleId { get; set; }

        public virtual TblMakale Makale { get; set; }
        public virtual Tblkullanici User { get; set; }
    }
}
