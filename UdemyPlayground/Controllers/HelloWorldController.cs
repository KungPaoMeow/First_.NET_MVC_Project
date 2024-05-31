using Microsoft.AspNetCore.Mvc;
using UdemyPlayground.Models;

namespace UdemyPlayground.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            //return View("Index");
            return RedirectToAction("Index");
        }

        public IActionResult Hello()
        {
            DogViewModel dog = new DogViewModel() { Name = "Doge", Age = 4 };
            return View(dog);
        }
    }
}
