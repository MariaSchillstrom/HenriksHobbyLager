using HenriksHobbyLager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HenriksHobbyLager.Repositories
{
    public class ProductRepository
    {
        private object id;

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

        public IEnumerable<Product> Search(string searchTerm)
        {
            using (var context = new AppDbContext())
            {
                string lowerSearchTerm = searchTerm.ToLower(); // Konverterar söktermen till små bokstäver

                return context.Toys
                    .Where(p => p.Name.ToLower().Contains(lowerSearchTerm)) // Jämför med små bokstäver
                    .ToList(); // Konvertera till en lista för att returnera resultaten
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
                var product = context.Toys.FirstOrDefault(p => p.Id == id);
                if (product == null)
                {
                    Console.WriteLine($"Produkt med ID {id} hittades inte.");
                }
                else
                {
                    context.Toys.Remove(product);
                    context.SaveChanges();
                }
            }
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
