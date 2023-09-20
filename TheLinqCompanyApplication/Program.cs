using TCPData;
using TCPExtensions;

List<Employee> employees = Data.GetEmployees();

var filteredEmployees = employees.Filter(e => e.IsManager);

foreach (var employee in filteredEmployees)
{
    Console.WriteLine("Managers = " + employee.FirstName);
}

//with linq

List<Department> departments = Data.GetDepartments();

var filteredDepartments = departments.Where(d => d.Id == 1);

Console.WriteLine(filteredDepartments.FirstOrDefault().LongName);

//join lists

var jointList = from emp in employees
                join dept in departments on emp.DepartmentId equals dept.Id
                select new
                {
                    FirstName = emp.FirstName,
                    Department = dept.LongName,
                    AnnualSalary = emp.AnnualSalary
                };

Console.WriteLine("joint " + jointList.FirstOrDefault().Department + jointList.FirstOrDefault().FirstName);

var heightsSalary = jointList.Max(s => s.AnnualSalary);