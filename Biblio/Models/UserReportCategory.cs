namespace Biblio.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserReportCategory")]
    public partial class UserReportCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserReportCategory()
        {
            UserReports = new HashSet<UserReports>();
        }

        [Key]
        public int ReportCategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string ReportCategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserReports> UserReports { get; set; }
    }
}
