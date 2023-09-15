using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032Assignment.Models
{
    public partial class UserRoles : DbContext
    {
        public UserRoles()
            : base("name=UserRoles")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);
        }
    }
}
