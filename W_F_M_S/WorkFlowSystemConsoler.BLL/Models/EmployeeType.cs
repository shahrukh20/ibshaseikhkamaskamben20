namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeeType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeCode { get; set; }

        [StringLength(50)]
        public string TypeAlias { get; set; }

        public Company Company { get; set; }

        public Branch Branch { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
