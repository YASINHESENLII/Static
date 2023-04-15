using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Statik
{
    public class Group
    {
        private int _id;
        private string _groupname;
        private static int GroupCount = 0;
        private Student[] Students  = new Student[0]; 
        public int GroupId { get; }
        public string GroupName { get { return _groupname; } set { _groupname = value; } }

        public Group(string groupName)
        {
            GroupCount++;
            GroupId = GroupCount;
            GroupName = groupName;
           
        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"Qrup id: {GroupId},Qrup Adi: {GroupName}, Telebelerin sayi: {Students.Length}");
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1] = student;
        }

      

        public Student GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public void Search(string search)
        {
            Console.WriteLine($"Axtaris neticesi:'{search}':");
            foreach (Student student in Students)
            {
                if (student.Name.Contains(search) || student.Surname.Contains(search))
                {
                    Console.WriteLine(student.GetInfo());
                }
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Qrupdaki Telebeler '{GroupName}':");
            foreach (Student student in Students)
            {
                Console.WriteLine(student.GetInfo());
            }
        }
    }

}