using TypeDataCnsl01.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using TypeDataCnsl01.Data;
using System.Diagnostics;
using System.Windows.Input;
// using TypeDataCnsl01.Commands;

namespace TypeDataCnsl01.ViewModels.Views
{
    public class IndexesViewModel
    {   
        IndexesRepository indexesRepository;
        
        DbContextIndexes DataContextApp;
        public IndexesViewModel()
        {

            this.DataContextApp = new DbContextIndexes();
            indexesRepository   = new IndexesRepository(this.DataContextApp);

            LoadData();
        }

        private ObservableCollection<Index> indexes;
        public ObservableCollection<Index> Indexes
        {
            get { return indexes; }
            set 
            {
                indexes = value;                
            }
        }

        public void LoadData()
        {         
            var items = indexesRepository.Items.ToArray();
            Indexes = new ObservableCollection<Index>(items);
        }

    }
}
