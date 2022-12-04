using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ADMIN_GORILLA_BURGER
{
    public partial class GBModel : DbContext
    {
        public GBModel()
            : base("name=GBModel")
        {
        }

        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
