using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IServiceTypeService
    {
        Task<IEnumerable<ServiceType>> GetServiceTypeAsync();//Es una firma de un método
        Task<ServiceType> GetServiceTypeByIdAsync(Guid Id);
        Task<ServiceType> CreateServiceTypeAsync(ServiceType serviceType);
        Task<ServiceType> EditServiceTypeAsync(ServiceType serviceType);
        Task<ServiceType> DeleteServiceTypeAsync(Guid Id);
    }
}
