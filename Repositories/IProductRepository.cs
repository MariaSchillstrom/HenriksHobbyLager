namespace HenriksHobbyLager.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product updatedProduct);
        void Delete(int id);
    }
}

