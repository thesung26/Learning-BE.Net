using LearningBackEnd.HomeWork6.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBackEnd.HomeWork6
{
    public static class HomeWork6Program
    {
        public static void Run()
        {
            ////Enter number of student
            //Console.WriteLine("Nhap so luong hoc sinh: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            ////Enter
            //var studentManager = new StudentManager();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("HOC SINH THU {0}: ", i + 1);
            //    var student = new Student();
            //    Console.WriteLine("Nhap ten: ");
            //    student.Name = Console.ReadLine() ?? "";
            //    Console.WriteLine("Nhap tuoi: ");
            //    student.Age = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Nhap dia chi: ");
            //    student.Address = Console.ReadLine() ?? "";

            //    studentManager.Students.Add(student);
            //}
            var st1 = new Student() { Name = "Pham Van The", Age = 18, Address = "Ha Noi" };
            var st2 = new Student() { Name = "Hoang Nam", Age = 21, Address = "Nam Dinh" };
            var st3 = new Student() { Name = "Phan Hai", Age = 17, Address = "Hai Phong" };
            var st4 = new Student() { Name = "Nguyen An", Age = 25, Address = "Ha Noi" };
            var st5 = new Student() { Name = "Nguyen Thai", Age = 24, Address = "Thai Binh" };
            var st6 = new Student() { Name = "Hoang Van Thu", Age = 24, Address = "Hoang Sa" };
            var arrStudents = new ArrayList() { st1, st2, st3, st4, st5, st6 };


            StudentManager.PrintListStudent(arrStudents);
            StudentManager.PrintListStudentOrderByAge(arrStudents);
            StudentManager.PrintStudentMaxAge(arrStudents);
            StudentManager.PrintListStudentMoreThan23Age(arrStudents);
            StudentManager.PrintListStudentFirstNameIsHoang(arrStudents);
            StudentManager.PrintListStudentAddressIsHaNoi(arrStudents);
        }
    }
}
