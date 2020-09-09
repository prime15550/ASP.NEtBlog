using Core.Entities;
using System;

namespace Entity.Entities
{
  public partial class tblMakale:IEntity
  {
       public int Id { get; set; }
        public string baslik {get; set;}
        public string aciklama {get; set;}
        public DateTime? yuklemetarihi { get; set;}
        public int yazarId {get; set;}
        public int KategoriId { get; set; }


}
}
