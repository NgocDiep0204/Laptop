using api.Data;
using api.DTOs;
using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var allproducts = await _context.Products.ToListAsync();
            return Ok(allproducts);
        }

        /*[HttpPost]
        public async Task<IActionResult> AddProduct([FromBody]ProductDTO productDTO)
        {
            var newProduct = new Product
            {
                ProductId = Guid.NewGuid().ToString(),
                BrandId = productDTO.BrandId,
                ProductName = productDTO.ProductName,
                ProductDescription = productDTO.ProductDescription,
                ProductPrice = productDTO.ProductPrice,
                ProductImage = productDTO.ProductImage,
                Rom = productDTO.Rom,
                Ram = productDTO.Ram,
                Color = productDTO.Color,
                ScreenSize = productDTO.ScreenSize,
                Quantity = productDTO.Quantity,
                OperatingSystem = productDTO.OperatingSystem,
                HardWare = productDTO.HardWare,
                Battery = productDTO.Battery,
            };
            return Ok();
        }*/
    }
}
