namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserBans
    {
        [Key]
        public int UserBanID { get; set; }

        public int UserID { get; set; }

        public int BanedUserID { get; set; }

        public int BanCategoryID { get; set; }

        public string BanMessage { get; set; }

        public DateTime BanExpiration { get; set; }

        public virtual UserBanCategory UserBanCategory { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
