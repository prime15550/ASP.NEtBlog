using System.Collections.Generic;
using System.ComponentModel;
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

       public int iskullaniciExists(string email, string password)
       {
           int id = -999;
           foreach (var VARIABLE in _tblkullaniciDal.GetList())
           {
               if (VARIABLE.Mail==email&&VARIABLE.Password==password)
               {
                   id = VARIABLE.Id;
               }
           }

           return id;
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
