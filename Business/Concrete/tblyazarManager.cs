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
      public void Add(Tblyazar entity)
      {
           _tblyazarDal.Insert(entity);
      }
       public void Delete(Tblyazar entity)
      {
           _tblyazarDal.Delete(entity);
      }
      public List<Tblyazar> GetAll()
      {
          return _tblyazarDal.GetList();
      }
      public Tblyazar GetById(int id)
      {
          return _tblyazarDal.Get(x => x.Id == id);
      }
      public void Update(Tblyazar entity)
      {
          _tblyazarDal.Update(entity);
      }

    List<Tblyazar> ItblyazarService.Getbyid(int id)
        {
            return _tblyazarDal.GetList(x => x.Id == id);
        }
    }
}
