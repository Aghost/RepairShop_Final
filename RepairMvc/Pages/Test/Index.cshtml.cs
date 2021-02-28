using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepairMvc.Database;
using RepairMvc.Domain.Models;
using RepairMvc.Application.ProductsAdmin;

namespace RepairMvc.Pages.Test
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CreateProduct.ProductViewModel Product { get; set; }
        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = new GetProducts(_context).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_context).Do(Product);

            return RedirectToPage("Index");
        }

    }
}