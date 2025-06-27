namespace Biblio.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class UserBookmarks
    {
        [Key]
        public int UserBookID { get; set; }

        public int? UserID { get; set; }

        public int? BookID { get; set; }

        public int? IsReading { get; set; }

        public int? CategoryID { get; set; }

        public DateTime? LastReadDate { get; set; }

        public virtual Books Books { get; set; }

        public virtual UserCategories UserCategories { get; set; }

        public virtual Users Users { get; set; }
    }
}
