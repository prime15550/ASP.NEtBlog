using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblkullaniciManager : ItblkullaniciService
  {
      ItblkullaniciDal _tblkullaniciDal;
      public tblkullaniciManager(ItblkullaniciDal tblkullaniciService)
      {
          _tblkullaniciDal = tblkullaniciService;
      }
      public void Add(tblkullanici entity)
      {
           _tblkullaniciDal.Insert(entity);
      }
       public void Delete(tblkullanici entity)
      {
           _tblkullaniciDal.Delete(entity);
      }
      public List<tblkullanici> GetAll()
      {
          return _tblkullaniciDal.GetList();
      }
      public tblkullanici GetById(int id)
      {
          return _tblkullaniciDal.Get(x => x.Id == id);
      }
      public void Update(tblkullanici entity)
      {
          _tblkullaniciDal.Update(entity);
      }
  }
}
