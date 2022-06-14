using Microsoft.AspNetCore.Mvc;

using MVC.Models.ORM;

namespace MVC.Controllers
{
    
    public class RestorantController : Controller
    {
        MvcDBContext mvcDBContext = new MvcDBContext();

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(Restorant restorant)
        {
            mvcDBContext.Add(restorant);
            mvcDBContext.SaveChanges();
            return View();

           return RedirectToAction("Liste");
        }

        public IActionResult Liste()
        {
            List<Restorant> restorants = mvcDBContext.Restorants.ToList();
            return View(restorants);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var resDel = mvcDBContext.Restorants.FirstOrDefault(q => q.Id == id);

            return View(resDel);
        }
        [HttpPost]
        public IActionResult Update(Restorant restorant)
        {
            mvcDBContext.Update(restorant);
            mvcDBContext.SaveChanges();

            return RedirectToAction("Liste");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var restorant = mvcDBContext.Restorants.FirstOrDefault(q => q.Id == id);
            mvcDBContext.Remove(restorant);
            mvcDBContext.SaveChanges();

            return RedirectToAction("Liste");
        }
  
    }
}
