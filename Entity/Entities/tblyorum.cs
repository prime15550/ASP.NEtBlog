using Core.Entities;
using System;

namespace Entity.Entities
{
  public partial class tblyorum:IEntity
  {
       public int Id { get; set; }
       public string yorum {get; set;}
       public DateTime? date { get; set; }
       public int userId { get; set; }
        public int makaleId { get; set; }
   
}
}
