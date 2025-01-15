using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class ContactController : Controller
    {
        // GET: HomeController1
        public IActionResult Index()
        {
            ViewData["Message"] = "Liste des contacts";

            List<Contact> contacts = new List<Contact>()
            {
                new Contact {Id = 1, Nom = "Mr", Prenom = "A"},
                 new Contact {Id = 1, Nom = "Mr", Prenom = "B"}

            };

           
            return View();
        }

        // GET: HomeController1/Details/5
        [Route("details/{id:int}")]
        public IActionResult Contact(int id)
        {
            var contact = new Contact
            {
                Id = 1,
                Nom = "Mr",
                Prenom = "A"
            };
            return View(contact);
        }

        // GET: HomeController1/Create
        [Route("ajouter")]
        public IActionResult AjouterContact()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
