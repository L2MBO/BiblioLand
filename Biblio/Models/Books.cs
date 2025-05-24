namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            UserBooks = new HashSet<UserBookmarks>();
            Rating = new HashSet<Rating>();
            Reviews = new HashSet<Reviews>();
        }

        [Key]
        public int BookID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string ImagePath { get; set; }

        [StringLength(255)]
        public string PdfPath { get; set; }

        public int? TotalPages { get; set; }

        public int? GenreID { get; set; }

        public int? CategoryID { get; set; }

        public int? OftenSearched { get; set; }

        public decimal? AverageRating { get; set; }

        public DateTime? AddedDate { get; set; }

        public virtual Genres Genres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserBookmarks> UserBooks { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Rating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
