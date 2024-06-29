using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPICRUD.Models;

namespace WebAPICRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("WebApiCrudDBConn") { }
        public DbSet<Employee> Employees { get; set; }
    }
}