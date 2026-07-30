using Microsoft.EntityFrameworkCore;
using WebApi_Test.DbContextData;
using WebApi_Test.Model;

namespace WebApi_Test.Repository
{
    public class EmployeeRepository : IEmployee
    {
       private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmployees()
        {

            var result = _context.Employess.FromSqlRaw("Employeedetails").ToList();
            return result;
        }
    }
}
