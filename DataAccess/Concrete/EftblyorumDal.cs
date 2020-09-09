using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblyorumDal : EfEntityRepositoryBase<tblyorum, dbBlogWebContext>, ItblyorumDal
  {
  }
}
