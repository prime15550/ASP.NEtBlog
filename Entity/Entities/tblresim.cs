using Core.Entities;
namespace Entity.Entities
{
  public partial class tblresim:IEntity
  {
       public int Id { get; set; }
        public string resim_url {get; set;}
        public int MakaleId { get; set; }
}
}
