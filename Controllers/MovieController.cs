using System;
using Microsoft.AspNetCore.Mvc;

namespace C42MVC02DEMO.Controllers
{
    public class MovieController : Controller
    {
        [ActionName("hhhhhh")]
        public IActionResult GetMovie() //action is must me public & non static
        {
            //ContentResult result = new ContentResult();
            //result.Content=$"Movie With Id ={id}";
            //result.StatusCode = 200;
            //return result;
            return Content($"Movie With "); // helper method from controllerbase
        }
        // public IActionResult Index()
        //{
        //    return View();
        //} 

        // public IActionResult Hamada()
        //{
        //return Redirect("Url");
        //return RedirectToAction(nameof(GetMovie), new { id = 10 });
        //return RedirectToRoute("Default", new { Controller = "Movie", action = "GetMovie", id = 10 });        }
        //}
    }
}
