using Microsoft.AspNetCore.Mvc;

using MVC.Models.ORM;

namespace MVC.Controllers
{
    public class ClientController : Controller
    {
        MvcDBContext mvcDBContext = new MvcDBContext();

        [HttpGet]
        public IActionResult Add()
        {
           

            return View();
        }


        [HttpPost]

        public IActionResult Add(Client client)
        {
            mvcDBContext.Add(client);
            mvcDBContext.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Liste()
        {
            List<Client> ClientList = mvcDBContext.Clients.ToList();

            return View(ClientList);

        }


    }
}
