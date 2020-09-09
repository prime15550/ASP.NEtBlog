using Core.Entities;
namespace Entity.Entities
{
  public partial class tblyazar:IEntity
  {
       public int Id { get; set; }
       public string isim {get; set;}
       public string soyisim {get; set;}
       public string mail {get; set;}
       public string aciklama {get; set;}
}
}
