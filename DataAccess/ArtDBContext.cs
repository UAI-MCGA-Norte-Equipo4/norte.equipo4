using Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
  //DbContext generalmente representa una conexión de base de datos y un conjunto de tablas. 
  public partial class ArtDbContext : DbContext
  {
    public ArtDbContext() : base("name=DefaultConnection")
    {
      Database.SetInitializer<ArtDbContext>(null);
    }
    /// <summary>
    /// PluralizingTableNameConvention
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

    public virtual DbSet<Product> Product { get; set; }
    public virtual DbSet<Artist> Artist { get; set; }
    public virtual DbSet<Cart> Cart { get; set; }
    public virtual DbSet<CartItem> CartItem { get; set; }
    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<Error> Error { get; set; }
    public virtual DbSet<Order> Order { get; set; }
    public virtual DbSet<OrderDetail> OrderDetail { get; set; }
    public virtual DbSet<OrderNumber> OrderNumber { get; set; }

  }
}
