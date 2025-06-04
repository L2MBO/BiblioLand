namespace Biblio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookReports
    {
        [Key]
        public int BookReportID { get; set; }

        public int? UserID { get; set; }

        public int? BookID { get; set; }

        public int? ReportCategoryID { get; set; }

        public string ReportMessage { get; set; }

        public DateTime? ReportDate { get; set; }

        public virtual Books Books { get; set; }

        public virtual ReportCategory ReportCategory { get; set; }

        public virtual Users Users { get; set; }
    }
}
