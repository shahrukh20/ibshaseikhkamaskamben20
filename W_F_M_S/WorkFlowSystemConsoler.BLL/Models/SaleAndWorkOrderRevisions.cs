using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowSystemConsoler.BLL.Models
{
    public class SaleAndWorkOrderRevisions
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual int SaleOrderRevisionNo { get; set; }
        public virtual int WorkOrderRevisionNo { get; set; }
        public virtual string SalesOrder { get; set; }
        public virtual string Milestones { get; set; }
        public virtual string Activities { get; set; }
        public virtual string WorkOrders { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
