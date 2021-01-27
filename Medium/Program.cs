using System;
using System.Collections.Generic;

namespace Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            //Employee emp = new Employee();
            List<Employee>emp = new List<Employee>();
            Dictionary<int, List<Employee>>Employee = new Dictionary<int, List<Employee>>();
            {
                do
                {
                    emp.Add(new Medium.Employee());
                    Console.WriteLine("Please enter the employee Id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the employee name");
                    string name = Console.ReadLine();
                    // empList.Add(name);

                    Console.WriteLine("Please enter the employee age");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the employee salary");
                    int salary = (int)float.Parse(Console.ReadLine());

                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    a = Convert.ToInt32(Console.ReadLine());

                    // Employee.Add(id, name););

                }
                while (a != 0);

                Console.WriteLine("Please enter the employee Id");
                int userId = Convert.ToInt32(Console.ReadLine());



                Dictionary<int, string> dictionaryEmployees = empList.ToDictionary(x => x.Id);

                foreach (KeyValuePair<int, Employee> keyValuePairEmployees in dictionaryEmployees)
                {
                    if (keyValuePairEmployees.Key == employeeId)
                    {
                        Console.WriteLine("Key = {0}", keyValuePairEmployees.Key);
                        Employee emp1 = keyValuePairEmployees.Value;
                        Console.WriteLine("Employee ID: {0}\n Name : {1}\n Age : {2}\n Salary : {3}",
                                       emp1.Id, emp1.Name, emp1.Age, emp1.Salary);
                    }

                }
                Console.ReadKey();



            }



        }

    }
        
}