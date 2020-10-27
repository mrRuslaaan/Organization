using Organization.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organization.ViewModel
{
    class MainWindowViewModel
    {
        private Worker _selectedWorker;

        public ObservableCollection<Worker> Workers { get; set; }
        public Worker SelectedWorker
        {
            get { return _selectedWorker; }
            set
            {
                _selectedWorker = value;
                //OnPropertyChanged("SelectedPhone");
            }
        }

        public MainWindowViewModel()
        {
            Workers = new ObservableCollection<Worker>
            {
               // new Worker {Name="1", Surname="1-1", Age=123 },
               // new Worker {Name="2", Surname="2-2", Age=123 },
               // new Worker {Name="3", Surname="3-3", Age=123 },
               // new Worker {Name="4", Surname="4-4", Age=123 }

                new Worker("1","1-1",21),
                new Worker("2","2-2",22),
                new Worker("3","3-3",23),
                new Worker("4","4-4",24),
            };                                       
        }
    }
}
