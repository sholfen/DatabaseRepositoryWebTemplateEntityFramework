using DBLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetMaleEmployees();
    }
}
