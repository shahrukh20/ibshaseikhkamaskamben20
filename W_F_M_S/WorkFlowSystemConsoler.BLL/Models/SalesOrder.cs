namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [DataType(DataType.Date)]
        public DateTime SaleOrderDate { get; set; }

        //public int CompanyId { get; set; }
        public Company Company { get; set; }

        //public int BranchId { get; set; }
        public Branch Branch { get; set; }

        [Required]
        [StringLength(50)]
        public string ProjectCode { get; set; }

        [Required]
        [StringLength(200)]
        public string ProjectName { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public User ProjectManagerOffsiteId { get; set; }

        public User ProjectManagerOnsiteId { get; set; }

        public User SalesmanId { get; set; }

        public decimal? Amount { get; set; }
        public Currency Currency { get; set; }
        [DataType(DataType.Date)]
        public DateTime ProjectSignDate { get; set; }

        public int? VisitEntitled { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProjectValue { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
