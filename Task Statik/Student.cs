using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Statik
{
    public class Student
    {

        private int id;
        private string name;
        private string surname;
        private static int Count = 0;

        public int Id { get; private set; }
        public string Name {
            get { return name; }
            set { if(value.Length>=3) { name = value;} }
        }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Id = ++Count;
            Name = name;
            Surname = surname;
        }

        public string GetInfo()
        {
            return $"Id: {Id}, Adi: {Name}, Soyadi: {Surname}";
        }
    }


}
