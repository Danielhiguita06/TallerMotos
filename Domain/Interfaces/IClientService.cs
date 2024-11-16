using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetClientAsync();//Es una firma de un método
        Task<Client> GetClientByIdAsync(Guid Id);
        Task<Client> CreateClientAsync(Client client);
        Task<Client> EditClientAsync(Client client);
        Task<Client> DeleteClientAsync(Guid Id);
    }
}
