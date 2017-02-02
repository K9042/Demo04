using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kirsi";
            teacher.LastName = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Matti", "Mallikas", "H9090");
            student.Address = "Kirkkokatu 10";
            student.Age = 20;
            student.PhoneNumber = "040-877878787";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();


        }
    }
}
