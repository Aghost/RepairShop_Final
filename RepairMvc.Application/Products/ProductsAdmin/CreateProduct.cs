using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RepairMvc.Database;
using RepairMvc.Domain.Models;

namespace RepairMvc.Application.ProductsAdmin
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;
        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel vm)
        {
            _context.Products.Add(new Product
            {
                ProductId = vm.ProductId,
                Name = vm.Name,
                PartType = vm.PartType,
                Description = vm.Description,
                Price = vm.Price
            });

            await _context.SaveChangesAsync();
        }

        public class ProductViewModel
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public PartType PartType { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
}
