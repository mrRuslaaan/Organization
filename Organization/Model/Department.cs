using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Organization.Model
{
    class Department
    {
        private string _dep;
        private string _desc;
        private int _idDep;
        private ObservableCollection<Worker> _workers;
        public string Dep { get => _dep; set { } }
        public string Desc { get => _desc; set { } }
        public int IdDep { get => _idDep; set { } }
        public ObservableCollection<Worker> Workers { get => _workers; set { } }
        public Department(string name, string desc, int idDep, ObservableCollection<Worker> workers) 
        {
            _dep = name;
            _desc = desc;
            _idDep = idDep;
            this._workers = workers;
        }

        public Department(string name, string desc, int idDep)
        {
            _dep = name;
            _desc = desc;
            _idDep = idDep;
        }
    }
}
