using DBLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Repositories
{
    public partial class BaseDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
