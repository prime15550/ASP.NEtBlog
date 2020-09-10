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
      public void Add(Tbletiket entity)
      {
           _tbletiketDal.Insert(entity);
      }
       public void Delete(Tbletiket entity)
      {
           _tbletiketDal.Delete(entity);
      }
      public List<Tbletiket> GetAll()
      {
          return _tbletiketDal.GetList();
      }
      public Tbletiket GetById(int id)
      {
          return _tbletiketDal.Get(x => x.Id == id);
      }
      public void Update(Tbletiket entity)
      {
          _tbletiketDal.Update(entity);
      }
  }
}
