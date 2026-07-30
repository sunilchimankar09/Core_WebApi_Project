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

            var result = _context.Employess.FromSqlRaw("EXEC  Employeedetails").ToList();
            return result;
        }

        public async Task<int> EmpSignupDetails(Emp_Signup emp)
        {
            return await _context.Database.ExecuteSqlRawAsync("EXEC EmployeeSignup @Fname={0},@Lname={1},@Email={2},@Mobile={3},@Password={4},@Gender={5},@DOB={6},@City={7}",
                emp.FName,emp.Lname,emp.Email,emp.Mobile,emp.Password,emp.Gender,emp.DOB,emp.City);
        }
    }
}
