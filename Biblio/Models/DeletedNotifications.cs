namespace Biblio.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class DeletedNotifications
    {
        [Key]
        public int DeletedNotifyID { get; set; }

        public int UserID { get; set; }

        public int NotifyID { get; set; }

        public DateTime DeletedDate { get; set; }

        public virtual SystemNotifications SystemNotifications { get; set; }

        public virtual Users Users { get; set; }
    }
}
