using System.Diagnostics;
using CaisseEnregistreuse.Models;
using CashRegister.Models;
using Microsoft.AspNetCore.Mvc;

namespace CashRegister.Controllers
{
    public class CashRegisterController : Controller
    {
        private readonly ILogger<CashRegisterController> _logger;

        public CashRegisterController(ILogger<CashRegisterController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var categorie = new Categorie
            {
                Id = 1,
                Name = "Decoration",
                Produits = new List<Produit> {
                    new Produit {Id = 1, Name = "Figurine", Price = 159.99m, Description = "Figurine", Quantity = 2 },
                    new Produit {Id = 1, Name = "Lampadaire", Price = 49.99m, Description = "Lampadaire", Quantity = 23 },
                }
            };
            return View();
        }

        public IActionResult GestionProduit()
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
