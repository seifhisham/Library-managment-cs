using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDBContext _db;

        public BooksController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> objBooksList = _db.books;
            return View(objBooksList);
        }

        //create view GET
        public IActionResult Create()
        {
            return View();
        }

        //create POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book obj)
        {
            if (ModelState.IsValid) {
                _db.books.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0) {
                return NotFound();
            }
            var BooksFromDB = _db.books.Find(id);

            if(BooksFromDB == null) {
                return NotFound();
            }
            return View(BooksFromDB);
        }

        //create POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book obj)
        {
            if (ModelState.IsValid)
            {
                _db.books.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}