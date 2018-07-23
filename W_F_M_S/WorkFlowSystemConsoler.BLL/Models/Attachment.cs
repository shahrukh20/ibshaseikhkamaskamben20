namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attachment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FormType { get; set; }

        public int FormId { get; set; }

        [StringLength(200)]
        public string FileUrl { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(200)]
        public string DocumentNo { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
