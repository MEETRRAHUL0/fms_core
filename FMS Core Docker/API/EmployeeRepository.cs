using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS_Core.Models.EFModels;
using Microsoft.EntityFrameworkCore;

namespace FMS_Core.API
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FMSExpContext _context;
        public EmployeeRepository(FMSExpContext context)
        {
            _context = context;
        }

        public Task<List<Employee>> GetEmployees()
        {
            return _context.Employee.ToListAsync();
        }

        public Task<Employee> GetEmployeeById(long id)
        {
            return _context.Employee.SingleAsync(a => a.Id == id);
        }
    }
}
