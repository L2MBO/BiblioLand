using System.Data.Entity;

namespace Biblio.Models
{
    public partial class BiblioModel : DbContext
    {
        public BiblioModel()
            : base("name=BiblioModel40")
        {
        }

        public virtual DbSet<BookReportCategory> BookReportCategory { get; set; }
        public virtual DbSet<BookReports> BookReports { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<DeletedNotifications> DeletedNotifications { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<FeedbackCategory> FeedbackCategory { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<ReviewReportCategory> ReviewReportCategory { get; set; }
        public virtual DbSet<ReviewReports> ReviewReports { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<SystemNotifications> SystemNotifications { get; set; }
        public virtual DbSet<UserBanCategory> UserBanCategory { get; set; }
        public virtual DbSet<UserBans> UserBans { get; set; }
        public virtual DbSet<UserBookmarks> UserBookmarks { get; set; }
        public virtual DbSet<UserCategories> UserCategories { get; set; }
        public virtual DbSet<UserReportCategory> UserReportCategory { get; set; }
        public virtual DbSet<UserReports> UserReports { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookReportCategory>()
                .HasMany(e => e.BookReports)
                .WithRequired(e => e.BookReportCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Books>()
                .Property(e => e.AverageRating)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Books>()
                .HasMany(e => e.BookReports)
                .WithRequired(e => e.Books)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Books>()
                .HasMany(e => e.Reviews)
                .WithOptional(e => e.Books)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FeedbackCategory>()
                .HasMany(e => e.Feedback)
                .WithRequired(e => e.FeedbackCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReviewReportCategory>()
                .HasMany(e => e.ReviewReports)
                .WithRequired(e => e.ReviewReportCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reviews>()
                .HasMany(e => e.ReviewReports)
                .WithRequired(e => e.Reviews)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemNotifications>()
                .HasMany(e => e.DeletedNotifications)
                .WithRequired(e => e.SystemNotifications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserBanCategory>()
                .HasMany(e => e.UserBans)
                .WithRequired(e => e.UserBanCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserReportCategory>()
                .HasMany(e => e.UserReports)
                .WithRequired(e => e.UserReportCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserRoles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserRoles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.BookReports)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.DeletedNotifications)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Feedback)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.ReviewReports)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Reviews)
                .WithOptional(e => e.Users)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.SystemNotifications)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserBans)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserBans1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.BanedUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserReports)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserReports1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.ReportedUserID)
                .WillCascadeOnDelete(false);
        }
    }
}
