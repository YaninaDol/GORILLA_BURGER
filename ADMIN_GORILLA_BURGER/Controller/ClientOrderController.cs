using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ADMIN_GORILLA_BURGER.Model
{
    public partial class ClientOrderController : DbContext
    {
        public ClientOrderController()
            : base("name=ClientOrderController")
        {
        }

        public virtual DbSet<CLIENT_ORDER> CLIENT_ORDER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENT_ORDER>()
                .Property(e => e.STATUS)
                .IsUnicode(false);
        }
    }
}
