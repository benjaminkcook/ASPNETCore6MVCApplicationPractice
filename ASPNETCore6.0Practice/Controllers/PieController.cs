using ASPNETCore6._0Practice.Models;
using ASPNETCore6._0Practice.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore6._0Practice.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List() 
        {
            // passing data into the view

            /*ViewBag.CurrentCategory = "Cheese Cakes";
            return View(_pieRepository.AllPies);*/

            PieListViewModel piesListViewModel = new PieListViewModel
                (_pieRepository.AllPies, "Cheese Cakes");
            return View(piesListViewModel);
        }
    }
}
