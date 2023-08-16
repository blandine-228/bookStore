using DineBookStore.Models.Domain;
using DineBookStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DineBookStore.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService service;
        public GenreController(IGenreService service)
        {
            this.service = service;
            
        }

        public IActionResult Add()
        {
            return View();
        }


        //add method
        [HttpPost]
        public IActionResult Add(Genre model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Add(model);
            if (result)
            {
                TempData["msg"] = "Added successfulley";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error";
            return View(model);
        }


        //update

        public IActionResult Update(int id)
        {
            var record = service.FindById(id);
            return View(record);
        }


       
        [HttpPost]
        public IActionResult Update(Genre model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = service.Update(model);
            if (result)
            {
                TempData["msg"] = "Added successfulley";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error";
            return View(model);
        }

        //delete


        public IActionResult Delete(int id)
        {
            var result = service.Delete(id);
          
            return RedirectToAction("GetAll");
      
        }


        //GEt ALl
        public IActionResult GetAll()
        {
            var data = service.GetAll();

            return View(data);

        }
    }
}

