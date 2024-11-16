using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IBuyService
    {
        Task<IEnumerable<Buy>> GetBuyAsync();//Es una firma de un método
        Task<Buy> GetBuyByIdAsync(Guid Id);
        Task<Buy> CreateBuyAsync(Buy buy);
        Task<Buy> EditBuyAsync(Buy buy);
        Task<Buy> DeleteBuyAsync(Guid Id);
    }
}
