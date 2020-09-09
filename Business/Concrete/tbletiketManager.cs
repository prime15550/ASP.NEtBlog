using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tbletiketManager : ItbletiketService
  {
      ItbletiketDal _tbletiketDal;
      public tbletiketManager(ItbletiketDal tbletiketService)
      {
          _tbletiketDal = tbletiketService;
      }
      public void Add(tbletiket entity)
      {
           _tbletiketDal.Insert(entity);
      }
       public void Delete(tbletiket entity)
      {
           _tbletiketDal.Delete(entity);
      }
      public List<tbletiket> GetAll()
      {
          return _tbletiketDal.GetList();
      }
      public tbletiket GetById(int id)
      {
          return _tbletiketDal.Get(x => x.Id == id);
      }
      public void Update(tbletiket entity)
      {
          _tbletiketDal.Update(entity);
      }
  }
}
