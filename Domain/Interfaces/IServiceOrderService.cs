using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IServiceOrderService
    {
        Task<IEnumerable<ServiceOrder>> GetServiceOrderAsync();//Es una firma de un método
        Task<ServiceOrder> GetServiceOrderByIdAsync(Guid Id);
        Task<Repair> CreateServiceOrderAsync(ServiceOrder serviceOrder);
        Task<ServiceOrder> EditServiceOrderAsync(ServiceOrder serviceOrder);
        Task<ServiceOrder> DeleteServiceOrderAsync(Guid Id);
    }
}
