using System;
using System.Collections.Generic;
using System.Text;

namespace Organization.Model
{
    class Worker
    {
        private string _name;
        private string _surname;
        private int _age;
        private int _idDep;
        private string _dep;
        public string Name { get => _name; set { } }
        public string Surname { get => _surname; set { } }
        public int Age { get => _age; set { } }
        public int IdDep { get => _idDep; set { } }

        public string Department
        { 
            get => _dep; 
            set 
            {
                _dep = value;
            } 
        }

        public Worker(string name, string surname, int age, int idDep) 
        {
            _name = name;
            _surname = surname;
            _age = age;
            _idDep = idDep;
        }
    }
}
