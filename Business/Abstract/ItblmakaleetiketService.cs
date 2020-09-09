using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblmakaleetiketService
  {
      List<tblmakaleetiket> GetAll();
      tblmakaleetiket GetById(int id);
      void Add(tblmakaleetiket entity);
      void Update(tblmakaleetiket entity);
      void Delete(tblmakaleetiket entity);
  }
}
