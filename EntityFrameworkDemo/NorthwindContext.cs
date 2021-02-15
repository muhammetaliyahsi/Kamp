using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    // bir fonksiyon virtual ise onu inherit eden class override ederek içeriğini değiştirebilir
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Personel> Personels { get; set; }

        // Personel classı ile Employees tablosu arasında isim benzerliği olmadığı için bu şekilde bağlıyoruz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent mapping
            modelBuilder.Entity<Personel>().ToTable("Employees");

            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
        }
    }
}
