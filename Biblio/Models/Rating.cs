namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rating")]
    public partial class Rating
    {
        public int RatingID { get; set; }

        public int? UserID { get; set; }

        public int? BookID { get; set; }

        [Column("Rating")]
        public int? Rating1 { get; set; }

        public virtual Books Books { get; set; }

        public virtual Users Users { get; set; }
    }
}
