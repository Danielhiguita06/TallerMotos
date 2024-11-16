using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IMotorcyclesService
    {
        Task<IEnumerable<Motorcycles>> GetMotorciclesAsync();//Es una firma de un método
        Task<Motorcycles> GetMotorcyclesByIdAsync(Guid Id);
        Task<Motorcycles> CreateMotorcyclesAsync(Motorcycles motorcycles);
        Task<Motorcycles> EditMotorcyclesAsync(Motorcycles motorcycles);
        Task<Motorcycles> DeleteMotorcyclesAsync(Guid Id);
    }
}
