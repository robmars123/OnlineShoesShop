using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoesShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DBContext _dal;
        public ProductsController(DBContext dal)
        {
            _dal = dal;
        }
        [HttpGet]
        public IEnumerable<Product> Index()
        {
            var products = _dal.Products.ToList();
            return products;
        }
    }
}
