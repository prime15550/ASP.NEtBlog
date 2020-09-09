using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblresimManager : ItblresimService
  {
      ItblresimDal _tblresimDal;
      public tblresimManager(ItblresimDal tblresimService)
      {
          _tblresimDal = tblresimService;
      }
      public void Add(tblresim entity)
      {
           _tblresimDal.Insert(entity);
      }
       public void Delete(tblresim entity)
      {
           _tblresimDal.Delete(entity);
      }
      public List<tblresim> GetAll()
      {
          return _tblresimDal.GetList();
      }
      public tblresim GetById(int id)
      {
          return _tblresimDal.Get(x => x.Id == id);
      }
      public void Update(tblresim entity)
      {
          _tblresimDal.Update(entity);
      }
  }
}
