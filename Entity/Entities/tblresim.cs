using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class Tblresim : IEntity
    {
        public int Id { get; set; }
        public string ResimUrl { get; set; }
        public int MakaleId { get; set; }

        public virtual TblMakale Makale { get; set; }
    }
}
