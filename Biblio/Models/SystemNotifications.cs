namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SystemNotifications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemNotifications()
        {
            DeletedNotifications = new HashSet<DeletedNotifications>();
        }

        [Key]
        public int NotifyID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string NotifyTitle { get; set; }

        [Required]
        public string NotifyMessage { get; set; }

        public DateTime NotifyDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeletedNotifications> DeletedNotifications { get; set; }

        public virtual Users Users { get; set; }
    }
}
