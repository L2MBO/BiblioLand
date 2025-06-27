namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Reviews
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reviews()
        {
            Likes = new HashSet<Likes>();
            ReviewReports = new HashSet<ReviewReports>();
        }

        [Key]
        public int ReviewID { get; set; }

        public int? UserID { get; set; }

        public int? BookID { get; set; }

        public string Comment { get; set; }

        public int? LikesCount { get; set; }

        public DateTime? ReviewDate { get; set; }

        public virtual Books Books { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Likes> Likes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReviewReports> ReviewReports { get; set; }

        public virtual Users Users { get; set; }
    }
}
