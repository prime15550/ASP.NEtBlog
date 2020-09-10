using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblkullaniciDal : EfEntityRepositoryBase<Tblkullanici, DbblogContext>, ItblkullaniciDal
  {
  }
}
