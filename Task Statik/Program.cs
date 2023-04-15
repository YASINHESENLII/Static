using Microsoft.VisualBasic;

namespace Task_Statik
{
    internal class Program
    {
        static void Main(string[] args)
        {



            
            Group[] groups = new Group[2];
            
            Group group1 = new Group("Group 1");
            
            Group group2 = new Group("Group 2");
            groups[0] = group1; groups[1] =group2;
           
            Student student1 = new Student("Yasin ", "Hesenli");
            Student student2 = new Student("Hakim", "Dugi");
            



           group1.AddStudent(student1);
            Console.WriteLine("------------------");

            group2.AddStudent(student2);
            Console.WriteLine("------------------");
         
            group1.GetGroupInfo();

            Console.WriteLine("------------------");

            group2.GetGroupInfo();

            Console.WriteLine("------------------");

            group1.ShowStudents();

            Console.WriteLine("------------------");

            group1.Search("Yasin");
            Console.WriteLine("------------------");

            Student student = groups[0].GetStudent(1);
            if (student != null)
            {
                Console.WriteLine($"Hemin id-deki Telebe:{student.GetInfo()}");
                student.GetInfo();
            }
            else
            {
                Console.WriteLine("Telebe tapilmadi.");
            }

        }
    }
}