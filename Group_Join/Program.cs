using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> StudentList = new List<Students>();
            StudentList.Add(new Students() { StudentId = 1, ClassId = 1, StudentName = "Ali" });
            StudentList.Add(new Students() { StudentId = 2, ClassId = 2, StudentName = "Ayşe" });
            StudentList.Add(new Students() { StudentId = 3, ClassId = 1, StudentName = "Mehmet" });
            StudentList.Add(new Students() { StudentId = 4, ClassId = 3, StudentName = "Fatma" });
            StudentList.Add(new Students() { StudentId = 5, ClassId = 2, StudentName = "Ahet" });

            List<Classes> classeList = new List<Classes>();
            classeList.Add(new Classes() { ClassId = 1, ClassesName = "Matematik" });
            classeList.Add(new Classes() { ClassId = 2, ClassesName = "Türkçe" });
            classeList.Add(new Classes() { ClassId = 3, ClassesName = "Kimya" });

            var ClassAndStudent = classeList.GroupJoin(StudentList,
                                                     classitem => classitem.ClassId,
                                                     student => student.ClassId,
                                                     (classitem, studentname) => new
                                                     {
                                                         ClassName = classitem.ClassesName,
                                                         stuudent = studentname,
                                                     }
                                                     );

            foreach (var student in ClassAndStudent)
            {
                Console.WriteLine($"Sınıf: {student.ClassName}");
                foreach (var student2 in student.stuudent)
                    Console.WriteLine($"{student2.StudentName}");

            }
            Console.ReadKey();
        }
    }
}
