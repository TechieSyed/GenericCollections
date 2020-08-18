using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            ////numbers.Add("syed");
            //numbers.Add(10);
            //numbers.Add(20);

            //int sum = 0;
            //foreach(int num in numbers)
            //{
            //    sum += num;
            //}
            //Console.WriteLine("Sum=" + sum);


            //ArrayList numbers1 = new ArrayList();
            //numbers1.Add(10);
            //numbers1.Add(20);
            //numbers1.Add("syed");

            //sum = 0;
            //foreach(object obj in numbers1)
            //{
            //    int n = (int)obj; 
            //    sum += n;
            //}
            //Console.WriteLine("Sum=" + sum);

            var employees = new List<Employee>();
            //employees.Sort();
            //employees.BinarySearch();
            //employees.Remove();

            var departmentsdata = new Dictionary<int, List<Employee>>();
            departmentsdata.Add(101, employees);

            foreach(KeyValuePair<int, List<Employee>> keyValue in departmentsdata)
            {
                Console.WriteLine(keyValue.Key);
                foreach (var emp in keyValue.Value)
                    Console.WriteLine(emp.Id);
            }

            Console.ReadKey();
        }
    }
}
