using Bogus;
using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Data
{
    public class DataSeeder(ProductContext context)
    {
        private readonly ProductContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public async Task SeedData()
        {
            // Asegurarse de que la base de datos existe
            await _context.Database.EnsureCreatedAsync();

            // Verificar si ya existen productos
            if (_context.Products != null && await _context.Products.AnyAsync())
            {
                return; // La base de datos ya tiene productos, no es necesario sembrar
            }

            var faker = new Faker<Product>()
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Price, f => decimal.Parse(f.Commerce.Price()))
                .RuleFor(p => p.ImageUrl, f => f.Image.PicsumUrl())
                .RuleFor(p => p.Quantity, f => f.Random.Number(1, 100));

            var products = faker.Generate(20); // Genera 20 productos de prueba

            if (_context.Products != null)
            {
                await _context.Products.AddRangeAsync(products);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Entity set 'ProductContext.Products' is null.");
            }
        }
    }
}

