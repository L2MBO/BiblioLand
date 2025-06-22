namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int FeedbackID { get; set; }

        public int? UserID { get; set; }

        public int? FeedbackCategoryID { get; set; }

        [StringLength(100)]
        public string FeedbackTitle { get; set; }

        public string FeedbackMessage { get; set; }

        public DateTime? FeedbackDate { get; set; }

        public virtual FeedbackCategory FeedbackCategory { get; set; }

        public virtual Users Users { get; set; }
    }
}
