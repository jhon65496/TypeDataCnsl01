using TypeDataCnsl01.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDataCnsl01.Models
{
    [Table("Indexes")]
    public class Index 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // double
        // decimal
        // float        
        public decimal IndexValue { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
    }
}
