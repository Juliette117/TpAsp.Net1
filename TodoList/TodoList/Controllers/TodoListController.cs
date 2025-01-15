using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TodoListController : Controller
    {
        private readonly TodoListDbContext _context;

        public TodoListController(TodoListDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tache tache)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tache);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tache);
        }
        // GET: TodoList
        public IActionResult Index()
        {
            ViewData["Message"] = "Liste";
            return View();
        }

        // GET: TodoList/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: TodoList/Create
        public IActionResult Formulaire()
        {
            return View();
        }

        // POST: TodoList/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: TodoList/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodoList/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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

        // GET: TodoList/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodoList/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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
