using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblkullaniciService
  {
      List<tblkullanici> GetAll();
      tblkullanici GetById(int id);
      void Add(tblkullanici entity);
      void Update(tblkullanici entity);
      void Delete(tblkullanici entity);
  }
}
