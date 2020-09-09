using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblresimService
  {
      List<tblresim> GetAll();
      tblresim GetById(int id);
      void Add(tblresim entity);
      void Update(tblresim entity);
      void Delete(tblresim entity);
  }
}
