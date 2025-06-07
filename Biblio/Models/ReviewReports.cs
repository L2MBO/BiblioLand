namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReviewReports
    {
        [Key]
        public int ReviewReportID { get; set; }

        public int? UserID { get; set; }

        public int? ReviewID { get; set; }

        public DateTime? ReportDate { get; set; }

        public virtual Reviews Reviews { get; set; }

        public virtual Users Users { get; set; }
    }
}
