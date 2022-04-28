#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HumanResources.Models;

namespace HumanResources.Data
{
    public class HumanResourcesContext : DbContext
    {
        public HumanResourcesContext (DbContextOptions<HumanResourcesContext> options)
            : base(options)
        {
        }

        public DbSet<HumanResources.Models.Employee> Employee { get; set; }

        public DbSet<HumanResources.Models.Department> Department { get; set; }

        public DbSet<HumanResources.Models.Project> Project { get; set; }
    }
}
