using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblyorumService
  {
      List<tblyorum> GetAll();
      tblyorum GetById(int id);
      void Add(tblyorum entity);
      void Update(tblyorum entity);
      void Delete(tblyorum entity);
  }
}
