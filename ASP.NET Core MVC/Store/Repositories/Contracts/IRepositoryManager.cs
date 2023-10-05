using Repositories.Contracts;

namespace Entities.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product {get;}
        ICategoryRepository Category {get;}
        
        void Save();
    }
}