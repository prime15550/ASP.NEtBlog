using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblmakaleetiketManager : ItblmakaleetiketService
  {
      ItblmakaleetiketDal _tblmakaleetiketDal;
      public tblmakaleetiketManager(ItblmakaleetiketDal tblmakaleetiketService)
      {
          _tblmakaleetiketDal = tblmakaleetiketService;
      }
      public void Add(tblmakaleetiket entity)
      {
           _tblmakaleetiketDal.Insert(entity);
      }
       public void Delete(tblmakaleetiket entity)
      {
           _tblmakaleetiketDal.Delete(entity);
      }
      public List<tblmakaleetiket> GetAll()
      {
          return _tblmakaleetiketDal.GetList();
      }
      public tblmakaleetiket GetById(int id)
      {
          return _tblmakaleetiketDal.Get(x => x.makaleId == id);
      }
      public void Update(tblmakaleetiket entity)
      {
          _tblmakaleetiketDal.Update(entity);
      }
  }
}
