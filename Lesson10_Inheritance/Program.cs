using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("FIO", new DateTime(1990, 10, 6), "Odessa", "+380670000001");
            person.Email = "gates@microsoft.com";
            Console.WriteLine(person);

            Student student = new Student("FIO1", new DateTime(1994, 01, 9), "Odessa", "+380670000002", 2000, "151");
            student.Email = "bill@msn.com";
            Console.WriteLine(student);

            person.PassportDate = DateTime.Now;
            student.PassportDate = DateTime.Now;

            Employee employee = new Employee("FIO2", new DateTime(1984, 02, 1), "Odessa", "+380670000003", new DateTime(2015,2,15), 1576);
            Console.WriteLine(employee);

        }
    }
}
