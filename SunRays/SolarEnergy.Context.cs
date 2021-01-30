﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunRays
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A65D4E_SolarEnergyEntities : DbContext
    {
        public DB_A65D4E_SolarEnergyEntities()
            : base("name=DB_A65D4E_SolarEnergyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BillDocument> BillDocuments { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DisposalDocument> DisposalDocuments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EndSalary> EndSalaries { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<ExpensesLimit> ExpensesLimits { get; set; }
        public virtual DbSet<FixInvoice> FixInvoices { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Incentive> Incentives { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductStore> ProductStores { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual DbSet<RequestCycle> RequestCycles { get; set; }
        public virtual DbSet<SafeHouse> SafeHouses { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<SalaryTransaction> SalaryTransactions { get; set; }
        public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }
        public virtual DbSet<SalesInvoiceDetail> SalesInvoiceDetails { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TypeInvoice> TypeInvoices { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<Vacation> Vacations { get; set; }
        public virtual DbSet<Employee_View> Employee_View { get; set; }
    }
}
