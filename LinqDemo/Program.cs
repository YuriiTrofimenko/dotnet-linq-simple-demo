using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> integers =
                new List<int> { 1, 13, 67, -5, 10, 0, 100 };*/
            // LINQ
            // var result = integers.Where((i) => i > 0).ToList();
            // result.ForEach(Console.WriteLine);

            // var result = integers.Where((i) => i > 0);
            // Console.WriteLine(result);
            /* foreach (var item in result)
            {
                Console.WriteLine(item);
            } */

            /*var result =
                integers
                .Where((item) => item > 0)
                .Where((item) => item % 2 == 0)
                .ToList();*/
            /*var result =
                integers
                .Skip(1)
                .Take(2)
                .ToList();*/

            List<Person> people =
                new List<Person> {
                    new Person(){ Name = "John", LastName = "Doe", Age = 45 },
                    new Person(){ Name = "Sarah", LastName = "Connor", Age = 50 },
                    new Person(){ Name = "Vasilii", LastName = "Pupkin", Age = 20 }
                };

            /* var result =
                people
                .Select((p) => p.Name + " " + p.LastName)
                .ToList();
            result.ForEach(Console.WriteLine); */

            /*var result =
                people
                .Select((p) => new { p.Name, p.LastName })
                // .OrderBy((p) => p.Name)
                .OrderByDescending((p) => p.Name)
                .ToList();*/

            // result.ForEach(Console.WriteLine);
            /* result.ForEach((p) => {
                Console.WriteLine($"{p.Name} {p.LastName}");
            });*/

            /* var result =
                people
                .Where((p) => p.Name == "Yurii")
                //.Single();
                //.SingleOrDefault();
                //.First();
                .FirstOrDefault();*/

            var result =
                people
                .Zip(
                    new List<Double> { 15000, 10000, 30000 }
                    , (person, salary) => new { Name = person.Name, Salary = salary })
                    .ToList();

            //Console.WriteLine(result);
            result.ForEach(Console.WriteLine);
            // Console.WriteLine(result);
        }
    }
}
