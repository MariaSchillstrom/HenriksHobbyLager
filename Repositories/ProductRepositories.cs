using HenriksHobbyLager.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HenriksHobbyLager.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Toys.ToList(); // Hämtar alla produkter från databasen
            }
        }

        public Product GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Toys.FirstOrDefault(p => p.Id == id); // Hämtar produkt med specifikt ID
            }
        }

        public void Add(Product product)
        {
            using (var context = new AppDbContext())
            {
                product.Created = DateTime.Now; // Sätter skapelsedatum
                context.Toys.Add(product); // Lägger till produkten i databasen
                context.SaveChanges(); // Sparar ändringar i databasen
            }
        }

        public void Update(Product updatedProduct)
        {
            using (var context = new AppDbContext())
            {
                var product = context.Toys.FirstOrDefault(p => p.Id == updatedProduct.Id);
                if (product != null)
                {
                    product.Name = updatedProduct.Name;
                    product.Price = updatedProduct.Price;
                    product.Stock = updatedProduct.Stock;
                    product.Category = updatedProduct.Category;
                    product.Updated = DateTime.Now; // Uppdaterar tidstämpel

                    context.SaveChanges(); // Sparar ändringar
                }
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var product = context.Toys.FirstOrDefault(p => p.Id == id); // Söker efter produkten med ID
                if (product != null)
                {
                    context.Toys.Remove(product); // Tar bort produkten från databasen
                    context.SaveChanges(); // Sparar ändringarna
                }
            }
        }

        internal IEnumerable<Product> Search(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}

