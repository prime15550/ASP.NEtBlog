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
      public void Add(Tblyorum entity)
      {
           _tblyorumDal.Insert(entity);
      }
       public void Delete(Tblyorum entity)
      {
           _tblyorumDal.Delete(entity);
      }
      public List<Tblyorum> GetAll()
      {
          return _tblyorumDal.GetList();
      }
      public Tblyorum GetById(int id)
      {
          return _tblyorumDal.Get(x => x.Id == id);
      }
      public void Update(Tblyorum entity)
      {
          _tblyorumDal.Update(entity);
      }
  }
}
