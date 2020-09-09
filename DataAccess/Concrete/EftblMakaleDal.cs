using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblMakaleDal : EfEntityRepositoryBase<tblMakale, dbBlogWebContext>, ItblMakaleDal
  {
  }
}
