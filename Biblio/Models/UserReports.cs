namespace Biblio.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class UserReports
    {
        [Key]
        public int UserReportID { get; set; }

        public int UserID { get; set; }

        public int ReportedUserID { get; set; }

        public int ReportCategoryID { get; set; }

        [Required]
        public string ReportMessage { get; set; }

        public DateTime ReportDate { get; set; }

        public virtual UserReportCategory UserReportCategory { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
