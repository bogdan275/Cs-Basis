using Data.Extension;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class PharmacyContext : DbContext
    {
        public DbSet<Active_Ingredient> Active_Ingredients => Set<Active_Ingredient>();
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Medicine> Medicines => Set<Medicine>();
        public DbSet<Shelf_Item> Shelf_Items => Set<Shelf_Item>();
        public DbSet<Shelf> Shelves => Set<Shelf>();
        public DbSet<Batch> Batches => Set<Batch>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<Purchase_Order> Purchase_Orders => Set<Purchase_Order>();
        public DbSet<Purchase_Order_Item> Purchase_Order_Items => Set<Purchase_Order_Item>();
        public DbSet<Sale> Sales => Set<Sale>();
        public DbSet<Refrigerator> Refrigerators => Set<Refrigerator>();
        public DbSet<Refrigerator_Log> Refrigerator_Logs => Set<Refrigerator_Log>();
        public DbSet<Return_Policy> Return_Policies => Set<Return_Policy>();
        public DbSet<Recipe> Recipes => Set<Recipe>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cnstring = "Server=.;Database=Lab3;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(cnstring);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Active_Ingredient>(entity =>
            {
                entity.ToTable("active_ingredients");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);

                entity.HasMany(a => a.Medicines)
                    .WithOne(m => m.Active_Ingredient)
                    .HasForeignKey(m => m.Active_IngredientId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("brands");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);

                entity.HasMany(e => e.Medicines)
                    .WithOne(m => m.Brand)
                    .HasForeignKey(m => m.BrandId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.ToTable("medicines");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Storage_Conditions).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Seasonal_Status).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Release_Form).IsRequired().HasMaxLength(100);

                entity.HasMany(e => e.Batches)
                    .WithOne(b => b.Medicine)
                    .HasForeignKey(b => b.MedicineId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(e => e.Recipes)
                    .WithOne(r => r.Medicine)
                    .HasForeignKey(r => r.MedicineId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(e => e.Sales)
                    .WithOne(s => s.Medicine)
                    .HasForeignKey(s => s.MedicineId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("suppliers");
                entity.HasKey(e => e.SupplierId);
                entity.Property(e => e.SupplierId).IsRequired().HasMaxLength(50);
                entity.Property(e => e.SupplierName).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Phone).IsRequired();
            });

            modelBuilder.Entity<Purchase_Order>(entity =>
            {
                entity.ToTable("purchase_orders");
                entity.HasKey(e => e.Purchase_Order_Id);
                entity.Property(e => e.Order_Date).IsRequired();
                entity.Property(e => e.Status).IsRequired();

                entity.HasOne(e => e.Supplier)
                    .WithMany()
                    .HasForeignKey(e => e.SupplierId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Purchase_Order_Item>(entity =>
            {
                entity.ToTable("purchase_order_items");
                entity.HasKey(e => e.Purchase_Order_Item_Id);
                entity.Property(e => e.Quantity).IsRequired();

                entity.HasOne(e => e.Purchase_Order)
                    .WithMany(po => po.Items)
                    .HasForeignKey(e => e.Purchase_orderId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Medicine)
                    .WithMany()
                    .HasForeignKey(e => e.MedicineId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Refrigerator>(entity =>
            {
                entity.ToTable("refrigerators");
                entity.HasKey(e => e.Refrigerator_Id);
                entity.Property(e => e.Refrigerator_Name).IsRequired();

                entity.HasMany(e => e.Batches)
                    .WithOne(b => b.Refrigerator)
                    .HasForeignKey(b => b.RefrigeratorId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasMany(e => e.Logs)
                    .WithOne(l => l.Refrigerator)
                    .HasForeignKey(l => l.RefrigeratorId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Refrigerator_Log>(entity =>
            {
                entity.ToTable("refrigerator_logs");
                entity.HasKey(e => e.Log_Id);
                entity.Property(e => e.Min_Temp).IsRequired();
                entity.Property(e => e.Max_Temp).IsRequired();
                entity.Property(e => e.Current_Temp).IsRequired();
                entity.Property(e => e.Log_Date).IsRequired();
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("batches");
                entity.HasKey(e => e.Batch_Id);
                entity.Property(e => e.Batch_Num).IsRequired();
                entity.Property(e => e.Arrival_Date).IsRequired();
                entity.Property(e => e.Expiri_Date).IsRequired();
                entity.Property(e => e.Stock_Quantity).IsRequired();

                entity.HasOne(e => e.Purchase_Order)
                    .WithMany()
                    .HasForeignKey(e => e.Purchase_OrderId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.Sales)
                    .WithOne(s => s.Batch)
                    .HasForeignKey(s => s.BatchId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("recipes");
                entity.HasKey(e => e.Recipe_Id);
                entity.Property(e => e.Doctor_Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Doctor_Phone).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Can_use_alternative).IsRequired();
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sales");
                entity.HasKey(e => e.Sale_Id);
                entity.Property(e => e.Date_Of_Sale).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.Price).IsRequired().HasColumnType("decimal(10,2)");

                entity.HasOne(e => e.Return_Policy)
                    .WithOne(rp => rp.Sale)
                    .HasForeignKey<Sale>(e => e.Return_Policy_Id)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Return_Policy>(entity =>
            {
                entity.ToTable("return_policies");
                entity.HasKey(e => e.Return_Policy_Id);
                entity.Property(e => e.Can_Return).IsRequired();
                entity.Property(e => e.Signature1).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Signature2).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Pasport_Data).IsRequired();
            });

            modelBuilder.Entity<Shelf>(entity =>
            {
                entity.ToTable("shelves");
                entity.HasKey(e => e.ShelfId);
                entity.Property(e => e.Zone).IsRequired().HasMaxLength(100);
                entity.Property(e => e.ShelfNumber).IsRequired();
                entity.Property(e => e.RowNumber).IsRequired();

                entity.HasMany(e => e.ShelfItems)
                    .WithOne(si => si.Shelf)
                    .HasForeignKey(si => si.ShelfId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Shelf_Item>(entity =>
            {
                entity.ToTable("shelf_items");
                entity.HasKey(e => e.Shelf_Item_Id);
                entity.Property(e => e.Face_Required).IsRequired();
                entity.Property(e => e.Face_Current).IsRequired();
                entity.Property(e => e.Location_Hint).HasMaxLength(50);
                entity.Property(e => e.Last_Updated).IsRequired();

                entity.HasOne(e => e.Medicine)
                    .WithMany()
                    .HasForeignKey(e => e.MedicineId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.SeedPharmacyData();
        }
    }
}