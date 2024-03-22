using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Department
    {
        Employee[] Employees = new Employee[] {};

        public void AddEmployee( Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length +1);
            Employees[Employees.Length - 1] = employee;
        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        public void ShowEmployeeInfo() 
        {
            for ( int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($" Name: {Employees[i].Name} Surname: {Employees[i].Surname} Age: {Employees[i].Age} " +
                    $" Departmentname: {Employees[i].DepartmentName} Salary: {Employees[i].Salary}");
            }
            
        }
        public void GetAllEmployeesBySalary(int minSalary,int maxSalary)
        {
            for ( int i = 0;i < Employees.Length;i++)
            {
                if (minSalary < Employees[i].Salary  && maxSalary > Employees[i].Salary) 
                {
                    Console.WriteLine($" Name: {Employees[i].Name} Surname: {Employees[i].Surname} Age: {Employees[i].Age} " +
                    $" Departmentname: {Employees[i].DepartmentName} Salary: {Employees[i].Salary}");
                }
            }
            
        }
    }
}
