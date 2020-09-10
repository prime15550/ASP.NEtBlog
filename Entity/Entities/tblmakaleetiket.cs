using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class Tblmakaleetiket : IEntity
    {
        public int MakaleId { get; set; }
        public int EtiketId { get; set; }

        public virtual Tbletiket Etiket { get; set; }
        public virtual TblMakale Makale { get; set; }
    }
}
