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
        public ObservableCollection<Department> Departments { get; set; }
        public Worker SelectedWorker
        {
            get { return _selectedWorker; }
            set
            {
                _selectedWorker = value;
            }
        }

        public MainWindowViewModel()
        {
            Workers = new ObservableCollection<Worker>
            {
                new Worker("1","1-1",21),
                new Worker("2","2-2",22),
                new Worker("3","3-3",23),
                new Worker("4","4-4",24),
            };
            Departments = new ObservableCollection<Department>
            {
                new Department("Админ","бабаб"),
                new Department("Эконом", "фывфыв"),
            };
        }
    }
}
