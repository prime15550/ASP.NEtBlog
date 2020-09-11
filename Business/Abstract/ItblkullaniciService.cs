using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblkullaniciService
  {
      List<Tblkullanici> GetAll();
      Tblkullanici GetById(int id);
      void Add(Tblkullanici entity);
      void Update(Tblkullanici entity);
      void Delete(Tblkullanici entity);

      int iskullaniciExists(string email, string password);
  }
}
