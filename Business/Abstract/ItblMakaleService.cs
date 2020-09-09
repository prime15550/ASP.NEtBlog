using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblMakaleService
  {
      List<tblMakale> GetAll();
      tblMakale GetById(int id);
      void Add(tblMakale entity);
      void Update(tblMakale entity);
      void Delete(tblMakale entity);
  }
}
