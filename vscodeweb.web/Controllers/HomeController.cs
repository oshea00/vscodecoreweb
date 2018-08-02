using System.Linq;
using vscodeweb.data.Models;
using vscodeweb.web.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace vscodeweb.web.Controllers
{
    public class HomeController : Controller {

        dataContext context;

        public HomeController(dataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["title"] = "Mike's Page";
            var model = new TodoVM { 
                Todos = context.Todos.ToList()
            };
            return View(model);
        }

    }
}