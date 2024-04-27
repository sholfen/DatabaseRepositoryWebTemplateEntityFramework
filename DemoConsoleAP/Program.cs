
using DBLib.Models;
using DBLib.Repositories.Implements;
using DBLib.Tools;

//https://ithelp.ithome.com.tw/articles/10240862?sc=rss.iron

string connectioniStr = @"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Integrated Security=false;Trusted_Connection=true;";
DBTools.ConnectionString = connectioniStr;

EmployeeRepository employeeRepository = new EmployeeRepository();
List<Employee> list = employeeRepository.GetAll();
foreach (Employee emp in list)
{
    Console.WriteLine(emp.FirstName + " " + emp.LastName);
}

var e = employeeRepository.GetEmployee(30000);
Console.WriteLine();
if (e != null)
{
    Console.WriteLine(e.FirstName + " " + e.LastName);
}

e = employeeRepository.GetSingle(p => p?.EmployeeID == 1);
Console.WriteLine();
if (e != null)
{
    Console.WriteLine(e.FirstName + " " + e.LastName);
}