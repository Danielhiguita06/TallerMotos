using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IRepairService
    {
        Task<IEnumerable<Repair>> GetRepairAsync();//Es una firma de un método
        Task<Repair> GetRepairByIdAsync(Guid Id);
        Task<Repair> CreateRepairAsync(Repair repair);
        Task<Repair> EditRepairAsync(Repair repair);
        Task<Repair> DeleteRepairAsync(Guid Id);
    }
}
