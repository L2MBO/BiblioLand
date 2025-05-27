namespace Biblio.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ReportCategory")]
    public partial class ReportCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReportCategory()
        {
            BookReports = new HashSet<BookReports>();
        }

        public int ReportCategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string ReportCategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReports> BookReports { get; set; }
    }
}
