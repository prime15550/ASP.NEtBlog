using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftbletiketDal : EfEntityRepositoryBase<Tbletiket, DbblogContext>, ItbletiketDal
  {
  }
}
