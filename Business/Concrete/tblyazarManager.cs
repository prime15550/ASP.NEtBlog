using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblyazarManager : ItblyazarService
  {
      ItblyazarDal _tblyazarDal;
      public tblyazarManager(ItblyazarDal tblyazarService)
      {
          _tblyazarDal = tblyazarService;
      }
      public void Add(tblyazar entity)
      {
           _tblyazarDal.Insert(entity);
      }
       public void Delete(tblyazar entity)
      {
           _tblyazarDal.Delete(entity);
      }
      public List<tblyazar> GetAll()
      {
          return _tblyazarDal.GetList();
      }
      public tblyazar GetById(int id)
      {
          return _tblyazarDal.Get(x => x.Id == id);
      }
      public void Update(tblyazar entity)
      {
          _tblyazarDal.Update(entity);
      }
  }
}
