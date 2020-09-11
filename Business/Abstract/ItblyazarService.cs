using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblyazarService
  {
      List<Tblyazar> GetAll();
      Tblyazar GetById(int id);
      void Add(Tblyazar entity);
      void Update(Tblyazar entity);
      void Delete(Tblyazar entity);
      List<Tblyazar> Getbyid(int id);
    }
}
