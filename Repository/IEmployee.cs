using WebApi_Test.Model;

namespace WebApi_Test.Repository
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
    }
}
