using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("How");
            list.Add("Are");
            list.Add("You");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(list[0]);

            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            list2.Add(6);

            list2.Reverse();
            Console.WriteLine(list2.IndexOf(6));
            Console.WriteLine(list2.LastIndexOf(6));

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            Employee e1 = new Employee()
            {
                name = "Kanika",
                age = 24
            };
            Employee e2 = new Employee()
            {
                name = "Deevanshu",
                age = 21
            };


            List<Employee> list3 = new List<Employee>();
            list3.Add(e1);
            list3.Add(e2);

            foreach (Employee e3 in list3)
            {
                Console.WriteLine($"Name: {e3.name}, Age: {e3.age}");
            }

            Console.WriteLine(list3.Exists(e3 => e3.name.StartsWith("D")));

            Employee e = list3.Find(e3 => e3.age < 22);
            Console.WriteLine("The age less than 22 is of " + e.name);

            // similarly FindLast() is used to find last occurence.
            // And FindAll() gives all the occurences.




            Console.ReadLine();
        }
    }
}
