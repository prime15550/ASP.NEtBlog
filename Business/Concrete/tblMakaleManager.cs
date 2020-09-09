using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblMakaleManager : ItblMakaleService
  {
      ItblMakaleDal _tblMakaleDal;
      public tblMakaleManager(ItblMakaleDal tblMakaleService)
      {
          _tblMakaleDal = tblMakaleService;
      }
      public void Add(tblMakale entity)
      {
           _tblMakaleDal.Insert(entity);
      }
       public void Delete(tblMakale entity)
      {
           _tblMakaleDal.Delete(entity);
      }
      public List<tblMakale> GetAll()
      {
          return _tblMakaleDal.GetList();
      }
      public tblMakale GetById(int id)
      {
          return _tblMakaleDal.Get(x => x.Id == id);
      }
      public void Update(tblMakale entity)
      {
          _tblMakaleDal.Update(entity);
      }
  }
}
