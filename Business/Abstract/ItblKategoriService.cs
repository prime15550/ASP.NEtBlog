using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblKategoriService
  {
      List<TblKategori> GetAll();
      TblKategori GetById(int id);
      void Add(TblKategori entity);
      void Update(TblKategori entity);
      void Delete(TblKategori entity);
  }
}
