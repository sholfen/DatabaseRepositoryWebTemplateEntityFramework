using DBLib.Models;
using DBLib.Repositories.Implements;
using DBLib.Repositories.Interfaces;
using DBLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Services.Implements
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repository;

        public EmployeeService() 
        {
            _repository = new EmployeeRepository();
        }

        public List<Employee> GetMaleEmployees()
        {
            var list = _repository.GetList(e => e?.TitleOfCourtesy == "Mr.");
            return list.ToList();
        }
    }
}
