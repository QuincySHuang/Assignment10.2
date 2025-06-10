namespace Assignment10._2
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            var positiveNumbers = from num in numbers
                                      where num > 0
                                      select num;
            Console.WriteLine("The positive numbers are: ");
            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Alice", Age = 30, Salary = 5000 },
                new Employee { Name = "Bob", Age = 25, Salary = 6000 },
                new Employee { Name = "Charlie", Age = 35, Salary = 7000 }
            };
            var thirtyPlusHighEarners = from e in employees
                                              where e.Age > 30 && e.Salary > 5000
                                              select e;
            Console.WriteLine("Employees aged 31 or older with a salary greater than 5000:");
            foreach (var e in thirtyPlusHighEarners)
            {
                Console.WriteLine($"Name: {e.Name}, Age: {e.Age}, Salary: {e.Salary}");
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            Console.Write("enter starting letter of city: ");
            char startingLetter = Console.ReadLine().ToUpper()[0];
            Console.Write("enter ending letter of city: ");
            char endingLetter = Console.ReadLine().ToUpper()[0];

            var filteredCities = from c in cities
                                 where c.StartsWith(startingLetter) && c.EndsWith(endingLetter)
                                 select c;

            Console.WriteLine($"Cities starting with '{startingLetter}' and ending with '{endingLetter}':");
            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            List<int> greaterEighty = new List<int> { 55, 200, 740, 76, 230, 482, 95 };
            Console.WriteLine("The numbers of the list are: ");
            foreach (var number in greaterEighty)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            var greaterThanEighty = from num in greaterEighty
                                    where num > 80
                                    select num;
            Console.WriteLine("The numbers greater than 80 are: ");
            foreach (var num in greaterThanEighty)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
