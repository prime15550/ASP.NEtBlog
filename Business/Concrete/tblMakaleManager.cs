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
      public void Add(TblMakale entity)
      {
           _tblMakaleDal.Insert(entity);
      }
       public void Delete(TblMakale entity)
      {
           _tblMakaleDal.Delete(entity);
      }
      public List<TblMakale> GetAll()
      {
          return _tblMakaleDal.GetList();
      }
      public TblMakale GetById(int id)
      {
          return _tblMakaleDal.Get(x => x.Id == id);
      }
      public void Update(TblMakale entity)
      {
          _tblMakaleDal.Update(entity);
      }
  }
}
