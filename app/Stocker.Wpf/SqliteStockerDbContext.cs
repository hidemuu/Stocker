using Microsoft.EntityFrameworkCore;
using Stocker.Models;
using Stocker.Repository.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocker.Wpf
{
    public class SqliteStockerDbContext : StockerDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Constants.SqlLocalConnectionStringForSqlite);

        }
    }
}
