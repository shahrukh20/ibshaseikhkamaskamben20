namespace WorkFlowSystemConsoler.BLL.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string LoginId { get; set; }


        public int GroupId { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool IsActive { get; set; }

        public Company Company { get; set; }

        public Branch Branch { get; set; }

        public int ApplicationUser { get; set; }
    }
}
