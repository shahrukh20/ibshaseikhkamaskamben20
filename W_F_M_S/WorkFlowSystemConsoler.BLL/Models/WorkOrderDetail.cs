namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkOrderDetail
    {
        [Key]
        public int Id { get; set; }

        public WorkOrder WorkOrder { get; set; }
        
        public Employee Employee { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public Reason Reason { get; set; }

        [Required]
        [StringLength(200)]
        public string ReasonDescription { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
