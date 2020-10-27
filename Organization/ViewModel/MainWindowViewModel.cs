using Organization.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Automation.Peers;

namespace Organization.ViewModel
{
    class MainWindowViewModel
    {
        public ObservableCollection<Worker> Workers { get; set; }
        public ObservableCollection<Department> Departments { get; set; }
        public ObservableCollection<Worker> Workers_1 { get; set; }
        public ObservableCollection<Worker> Workers_2 { get; set; }

        public MainWindowViewModel()
        {           
            Workers = new ObservableCollection<Worker>
            {                
                new Worker("1","1-1",21,1),
                new Worker("2","2-2",22,2),
                new Worker("3","3-3",23,1),
                new Worker("4","4-4",24,2),
            };
            
            Workers_1 = new ObservableCollection<Worker>();
            Workers_2 = new ObservableCollection<Worker>();
            
            var worker_from1dep = from w in Workers
                                  where w.IdDep == 1
                                  select w;
            
            foreach (var item in worker_from1dep)
            {
                Workers_1.Add(item);
            }
            
            var worker_from2dep = from w in Workers
                                  where w.IdDep == 2
                                  select w;
            
            foreach (var item in worker_from2dep)
            {
                Workers_2.Add(item);
            }
            
            Departments = new ObservableCollection<Department>
            {
                new Department("Админ","бабаб", 1, Workers_1),
                new Department("Эконом", "фывфыв", 2, Workers_2),
            };

            var workers = from w in Workers
                          select w;

            foreach (var item in workers)
            {

                item.Department = GiveDepName(item); 
            }
        }

        public string GiveDepName (Worker w1)
        {
            var nameOfdep = from d in Departments
                            where d.IdDep == w1.IdDep
                            select d.Dep;
            //var asda = nameOfdep;
            return nameOfdep.ToString();
        }
    }
}
