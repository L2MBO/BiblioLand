namespace Biblio.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class UserRoles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserRoles()
        {
            Users = new HashSet<Users>();
        }

        [Key]
        public int UserRoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
    }
}
