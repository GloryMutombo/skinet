using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase        
    {
      //Make sure to add these 3 followings lines//
      private readonly StoreContext _context;
      public ProductsController(StoreContext context)
      {
          this._context = context;
      }   

//Make sure to add these 3 followings lines//
     [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
           var products= await _context.Products.ToListAsync();
           return Ok(products);     
        }

         [HttpGet("{id}")]
        //Make sure to add these 3 followings lines//
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
           return await _context.Products.FindAsync(id);     
        }
    }
}