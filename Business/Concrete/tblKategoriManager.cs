using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblKategoriManager : ItblKategoriService
  {
      ItblKategoriDal _tblKategoriDal;
      public tblKategoriManager(ItblKategoriDal tblKategoriService)
      {
          _tblKategoriDal = tblKategoriService;
      }
      public void Add(tblKategori entity)
      {
           _tblKategoriDal.Insert(entity);
      }
       public void Delete(tblKategori entity)
      {
           _tblKategoriDal.Delete(entity);
      }
      public List<tblKategori> GetAll()
      {
          return _tblKategoriDal.GetList();
      }
      public tblKategori GetById(int id)
      {
          return _tblKategoriDal.Get(x => x.Id == id);
      }
      public void Update(tblKategori entity)
      {
          _tblKategoriDal.Update(entity);
      }
  }
}
