using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            var group1 = new Group()
            {
                Name = "Venus"
            };
            AddGroup(groups, group1);

            var group2 = new Group()
            {
                Name = "Code"
            };
            AddGroup(groups, group2);

            var group3 = new Group()
            {
                Name = "Interface"
            };
            AddGroup(groups, group3);

            var group4 = new Group()
            {
                Name = "Venus"
            };
            AddGroup(groups, group4);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
            }


        }
        static void AddGroup(List<Group> groups, Group group)
        {
            var isDublicatedName = groups.Any(d => d.Name == group.Name);
            if (!isDublicated)
            {
                groups.Add(group);
            }
        }



        List<Student> students = new List<Student>();
            var student1 = new Student()
            {
                Name = "Naim",
                Surname = "Rahimov",
                PIN = "G456Kl8"
            };
           AddStudent(students,student1);

            var student2 = new Student()
            {
                Name = "Elvin",
                Surname = "Ceferli",
                PIN = "HK456LYE"
            };
           AddStudent(students,student2);

            var student3 = new Student()
            {
                Name = "Isa",
                Surname = "Aghaoghlu",
                PIN = "HK456LYE"
            };
           AddStudent(students,student3);   

            foreach (var student in students)
            {
                Console.WriteLine(student.GetDetails());
            }

        }
        static void AddStudent(List<Student> students, Student student)
        {
            var isDublicatedPIN = students.Any(s => s.PIN == student.PIN);
            if (!isDublicatedPIN)
            {
                students.Add(student);
            }
        }
    }
}