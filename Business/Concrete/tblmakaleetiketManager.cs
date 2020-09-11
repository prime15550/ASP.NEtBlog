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
      public void Add(Tblmakaleetiket entity)
      {
           _tblmakaleetiketDal.Insert(entity);
      }
       public void Delete(Tblmakaleetiket entity)
      {
           _tblmakaleetiketDal.Delete(entity);
      }
      public List<Tblmakaleetiket> GetAll()
      {
          return _tblmakaleetiketDal.GetList();
      }
      public Tblmakaleetiket GetById(int id)
      {
          return _tblmakaleetiketDal.Get(x => x.MakaleId == id);
      }
      public void Update(Tblmakaleetiket entity)
      {
          _tblmakaleetiketDal.Update(entity);
      }

      public List<Tblmakaleetiket> getbyid(int id)
      {
          return _tblmakaleetiketDal.GetList(x => x.MakaleId == id);
      }
  }
}
