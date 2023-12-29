using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        public static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers DONE
            Console.WriteLine($"Sum of numbers: {numbers.Sum()}");

            //TODO: Print the Average of numbers DONE
            Console.WriteLine($"\n\nAverage of numbers: {numbers.Average()}");
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console DONE
            var ascOrder = numbers.OrderBy(item => item);
            foreach (int num in ascOrder)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console DONE
            var descOrder = numbers.OrderByDescending(item => item).ToList();
            foreach (int num in descOrder)
            {
                Console.WriteLine($"{num}");
            }

            //TODO: Print to the console only the numbers greater than 6 DONE
            Console.WriteLine();

            foreach (int num in numbers)
            {
                if (num > 6)
                {
                    Console.WriteLine($"{num}");
                }
                
            }
                    Console.WriteLine();


            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!** DONE

            foreach (int num in descOrder.Take(4))
            {

                Console.WriteLine($"{num}");

            }
                Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order DONE

            descOrder[4] = 25;
            foreach (int num in descOrder)
            {
                Console.WriteLine($"{num}");
            }

            Console.WriteLine();


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var cOrSFName = employees.Where(name => name.FirstName.StartsWith("S") || name.FirstName.StartsWith("C")).OrderBy(name => name.FirstName).ToList();
            foreach (var employee in cOrSFName)
            {
                Console.WriteLine($"{employee.FullName}");
            }

            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result. DONE 
            var age26Up = employees.Where(item => item.Age > 26).OrderBy(item => item.Age).ThenBy(item => item.FirstName);
            Console.WriteLine("Employees over age 26:");
            foreach (var employee in age26Up)
            {
                Console.WriteLine($"{employee.FullName}");
            }

            Console.WriteLine();

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35. DONE
            var newList = employees.Where(item => item.Age > 35).Where(item => item.YearsOfExperience <= 10);
            int sumOfYOE = newList.Sum(item => item.YearsOfExperience);
            Console.WriteLine($"The sum of the employees' years of experience if their YOE is less than or equal to 10 AND Age is greater than 35 is : {sumOfYOE}");
            Console.WriteLine();

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35. DONE
            double averageYOE = newList.Average(item => item.YearsOfExperience);
            Console.WriteLine($"The Average of the employees' years of experience if their YOE is less than or equal to 10 AND Age is greater than 35 is : {averageYOE}");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()  DONE
            Employee employee1 = new Employee("Herby", "Hertilien", 25, 7);
            employees = employees.Append(employee1).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName}");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
