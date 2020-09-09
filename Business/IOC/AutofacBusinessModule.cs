using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
namespace Business.IOC
{
  public class AutofacBusinessModule: Module
  {
      protected override void Load(ContainerBuilder builder)
      {
           builder.RegisterType<tblyorumManager>().As<ItblyorumService>();
           builder.RegisterType<EftblyorumDal>().As<ItblyorumDal>();
           builder.RegisterType<tblMakaleManager>().As<ItblMakaleService>();
           builder.RegisterType<EftblMakaleDal>().As<ItblMakaleDal>();
           builder.RegisterType<tblkullaniciManager>().As<ItblkullaniciService>();
           builder.RegisterType<EftblkullaniciDal>().As<ItblkullaniciDal>();
           builder.RegisterType<tblmakaleetiketManager>().As<ItblmakaleetiketService>();
           builder.RegisterType<EftblmakaleetiketDal>().As<ItblmakaleetiketDal>();
           builder.RegisterType<tblyazarManager>().As<ItblyazarService>();
           builder.RegisterType<EftblyazarDal>().As<ItblyazarDal>();
           builder.RegisterType<tbletiketManager>().As<ItbletiketService>();
           builder.RegisterType<EftbletiketDal>().As<ItbletiketDal>();
           builder.RegisterType<tblresimManager>().As<ItblresimService>();
           builder.RegisterType<EftblresimDal>().As<ItblresimDal>();
           builder.RegisterType<tblKategoriManager>().As<ItblKategoriService>();
           builder.RegisterType<EftblKategoriDal>().As<ItblKategoriDal>();
      }
  }
}
