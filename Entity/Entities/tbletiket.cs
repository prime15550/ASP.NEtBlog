using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities

{
    public partial class Tbletiket : IEntity
    {
        public Tbletiket()
        {
            Tblmakaleetiket = new HashSet<Tblmakaleetiket>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }

        public virtual ICollection<Tblmakaleetiket> Tblmakaleetiket { get; set; }
    }
}
