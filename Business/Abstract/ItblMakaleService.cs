using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblMakaleService
  {
      List<TblMakale> GetAll();
      TblMakale GetById(int id);
      void Add(TblMakale entity);
      void Update(TblMakale entity);
      void Delete(TblMakale entity);
  }
}
