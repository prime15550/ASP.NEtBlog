using Microsoft.EntityFrameworkCore;
namespace Entity.Entities
{
  public partial class dbBlogWebContext : DbContext
  {
      public dbBlogWebContext()
      {
      }
      public dbBlogWebContext(DbContextOptions<dbBlogWebContext> options): base(options)
      {
      }

       public virtual DbSet<tblyorum> tblyorum { get; set; }
       public virtual DbSet<tblMakale> tblMakale { get; set; }
       public virtual DbSet<tblkullanici> tblkullanici { get; set; }
       public virtual DbSet<tblmakaleetiket> tblmakaleetiket { get; set; }
       public virtual DbSet<tblyazar> tblyazar { get; set; }
       public virtual DbSet<tbletiket> tbletiket { get; set; }
       public virtual DbSet<tblresim> tblresim { get; set; }
       public virtual DbSet<tblKategori> tblKategori { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder.UseSqlServer("Server=localhost; Database=DbBlogWeb; Trusted_Connection = True; ");
          }
      }
  }
}
