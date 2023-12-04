using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDataCnsl01.Models;

namespace TypeDataCnsl01
{
    class IndexesRepository 
    {

        private readonly DbSet<Index> _Set;
        DbContextIndexes _db;

        public IndexesRepository(DbContextIndexes db)
        {
            _db = db;
            _Set = _db.Set<Index>();
        }

        private IQueryable<Index> items;
        public virtual IQueryable<Index> Items
        {
            get
            {
                items = _Set;
                return items;
            }
            set
            {
                items = value;
            }
        }

    }
}
