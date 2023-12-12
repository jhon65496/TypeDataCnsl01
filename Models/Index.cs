using TypeDataCnsl01.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TypeDataCnsl01.Models
{
    [Table("Indexes")]
    public class Index 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public string Description { get; set; }
        // decimal
        // float        
        public decimal IndexValue { get; set; }
        private readonly CultureInfo _uiCultureInfo = new CultureInfo("ru-RU");
        [NotMapped]
        public string FormattedIndexValue
        {
            get => IndexValue.ToString(_uiCultureInfo);
            set => IndexValue = decimal.Parse(value, _uiCultureInfo);
        }
        // public decimal Discount { get; set; }        
    }
}
