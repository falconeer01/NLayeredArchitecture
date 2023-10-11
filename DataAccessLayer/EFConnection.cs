using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public class EFConnection : DbContext
    {
        public EFConnection() : base("name=EFConnection") { }

        public virtual DbSet<Personnel> Personnel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personnel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.Duty)
                .IsUnicode(false);
        }
    }
}
