namespace WorkFlowSystemConsoler.BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KeyValues
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GroupName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Value { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsActive { get; set; }
    }
}
