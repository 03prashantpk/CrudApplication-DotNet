using CrudApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudApplication.Controllers
{
    public class CustomerRW : Controller
    {
            
        private readonly ApplicationDbContext _context;

        public CustomerRW ()
        {
            _context = new ApplicationDbContext ();
        }

        // GET: CustomerRW
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList ();
            return View(customers);
        }

        // GET: CustomerRW/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerRW/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerRW/Create
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

        // GET: CustomerRW/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerRW/Edit/5
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

        // GET: CustomerRW/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerRW/Delete/5
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
