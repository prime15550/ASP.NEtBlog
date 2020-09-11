using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblmakaleetiketService
  {
      List<Tblmakaleetiket> GetAll();
      Tblmakaleetiket GetById(int id);
      void Add(Tblmakaleetiket entity);
      void Update(Tblmakaleetiket entity);
      void Delete(Tblmakaleetiket entity);
      List<Tblmakaleetiket> getbyid(int id);
  }
}
