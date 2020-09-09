using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblyorumManager : ItblyorumService
  {
      ItblyorumDal _tblyorumDal;
      public tblyorumManager(ItblyorumDal tblyorumService)
      {
          _tblyorumDal = tblyorumService;
      }
      public void Add(tblyorum entity)
      {
           _tblyorumDal.Insert(entity);
      }
       public void Delete(tblyorum entity)
      {
           _tblyorumDal.Delete(entity);
      }
      public List<tblyorum> GetAll()
      {
          return _tblyorumDal.GetList();
      }
      public tblyorum GetById(int id)
      {
          return _tblyorumDal.Get(x => x.Id == id);
      }
      public void Update(tblyorum entity)
      {
          _tblyorumDal.Update(entity);
      }
  }
}
