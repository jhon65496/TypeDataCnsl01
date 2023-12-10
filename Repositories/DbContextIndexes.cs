using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDataCnsl01.Models;

namespace TypeDataCnsl01
{
    public class DbContextIndexes : DbContext
    {   
        
        public DbContextIndexes() : base("DefaultConnection")
        {
                
        }

        public DbSet<Index> Indexes { get; set; }
    }
}
