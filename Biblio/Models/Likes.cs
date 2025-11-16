namespace Biblio.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Likes
    {
        [Key]
        public int LikeID { get; set; }

        public int? UserID { get; set; }

        public int? ReviewID { get; set; }

        public int? isLiked { get; set; }

        public virtual Reviews Reviews { get; set; }

        public virtual Users Users { get; set; }
    }
}
