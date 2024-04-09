using DemoGenerateursEtValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoGenerateursEtValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private IAutoRep _collectionAutos;
        private readonly IAutoRep _autoRepository;

        public HomeController(ILogger<HomeController> logger, IAutoRep autoRepository)
        {
            _logger = logger;
            _autoRepository = autoRepository; // Initialiser la liste d'auto
        }

        public IActionResult Index()
        {
            return View("Liste", _autoRepository.MesAuto); //Afficher la liste d'auto
        }

        public IActionResult Create()
        {
            return View("Ajouter"); //Afficher le formulaire
        }

        public IActionResult Ajouter(Auto auto)
        {
            if (ModelState.IsValid) // Si le modèle est valide, on affiche l'auto
            {
                _autoRepository.AddAuto(new Auto {Marque = auto.Marque, Model = auto.Model, Prix = auto.Prix });
                return View("Liste", _autoRepository.MesAuto);
                //return View("Auto", auto);
            }
            return View("Ajouter", auto); // Sinon on réaffiche le formulaire

        }

        public IActionResult Details(int id)
        {
            Auto auto = _autoRepository.GetAuto(id);
            return View("Auto", auto);
        }

        public IActionResult Delete(int id)
        {
            _autoRepository.SupprimerAuto(id);
            return View("Liste", _autoRepository.MesAuto);
        }

        public IActionResult Edit(Auto auto)
        {
            return View("Modifier", auto);
        }

        public IActionResult Modifier(Auto auto)
        {
            _autoRepository.ModifierAuto(auto);
            return View("Liste", _autoRepository.MesAuto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}