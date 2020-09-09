using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblyazarService
  {
      List<tblyazar> GetAll();
      tblyazar GetById(int id);
      void Add(tblyazar entity);
      void Update(tblyazar entity);
      void Delete(tblyazar entity);
  }
}
