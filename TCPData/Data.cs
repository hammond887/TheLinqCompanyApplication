using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees() 
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee()
            {
                Id = 1,
                FirstName = "Test",
                LastName = "Testerson",
                AnnualSalary=4.4m,
                IsManager = true,
                DepartmentId=1
            };
            employees.Add(employee);
            employee = new Employee()
            {
                Id = 2,
                FirstName = "Testy",
                LastName = "Testersony",
                AnnualSalary=1.4m,
                IsManager = false,
                DepartmentId=2
            };
            employees.Add(employee);
            employee = new Employee()
            {
                Id = 3,
                FirstName = "Testo",
                LastName = "Testero",
                AnnualSalary=10.4m,
                IsManager = false,
                DepartmentId=3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments() 
        {
            List<Department> departments = new List<Department>();

            Department department = new Department()
            {
                Id = 1,
                LongName = "Testpartment",
                ShortName = "TP",
            };
            departments.Add(department);
            department = new Department()
            {
                Id = 2,
                LongName = "Testing",
                ShortName = "TE",
            };
            departments.Add(department);
            department = new Department()
            {
                Id = 3,
                LongName = "Testest",
                ShortName = "TS",
            };
            departments.Add(department);

            return departments;
        }
    }
}
