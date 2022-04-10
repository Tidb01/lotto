using Microsoft.EntityFrameworkCore;
using SkandinavAdat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkandinavAdat.Data
{
    public class SkandinavAdatContext: DbContext
    {
        public DbSet<LottoSzam> LottoSzamok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
                                                     Database = LottoDB;
                                               Initial Catalog = master;
                                              Trusted_Connection = true"
                                        );
        }
    }
}
