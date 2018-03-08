using SeleniumMvc.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeleniumMvc.Models.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=SeleniumTest;uid=sa;pwd=123";
        }
        public DbSet<Product> Products{ get; set; }
    }
}