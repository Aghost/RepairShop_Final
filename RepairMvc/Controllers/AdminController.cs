using Microsoft.AspNetCore.Mvc;
using RepairMvc.Application.ProductsAdmin;
using RepairMvc.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepairMvc.Controllers
{
    [Route("[controller]")] // /admin/products
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(_context).Do());

        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(_context).Do(id));

        [HttpPost("products")]
        public IActionResult CreateProduct([FromBody]CreateProduct.ProductViewModel vm) => Ok(new CreateProduct(_context).Do(vm));

        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct(int id) => Ok(new DeleteProduct(_context).Do(id));

        [HttpPut("products")]
        public IActionResult UpdateProduct([FromBody]UpdateProduct.ProductViewModel vm) => Ok(new UpdateProduct(_context).Do(vm));
    }
}
