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
      public void Add(Tblkullanici entity)
      {
           _tblkullaniciDal.Insert(entity);
      }
       public void Delete(Tblkullanici entity)
      {
           _tblkullaniciDal.Delete(entity);
      }
      public List<Tblkullanici> GetAll()
      {
          return _tblkullaniciDal.GetList();
      }
      public Tblkullanici GetById(int id)
      {
          return _tblkullaniciDal.Get(x => x.Id == id);
      }
      public void Update(Tblkullanici entity)
      {
          _tblkullaniciDal.Update(entity);
      }
  }
}
