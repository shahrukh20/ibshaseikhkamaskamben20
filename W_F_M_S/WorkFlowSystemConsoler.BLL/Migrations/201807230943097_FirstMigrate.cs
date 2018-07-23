namespace WorkFlowSystemConsoler.BLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(maxLength: 50),
                        Percentage = c.Decimal(precision: 18, scale: 2),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                        Milestone_Id = c.Int(),
                        SalesOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .ForeignKey("dbo.Milestone", t => t.Milestone_Id)
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrder_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.Milestone_Id)
                .Index(t => t.SalesOrder_Id);
            
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Code = c.String(nullable: false, maxLength: 50),
                        Type = c.Int(nullable: false),
                        Address = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Milestone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(maxLength: 50),
                        Percentage = c.Decimal(precision: 18, scale: 2),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                        SalesOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrder_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.SalesOrder_Id);
            
            CreateTable(
                "dbo.SalesOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        SaleOrderDate = c.DateTime(nullable: false),
                        ProjectCode = c.String(nullable: false, maxLength: 50),
                        ProjectName = c.String(nullable: false, maxLength: 200),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        ProjectSignDate = c.DateTime(nullable: false),
                        VisitEntitled = c.Int(),
                        ProjectValue = c.Decimal(nullable: false, precision: 18, scale: 2, storeType: "numeric"),
                        CreatedBy = c.Int(),
                        CreatedOn = c.DateTime(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                        Currency_Id = c.Int(),
                        ProjectManagerOffsiteId_Id = c.Int(),
                        ProjectManagerOnsiteId_Id = c.Int(),
                        SalesmanId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .ForeignKey("dbo.Currency", t => t.Currency_Id)
                .ForeignKey("dbo.Users", t => t.ProjectManagerOffsiteId_Id)
                .ForeignKey("dbo.Users", t => t.ProjectManagerOnsiteId_Id)
                .ForeignKey("dbo.Users", t => t.SalesmanId_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.Currency_Id)
                .Index(t => t.ProjectManagerOffsiteId_Id)
                .Index(t => t.ProjectManagerOnsiteId_Id)
                .Index(t => t.SalesmanId_Id);
            
            CreateTable(
                "dbo.Currency",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 50),
                        ExchangeRate = c.Decimal(precision: 18, scale: 2),
                        Monetary = c.String(nullable: false, maxLength: 50),
                        Format = c.String(maxLength: 50),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Attachments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FormType = c.String(nullable: false, maxLength: 50),
                        FormId = c.Int(nullable: false),
                        FileUrl = c.String(maxLength: 200),
                        Description = c.String(maxLength: 200),
                        DocumentNo = c.String(maxLength: 200),
                        IssueDate = c.DateTime(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BranchTypes",
                c => new
                    {
                        Branch_Type_ID = c.Int(nullable: false, identity: true),
                        Branch_Type_Code = c.String(nullable: false, maxLength: 50),
                        Branch_Type_Alias = c.String(maxLength: 50),
                        Company_ID = c.Int(nullable: false),
                        Branch_ID = c.Int(nullable: false),
                        Created_Datetime = c.DateTime(nullable: false),
                        Created_By = c.Int(),
                        Updated_Datetime = c.DateTime(),
                        Updated_By = c.Int(),
                    })
                .PrimaryKey(t => t.Branch_Type_ID);
            
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(maxLength: 50),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        Middle_Name = c.String(maxLength: 50),
                        Last_Name = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                        EmployeeType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .ForeignKey("dbo.EmployeeTypes", t => t.EmployeeType_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.EmployeeType_Id);
            
            CreateTable(
                "dbo.EmployeeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeCode = c.String(nullable: false, maxLength: 50),
                        TypeAlias = c.String(maxLength: 50),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Group",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Holiday",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        HolidayDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.KeyValues",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GroupName = c.String(nullable: false, maxLength: 50),
                        Value = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.GroupName, t.Value, t.IsActive });
            
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Reason",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(maxLength: 50),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.SaleAndWorkOrderRevisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleOrderRevisionNo = c.Int(nullable: false),
                        WorkOrderRevisionNo = c.Int(nullable: false),
                        SalesOrder = c.String(),
                        Milestones = c.String(),
                        Activities = c.String(),
                        WorkOrders = c.String(),
                        CreatedBy = c.Int(),
                        CreatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesOrderAttachments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentDescription = c.String(maxLength: 200),
                        DocumentNo = c.String(maxLength: 50),
                        IssueDate = c.DateTime(),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        SalesOrder_Id = c.Int(),
                        SalesOrderDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrder_Id)
                .ForeignKey("dbo.SalesOrderDetails", t => t.SalesOrderDetail_Id)
                .Index(t => t.SalesOrder_Id)
                .Index(t => t.SalesOrderDetail_Id);
            
            CreateTable(
                "dbo.SalesOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Double(nullable: false),
                        Type = c.String(nullable: false, maxLength: 20),
                        MilestoneName = c.String(nullable: false, maxLength: 100),
                        MilestonePercent = c.Double(nullable: false),
                        MilestoneValue = c.Double(nullable: false),
                        NoOfDays = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Milestone_Id = c.Int(),
                        SalesOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Milestone", t => t.Milestone_Id)
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrder_Id)
                .Index(t => t.Milestone_Id)
                .Index(t => t.SalesOrder_Id);
            
            CreateTable(
                "dbo.Salutation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(maxLength: 50),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                        CompletionDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        Remarks = c.String(maxLength: 200),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Branch_Id = c.Int(),
                        Company_Id = c.Int(),
                        MileStone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Company", t => t.Company_Id)
                .ForeignKey("dbo.Milestone", t => t.MileStone_Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.MileStone_Id);
            
            CreateTable(
                "dbo.WorkOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 200),
                        ReasonDescription = c.String(nullable: false, maxLength: 200),
                        Remarks = c.String(maxLength: 200),
                        CreatedOn = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                        UpdatedBy = c.Int(),
                        Employee_Id = c.Int(),
                        Reason_Id = c.Int(),
                        WorkOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.Employee_Id)
                .ForeignKey("dbo.Reason", t => t.Reason_Id)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrder_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Reason_Id)
                .Index(t => t.WorkOrder_Id);
            
            AddColumn("dbo.Users", "Branch_Id", c => c.Int());
            AddColumn("dbo.Users", "Company_Id", c => c.Int());
            CreateIndex("dbo.Users", "Branch_Id");
            CreateIndex("dbo.Users", "Company_Id");
            AddForeignKey("dbo.Users", "Branch_Id", "dbo.Branch", "Id");
            AddForeignKey("dbo.Users", "Company_Id", "dbo.Company", "Id");
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Address", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            DropForeignKey("dbo.WorkOrderDetails", "WorkOrder_Id", "dbo.WorkOrders");
            DropForeignKey("dbo.WorkOrderDetails", "Reason_Id", "dbo.Reason");
            DropForeignKey("dbo.WorkOrderDetails", "Employee_Id", "dbo.Employee");
            DropForeignKey("dbo.WorkOrders", "MileStone_Id", "dbo.Milestone");
            DropForeignKey("dbo.WorkOrders", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.WorkOrders", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Salutation", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Salutation", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.SalesOrderAttachments", "SalesOrderDetail_Id", "dbo.SalesOrderDetails");
            DropForeignKey("dbo.SalesOrderDetails", "SalesOrder_Id", "dbo.SalesOrders");
            DropForeignKey("dbo.SalesOrderDetails", "Milestone_Id", "dbo.Milestone");
            DropForeignKey("dbo.SalesOrderAttachments", "SalesOrder_Id", "dbo.SalesOrders");
            DropForeignKey("dbo.Reason", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Reason", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Material", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Material", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Holiday", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Holiday", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Group", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Group", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Employee", "EmployeeType_Id", "dbo.EmployeeTypes");
            DropForeignKey("dbo.EmployeeTypes", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.EmployeeTypes", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Employee", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Employee", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Document", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Document", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Activity", "SalesOrder_Id", "dbo.SalesOrders");
            DropForeignKey("dbo.Activity", "Milestone_Id", "dbo.Milestone");
            DropForeignKey("dbo.Milestone", "SalesOrder_Id", "dbo.SalesOrders");
            DropForeignKey("dbo.SalesOrders", "SalesmanId_Id", "dbo.Users");
            DropForeignKey("dbo.SalesOrders", "ProjectManagerOnsiteId_Id", "dbo.Users");
            DropForeignKey("dbo.SalesOrders", "ProjectManagerOffsiteId_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Users", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.SalesOrders", "Currency_Id", "dbo.Currency");
            DropForeignKey("dbo.Currency", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Currency", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.SalesOrders", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.SalesOrders", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Milestone", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Milestone", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Activity", "Company_Id", "dbo.Company");
            DropForeignKey("dbo.Activity", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Branch", "Company_Id", "dbo.Company");
            DropIndex("dbo.WorkOrderDetails", new[] { "WorkOrder_Id" });
            DropIndex("dbo.WorkOrderDetails", new[] { "Reason_Id" });
            DropIndex("dbo.WorkOrderDetails", new[] { "Employee_Id" });
            DropIndex("dbo.WorkOrders", new[] { "MileStone_Id" });
            DropIndex("dbo.WorkOrders", new[] { "Company_Id" });
            DropIndex("dbo.WorkOrders", new[] { "Branch_Id" });
            DropIndex("dbo.Salutation", new[] { "Company_Id" });
            DropIndex("dbo.Salutation", new[] { "Branch_Id" });
            DropIndex("dbo.SalesOrderDetails", new[] { "SalesOrder_Id" });
            DropIndex("dbo.SalesOrderDetails", new[] { "Milestone_Id" });
            DropIndex("dbo.SalesOrderAttachments", new[] { "SalesOrderDetail_Id" });
            DropIndex("dbo.SalesOrderAttachments", new[] { "SalesOrder_Id" });
            DropIndex("dbo.Reason", new[] { "Company_Id" });
            DropIndex("dbo.Reason", new[] { "Branch_Id" });
            DropIndex("dbo.Material", new[] { "Company_Id" });
            DropIndex("dbo.Material", new[] { "Branch_Id" });
            DropIndex("dbo.Holiday", new[] { "Company_Id" });
            DropIndex("dbo.Holiday", new[] { "Branch_Id" });
            DropIndex("dbo.Group", new[] { "Company_Id" });
            DropIndex("dbo.Group", new[] { "Branch_Id" });
            DropIndex("dbo.EmployeeTypes", new[] { "Company_Id" });
            DropIndex("dbo.EmployeeTypes", new[] { "Branch_Id" });
            DropIndex("dbo.Employee", new[] { "EmployeeType_Id" });
            DropIndex("dbo.Employee", new[] { "Company_Id" });
            DropIndex("dbo.Employee", new[] { "Branch_Id" });
            DropIndex("dbo.Document", new[] { "Company_Id" });
            DropIndex("dbo.Document", new[] { "Branch_Id" });
            DropIndex("dbo.Users", new[] { "Company_Id" });
            DropIndex("dbo.Users", new[] { "Branch_Id" });
            DropIndex("dbo.Currency", new[] { "Company_Id" });
            DropIndex("dbo.Currency", new[] { "Branch_Id" });
            DropIndex("dbo.SalesOrders", new[] { "SalesmanId_Id" });
            DropIndex("dbo.SalesOrders", new[] { "ProjectManagerOnsiteId_Id" });
            DropIndex("dbo.SalesOrders", new[] { "ProjectManagerOffsiteId_Id" });
            DropIndex("dbo.SalesOrders", new[] { "Currency_Id" });
            DropIndex("dbo.SalesOrders", new[] { "Company_Id" });
            DropIndex("dbo.SalesOrders", new[] { "Branch_Id" });
            DropIndex("dbo.Milestone", new[] { "SalesOrder_Id" });
            DropIndex("dbo.Milestone", new[] { "Company_Id" });
            DropIndex("dbo.Milestone", new[] { "Branch_Id" });
            DropIndex("dbo.Branch", new[] { "Company_Id" });
            DropIndex("dbo.Activity", new[] { "SalesOrder_Id" });
            DropIndex("dbo.Activity", new[] { "Milestone_Id" });
            DropIndex("dbo.Activity", new[] { "Company_Id" });
            DropIndex("dbo.Activity", new[] { "Branch_Id" });
            DropColumn("dbo.Users", "Company_Id");
            DropColumn("dbo.Users", "Branch_Id");
            DropTable("dbo.WorkOrderDetails");
            DropTable("dbo.WorkOrders");
            DropTable("dbo.Salutation");
            DropTable("dbo.SalesOrderDetails");
            DropTable("dbo.SalesOrderAttachments");
            DropTable("dbo.SaleAndWorkOrderRevisions");
            DropTable("dbo.Reason");
            DropTable("dbo.Material");
            DropTable("dbo.KeyValues");
            DropTable("dbo.Holiday");
            DropTable("dbo.Group");
            DropTable("dbo.EmployeeTypes");
            DropTable("dbo.Employee");
            DropTable("dbo.Document");
            DropTable("dbo.BranchTypes");
            DropTable("dbo.Attachments");
            DropTable("dbo.Currency");
            DropTable("dbo.SalesOrders");
            DropTable("dbo.Milestone");
            DropTable("dbo.Company");
            DropTable("dbo.Branch");
            DropTable("dbo.Activity");
        }
    }
}
