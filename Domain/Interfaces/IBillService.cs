using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IBillService
    {
        Task<IEnumerable<Bill>> GetBillAsync();//Es una firma de un método
        Task<Bill> GetBillByIdAsync(Guid Id);
        Task<Bill> CreateBillAsync(Bill bill);
        Task<Bill> EditBillAsync(Bill bill);
        Task<Bill> DeleteBillAsync(Guid Id);
    }
}
