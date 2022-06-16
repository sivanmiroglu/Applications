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

        [HttpGet]
        public IActionResult Update(int id)
        {
            var bookup = mvcDBContext.Books.FirstOrDefault(x => x.Id == id);
            return View(bookup);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            mvcDBContext.Update(book);
            mvcDBContext.SaveChanges();

            return RedirectToAction("BookListe");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bookdel = mvcDBContext.Books.FirstOrDefault(q => q.Id == id);
            mvcDBContext.Remove(bookdel);
            mvcDBContext.SaveChanges();

            return RedirectToAction("BookListe");
        }
    }
}
