using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Biblio.Models
{
    public partial class BiblioModel : DbContext
    {
        public BiblioModel()
            : base("name=BiblioModel13")
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UserBooks> UserBooks { get; set; }
        public virtual DbSet<UserCategories> UserCategories { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>()
                .Property(e => e.AverageRating)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Books>()
                .HasMany(e => e.Reviews)
                .WithOptional(e => e.Books)
                .WillCascadeOnDelete();

            modelBuilder.Entity<UserRoles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserRoles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Reviews)
                .WithOptional(e => e.Users)
                .WillCascadeOnDelete();
        }
    }
}
