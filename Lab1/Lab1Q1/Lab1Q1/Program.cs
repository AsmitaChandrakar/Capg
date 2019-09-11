using System;
using Lab1Q1;


class Program
{
    static void Main()
    {
        //Employee employee = new Employee();
        //Console.WriteLine("Enter Employee Details");
        //Console.WriteLine("Enter Employee ID");
        //employee.EmployeeId = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Employee Name");
        //employee.EmployeeName = Console.ReadLine();
        //Console.WriteLine("Enter Employee Address");
        //employee.EmployeeAddress = Console.ReadLine();
        //Console.WriteLine("Enter Employee City");
        //employee.City = Console.ReadLine();
        //Console.WriteLine("Enter Employee Department");
        //employee.Department = Console.ReadLine();
        //Console.WriteLine("Enter Employee Salary");
        //employee.Salary = Convert.ToInt64(Console.ReadLine());

        Employee[] employees = new Employee[2];

        for (int i = 0; i <2; i++)
        {
            employees[i] = new Employee();
            Console.WriteLine("Enter details of " +i + " employee:(in order of name,ID,address,city,department,salary");
            employees[i].EmployeeName = Console.ReadLine();
            employees[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
            employees[i].EmployeeAddress = Console.ReadLine();
            employees[i].City = Console.ReadLine();
            employees[i].Department = Console.ReadLine();
            employees[i].Salary = Convert.ToInt64(Console.ReadLine());
        }
        //foreach(Employee e in employees)
        //{
        //    e = new Employee();
        //    e = Console.ReadLine();
        //}

        for (int i=0;i<2;i++)
        {
            
            Console.WriteLine(employees[i].EmployeeName);
            Console.WriteLine(employees[i].Salary);
        }


       
    }
}

