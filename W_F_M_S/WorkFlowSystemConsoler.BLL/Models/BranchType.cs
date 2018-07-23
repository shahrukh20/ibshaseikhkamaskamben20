namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BranchType
    {
        [Key]
        public int Branch_Type_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Branch_Type_Code { get; set; }

        [StringLength(50)]
        public string Branch_Type_Alias { get; set; }

        public int Company_ID { get; set; }

        public int Branch_ID { get; set; }

        public DateTime Created_Datetime { get; set; }

        public int? Created_By { get; set; }

        public DateTime? Updated_Datetime { get; set; }

        public int? Updated_By { get; set; }
    }
}
