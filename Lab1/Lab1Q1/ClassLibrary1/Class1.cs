
using System;


namespace Lab1Q1
{
   public class Employee
    {
        private int _employeeId;
        private string _employeeName;
        private string _employeeAddress;
        private string _city;
        private string _department;
        private double _salary;

        public int EmployeeId
        {
            set
            {
                if (value.ToString().Length <= 10)
                    _employeeId = value;
                else Console.WriteLine("Limit exceeded");


            }
            get
            {
                return _employeeId;
            }
        }
        public string EmployeeName
        {
            set
            {
                if (value.Length <= 30)
                    _employeeName = value;
                else Console.WriteLine("Limit exceeded");


            }
            get
            {
                return _employeeName;
            }
        }
        public string EmployeeAddress
        {
            set
            {
                if (value.Length <= 100)
                    _employeeAddress = value;
                else Console.WriteLine("Limit exceeded");


            }
            get
            {
                return _employeeAddress;
            }
        }
        public string City
        {
            set
            {
                if (value.Length <= 20)
                    _city = value;
                else Console.WriteLine("Limit exceeded");


            }
            get
            {
                return _city;
            }
        }
        public string Department
        {
            set
            {
                if (value.Length <= 30)
                    _department = value;
                else Console.WriteLine("Limit exceeded");


            }
            get
            {
                return _department;
            }
        }
        public double Salary
        {
            set
            {
                if (value.ToString().Length <= 10)
                    _salary = value;
                else Console.WriteLine("Limit exceeded");


            }
            get
            {
                return _salary;
            }
        }


    }
}

