using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblresimService
  {
      List<Tblresim> GetAll();
      Tblresim GetById(int id);
      void Add(Tblresim entity);
      void Update(Tblresim entity);
      void Delete(Tblresim entity);
  }
}
