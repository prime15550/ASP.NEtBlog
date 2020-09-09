using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItbletiketService
  {
      List<tbletiket> GetAll();
      tbletiket GetById(int id);
      void Add(tbletiket entity);
      void Update(tbletiket entity);
      void Delete(tbletiket entity);
  }
}
