namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesOrderDetail
    {
        [Key]
        public int Id { get; set; }

        public  SalesOrder SalesOrder { get; set; }

        public double Number { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        public Milestone Milestone { get; set; }

        [Required]
        [StringLength(100)]
        public string MilestoneName { get; set; }

        public double MilestonePercent { get; set; }

        public double MilestoneValue { get; set; }

        public int NoOfDays { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
