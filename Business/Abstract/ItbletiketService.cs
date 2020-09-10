using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItbletiketService
  {
      List<Tbletiket> GetAll();
      Tbletiket GetById(int id);
      void Add(Tbletiket entity);
      void Update(Tbletiket entity);
      void Delete(Tbletiket entity);
  }
}
