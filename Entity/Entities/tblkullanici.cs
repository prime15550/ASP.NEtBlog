using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class Tblkullanici : IEntity
    {
        public Tblkullanici()
        {
            Tblyorum = new HashSet<Tblyorum>();
        }

        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Tblyorum> Tblyorum { get; set; }
    }
}
