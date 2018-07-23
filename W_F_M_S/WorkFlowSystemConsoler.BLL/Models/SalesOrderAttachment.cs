namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesOrderAttachment
    {
        [Key]
        public int Id { get; set; }

        public SalesOrder SalesOrder { get; set; }

        public SalesOrderDetail SalesOrderDetail  { get; set; }

        [StringLength(200)]
        public string DocumentDescription { get; set; }

        [StringLength(50)]
        public string DocumentNo { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
