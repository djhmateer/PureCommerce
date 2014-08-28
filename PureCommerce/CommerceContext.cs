namespace PureCommerce {
    using System.Data.Entity;

    public partial class CommerceContext : DbContext {
        public CommerceContext()
            : base("name=CommerceContext") {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.DiscountedUnitPrice)
                .HasPrecision(19, 4);
        }
    }
}
