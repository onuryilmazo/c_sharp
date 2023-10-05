using Entities.Contracts;
using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository; //_ var sadece burda kullanmak için bir nesne oluşturduk
        private readonly ICategoryRepository _categoryRepository;
        public RepositoryManager(IProductRepository productRepository, RepositoryContext context, ICategoryRepository categoryRepository) //constructor injection mekanizması
        {
            _context = context;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}