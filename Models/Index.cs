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
        // decimal
        // float        
        public double IndexValue { get; set; }
        public double Discount { get; set; }
        public string Description { get; set; }
    }
}
