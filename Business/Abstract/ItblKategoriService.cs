using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblKategoriService
  {
      List<tblKategori> GetAll();
      tblKategori GetById(int id);
      void Add(tblKategori entity);
      void Update(tblKategori entity);
      void Delete(tblKategori entity);
  }
}
