namespace Biblio.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserBanCategory")]
    public partial class UserBanCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserBanCategory()
        {
            UserBans = new HashSet<UserBans>();
        }

        [Key]
        public int BanCategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string BanCategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserBans> UserBans { get; set; }
    }
}
