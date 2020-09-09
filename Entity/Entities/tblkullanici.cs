using Core.Entities;
namespace Entity.Entities
{
      public partial class tblkullanici  :  IEntity
      {
         public int Id { get; set; }
        public string isim {get; set;}
        public string soyisim {get; set;}
        public string username {get; set;}
        public string password {get; set;}
        public string mail {get; set;}
      }
}
