using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowSystemConsoler.BLL.Models;

namespace WorkFlowSystemConsoler.BLL.Context
{
    public partial class ConsolerContext : DbContext
    {
        public ConsolerContext()
            : base("DefaultConnection")
        {
        }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchType> BranchType { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Milestone> Milestones { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Reason> Reasons { get; set; }
        public virtual DbSet<SalesOrder> SalesOrder { get; set; }
        public virtual DbSet<SalesOrderAttachment> SalesOrderAttachment { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual DbSet<Salutation> Salutations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderDetail> WorkOrderDetail { get; set; }
        public virtual DbSet<KeyValues> KeyValue { get; set; }
        public virtual DbSet<SaleAndWorkOrderRevisions> SaleAndWorkOrderRevisions { get; set; }

    }
}
