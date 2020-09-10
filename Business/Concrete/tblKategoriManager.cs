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
      public void Add(TblKategori entity)
      {
           _tblKategoriDal.Insert(entity);
      }
       public void Delete(TblKategori entity)
      {
           _tblKategoriDal.Delete(entity);
      }
      public List<TblKategori> GetAll()
      {
          return _tblKategoriDal.GetList();
      }
      public TblKategori GetById(int id)
      {
          return _tblKategoriDal.Get(x => x.Id == id);
      }
      public void Update(TblKategori entity)
      {
          _tblKategoriDal.Update(entity);
      }
  }
}
