using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblyazarDal : EfEntityRepositoryBase<tblyazar, dbBlogWebContext>, ItblyazarDal
  {
  }
}
