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
      public void Add(Tblresim entity)
      {
           _tblresimDal.Insert(entity);
      }
       public void Delete(Tblresim entity)
      {
           _tblresimDal.Delete(entity);
      }
      public List<Tblresim> GetAll()
      {
          return _tblresimDal.GetList();
      }
      public Tblresim GetById(int id)
      {
          return _tblresimDal.Get(x => x.MakaleId == id);
      }
      public void Update(Tblresim entity)
      {
          _tblresimDal.Update(entity);
      }
  }
}
