using DBLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Repositories
{
    public partial class BaseDbContext : DbContext
    {
        private string _connectionStr { get; set; } = string.Empty;

        public BaseDbContext()
        {
            _connectionStr = Tools.DBTools.ConnectionString;
        }

        //public string SetConnectionString
        //{
        //    set { _connectionStr = value; }
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionStr);
        }
    }
}
