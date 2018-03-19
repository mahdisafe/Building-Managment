namespace Building_Managment.MyCode
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RentalDB : DbContext
    {
        public RentalDB()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomersAttachment> CustomersAttachments { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Electricity_ShopsBills> Electricity_ShopsBills { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<ExpensessDetaile> ExpensessDetailes { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<Priv_Table> Priv_Table { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchasesDetail> PurchasesDetails { get; set; }
        public virtual DbSet<PurchasesType> PurchasesTypes { get; set; }
        public virtual DbSet<RentDetaile> RentDetailes { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Screen_Priv_Table> Screen_Priv_Table { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<User_Table> User_Table { get; set; }
        public virtual DbSet<UsersGroup> UsersGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>()
                .Property(e => e.BuildingLable)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Satete)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.Expenses)
                .WithOptional(e => e.Building)
                .HasForeignKey(e => e.Building_ID);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.Purchases)
                .WithOptional(e => e.Building)
                .HasForeignKey(e => e.Building_ID);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.Shops)
                .WithOptional(e => e.Building)
                .HasForeignKey(e => e.BuildingName)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerIDCard)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomersAttachments)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.CustomerID);

            modelBuilder.Entity<CustomersAttachment>()
                .Property(e => e.AttachmentName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerType>()
                .Property(e => e.CustomerType1)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerType>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.CustomerType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<Expens>()
                .Property(e => e.ExpensessDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Expens>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Expens>()
                .HasMany(e => e.ExpensessDetailes)
                .WithOptional(e => e.Expens)
                .HasForeignKey(e => e.Expensess_ID);

            modelBuilder.Entity<ExpensessDetaile>()
                .Property(e => e.ExpensessName)
                .IsUnicode(false);

            modelBuilder.Entity<ExpensessDetaile>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseType>()
                .Property(e => e.DescriptionExpenses)
                .IsUnicode(false);

            modelBuilder.Entity<ExpenseType>()
                .HasMany(e => e.Expenses)
                .WithOptional(e => e.ExpenseType)
                .HasForeignKey(e => e.ExpType);

            modelBuilder.Entity<Owner>()
                .Property(e => e.OwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.WorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Owner)
                .HasForeignKey(e => e.BuildingOwner);

            modelBuilder.Entity<PaymentMethod>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Purchase>()
                .HasMany(e => e.PurchasesDetails)
                .WithOptional(e => e.Purchase)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PurchasesDetail>()
                .Property(e => e.PurchesName)
                .IsUnicode(false);

            modelBuilder.Entity<PurchasesDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PurchasesType>()
                .Property(e => e.PurchasesDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PurchasesType>()
                .HasMany(e => e.Purchases)
                .WithOptional(e => e.PurchasesType1)
                .HasForeignKey(e => e.PurchasesType);

            modelBuilder.Entity<Screen_Priv_Table>()
                .Property(e => e.Screen_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Screen_Priv_Table>()
                .HasMany(e => e.Priv_Table)
                .WithOptional(e => e.Screen_Priv_Table)
                .HasForeignKey(e => e.Priv_Screen_No)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Shop>()
                .Property(e => e.ShopLable)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.ElectricMeterNo)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Electricity_ShopsBills)
                .WithOptional(e => e.Shop)
                .HasForeignKey(e => e.ShopLable);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Rents)
                .WithOptional(e => e.Shop)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User_Table>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User_Table>()
                .Property(e => e.Username_login)
                .IsUnicode(false);

            modelBuilder.Entity<User_Table>()
                .Property(e => e.Pass_word)
                .IsUnicode(false);

            modelBuilder.Entity<User_Table>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User_Table>()
                .HasMany(e => e.Expenses)
                .WithOptional(e => e.User_Table)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User_Table>()
                .HasMany(e => e.Priv_Table)
                .WithOptional(e => e.User_Table)
                .HasForeignKey(e => e.Priv_User_ID);

            modelBuilder.Entity<User_Table>()
                .HasMany(e => e.Purchases)
                .WithOptional(e => e.User_Table)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User_Table>()
                .HasMany(e => e.Rents)
                .WithOptional(e => e.User_Table)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<UsersGroup>()
                .Property(e => e.GroupType)
                .IsUnicode(false);
        }
    }
}
