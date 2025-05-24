namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserBookmarks
    {
        [Key]
        public int UserBookID { get; set; }

        public int? UserID { get; set; }

        public int? BookID { get; set; }

        public int? CurrentPage { get; set; }

        public int? CategoryID { get; set; }

        public DateTime? AddedDate { get; set; }

        public virtual Books Books { get; set; }

        public virtual UserCategories UserCategories { get; set; }

        public virtual Users Users { get; set; }
    }
}
