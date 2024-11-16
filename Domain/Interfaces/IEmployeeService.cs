using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployeeAsync();//Es una firma de un método
        Task<Employee> GetEmployeeByIdAsync(Guid Id);
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task<Employee> EditEmployeeAsync(Employee employee);
        Task<Employee> DeleteEmployeeAsync(Guid Id);
    }
}
