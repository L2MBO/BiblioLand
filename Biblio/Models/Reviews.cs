namespace Biblio.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Reviews
    {
        [Key]
        public int ReviewID { get; set; }

        public int? UserID { get; set; }

        public int? BookID { get; set; }

        public string Comment { get; set; }

        public int? LikesCount { get; set; }

        public DateTime? ReviewDate { get; set; }

        public virtual Books Books { get; set; }

        public virtual Users Users { get; set; }
    }
}
