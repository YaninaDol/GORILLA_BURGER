using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Deliveroo
{
    public partial class GorillaBurgerModel : DbContext
    {
        public GorillaBurgerModel()
            : base("name=GorillaBurgerModel1")
        {
        }

        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<CLIENT_ORDER> CLIENT_ORDER { get; set; }
        public virtual DbSet<DELIVERY_PERSON> DELIVERY_PERSON { get; set; }
        public virtual DbSet<LIST_PRODUCTS> LIST_PRODUCTS { get; set; }
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
                .Property(e => e.DELIVERY_SURNAME)
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

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.URL_PICTURE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.ROLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.DELIVERY_PERSON)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.DELIVERY_USERID);
        }
    }
}