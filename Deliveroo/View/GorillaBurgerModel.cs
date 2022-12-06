using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GORILLA_BURGER
{
    public partial class GorillaBurgerModel : DbContext
    {
        public GorillaBurgerModel()
            : base("name=GorillaBurgerModel3")
        {
        }

        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<CLIENT_ORDER> CLIENT_ORDER { get; set; }
        public virtual DbSet<DELIVERY_PERSON> DELIVERY_PERSONS { get; set; }
        public virtual DbSet<LIST_PRODUCTS> LIST_PRODUCTSS { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORY>()
                .Property(e => e.CATEGORY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DELIVERY_PERSON>()
                .Property(e => e.DELIVERY_PERSON_NAME)
                .IsUnicode(false);

          

            modelBuilder.Entity<DELIVERY_PERSON>()
                .Property(e => e.DELIVERY_PERSON_FULL_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<DELIVERY_PERSON>()
                .Property(e => e.DELIVERY_PERSON_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<DELIVERY_PERSON>()
                .Property(e => e.DELIVERY_PERSON_CONTACTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.PRODUCT_SUBSCRIBE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.ROLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.DELIVERY_PERSON)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.DELIVERY_USERID);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.LIST_PRODUCTS)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.USER_ID);
        }
    }
}
