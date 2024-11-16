using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IMotorcyclesService
    {
        Task<IEnumerable<Motorcycles>> GetMotorciclesAsync();//Es una firma de un método

        Task<Motorcycles> CreateMotorcyclesAsync(Motorcycles motorcycles);

        Task<Motorcycles> GetMotorcyclesByPlate(String plate);

        Task<Motorcycles> EditMotorcyclesAsync(String plate);

        Task<Motorcycles> DeleteMotorcyclesAsync(String plate);
    }
}
