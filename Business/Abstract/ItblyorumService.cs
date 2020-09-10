using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblyorumService
  {
      List<Tblyorum> GetAll();
      Tblyorum GetById(int id);
      void Add(Tblyorum entity);
      void Update(Tblyorum entity);
      void Delete(Tblyorum entity);
  }
}
