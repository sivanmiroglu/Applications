using Microsoft.AspNetCore.Mvc;

using MVC.Models.ORM;

namespace MVC.Controllers
{
    public class BookController : Controller
    {
        MvcDBContext mvcDBContext = new MvcDBContext();

        [HttpGet]
        public IActionResult Add()
        {   
            return View();
        }

        [HttpPost]

        public IActionResult Add(Book book)
        {
            mvcDBContext.Add(book);
            mvcDBContext.SaveChanges();
            return View();
        }

        public IActionResult BookListe()
        {
            List<Book> Booklist = mvcDBContext.Books.ToList();

            return View(Booklist);
        }
    }
}
