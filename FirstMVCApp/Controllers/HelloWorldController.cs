using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //public String Index()
        //{
        //    return "This is Index page!";
        //}
        //public string Hello()
        //{
        //    return "Who is there?";
        //}
       private static List<DogViewModel> dogs= new List<DogViewModel>();
        public IActionResult Index()
        {
            //DogViewModel doggo =
            //    new DogViewModel() { Name = "Sif", Age = 2 };
            return View(dogs);
        }

        public IActionResult Hello()
        {
            DogViewModel doggo =
                new DogViewModel() { Name = "Lucky", Age = 4 };
            return View(doggo);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction("index");
           // return View("Index");
        }
    }
}
