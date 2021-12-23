using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DGTP.Models;
using System.IO;
using DGTP.Data;

namespace DGTP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var slidePath = $"{Directory.GetCurrentDirectory()}\\wwwroot\\assets\\images\\product\\large-size";
            var directoryInfo = new DirectoryInfo(slidePath);
            ViewBag.SwiperSlide = directoryInfo.GetFiles().Select(c => c.Name);
            var products = _context.Products.ToList().GroupBy(c => c.Category).ToDictionary(c => c.Key, c => c.ToList());
            ViewBag.Products = products;
            ViewBag.AllProducts = _context.Products.ToList();
            return View();
        }

        [Route("product")]
        [Route("san-pham")]
        public IActionResult Product()
        {
            ViewBag.Products = _context.Products.ToList();
            return View();
        }

        [Route("product/{alias}")]
        [Route("san-pham/{alias}")]
        public IActionResult ProductDetails(string alias)
        {
            ViewBag.ProductDetails = _context.Products.Where(c => c.Alias.Contains(alias)).FirstOrDefault();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
