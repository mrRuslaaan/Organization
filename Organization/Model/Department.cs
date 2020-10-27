using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Organization.Model
{
    class Department
    {
        private string _dep;
        private string _desc;
        public string Dep { get => _dep; set { } }
        public string Desc { get => _desc; set { } }

        public Department(string name, string desc) 
        {
            _dep = name;
            _desc = desc;
        }
    }
}
