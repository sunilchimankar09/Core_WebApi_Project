using WebApi_Test.Model;

namespace WebApi_Test.Repository
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
        Task<int> EmpSignupDetails(Emp_Signup emp);
    }
}
