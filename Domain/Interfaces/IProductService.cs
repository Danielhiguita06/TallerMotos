using TallerMotos.DAL.Entities;

namespace TallerMotos.Domain.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductAsync();//Es una firma de un método
        Task<Product> GetProductByIdAsync(Guid Id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> EditProductAsync(Product product);
        Task<Product> DeleteProductAsync(Guid Id);
    }
}
