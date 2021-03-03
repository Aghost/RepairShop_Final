using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepairMvc.Database;
using RepairMvc.Domain.Models;

namespace RepairMvc.Pages.Orders
{
    public class CreateInvoice : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateInvoice(ApplicationDbContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }
        public Product Product { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            /*
             * De data verwijzing naar de Products kan door de one to many relatie tussen Product, Productlist en repairorder kan niet
             * Deze moet volgensm mij via een nieuwe variabele Die ene Product Product op regel 23 en Product = await _contet op regel 38
             */
            Order = await _context.Orders.FirstOrDefaultAsync(m => m.OrderId == id);
            Product = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);

            // ~~~~~~ TEST ~~~~~~
            //var OrderProductsProducts = from o in OrderProducts where o.OrderId == Order.OrderId select o.Product;
            var OrderProductsProducts = from o in OrderProducts where o.OrderId == 1 select o.Product;

            if (Order == null)
            {
                return NotFound();
            }

            //~~~~~~~~ Get value van naam ~~~~~~~~
            var OrderProductID1 = Order.OrderId;
            var ProductID1 = (from p in _context.Products where p.ProductId == OrderProductID1 select p.Name).ToList();
            var ProductID1Price = (from p in _context.Products where p.ProductId == OrderProductID1 select p.Price).ToList();
            foreach (string str in ProductID1)
            {
                ViewData["ProductID1"] = str;
            }
            foreach (var str in ProductID1Price)
            {
                ViewData["ProductID1Price"] = str;
            }

            foreach (var product in OrderProductsProducts)
            {
                ViewData["ProductID1"] += product.Name;
            }
          
            return Page();
        }
    }
}
