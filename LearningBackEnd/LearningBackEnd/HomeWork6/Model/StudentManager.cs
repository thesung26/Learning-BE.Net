using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBackEnd.HomeWork6.Model
{
    public class StudentManager
    {
        public static void PrintListStudent(ArrayList students, string tableName = "")
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Danh sach sinh vien{0}:", tableName);
            foreach (var item in students)
            {
                var student = item as Student;
                if (student == null)
                    continue;
                Console.WriteLine(student.Name + "\t" +
                student.Age + "\t" +
                student.Address
                );
            }
        }

        public static void PrintListStudentOrderByAge(ArrayList students)
        {
            var sortedlist = new ArrayList();
            students.Cast<Student>().OrderBy(x => x.Age).ToList().ForEach(x =>
            {
                sortedlist.Add(x);
            });
            PrintListStudent(sortedlist, " sap xep theo tuoi");
        }

        public static void PrintStudentMaxAge(ArrayList students)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sinh vien co tuoi lon nhat:");
            var sortedlist = new ArrayList();
            var maxAgeStudent = students.Cast<Student>().MaxBy(x => x.Age);
            if (maxAgeStudent == null)
                return;
            Console.WriteLine(maxAgeStudent.Name + "\t" +
                maxAgeStudent.Age + "\t" +
                maxAgeStudent.Address
                );
        }

        public static void PrintListStudentMoreThan23Age(ArrayList students)
        {
            var sortedlist = new ArrayList();
            students.Cast<Student>().Where(x => x.Age > 23).ToList().ForEach(x =>
            {
                sortedlist.Add(x);
            });
            PrintListStudent(sortedlist, " tuoi > 23");
        }

        public static void PrintListStudentFirstNameIsHoang(ArrayList students)
        {
            var sortedlist = new ArrayList();
            students.Cast<Student>().Where(x => x.Name.Split(' ').FirstOrDefault()?.Equals("Hoang") ?? false).ToList().ForEach(x =>
            {
                sortedlist.Add(x);
            });
            PrintListStudent(sortedlist, " co ho Hoang");
        }

        public static void PrintListStudentAddressIsHaNoi(ArrayList students)
        {
            var sortedlist = new ArrayList();
            students.Cast<Student>().Where(x => x.Address.Equals("Ha Noi")).ToList().ForEach(x =>
            {
                sortedlist.Add(x);
            });
            PrintListStudent(sortedlist, " co dia chi o Hanoi");
        }
    }
}
