using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BankDAL
{
    public partial class BankContext : DbContext
    {
        public BankContext()
            : base("name=BankContext")
        {
        }

        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>()
                .Property(e => e.CurrentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BankAccount>()
                .Property(e => e.Currency)
                .IsFixedLength();

            modelBuilder.Entity<Branch>()
                .Property(e => e.Region)
                .IsFixedLength();

            modelBuilder.Entity<Branch>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Branch>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mail)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.PassportNumber)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.BankAccounts)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Mail)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Position)
                .IsFixedLength();
        }
    }
}
