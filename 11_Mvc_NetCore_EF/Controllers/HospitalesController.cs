using _11_Mvc_NetCore_EF.Models;
using _11_Mvc_NetCore_EF.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _11_Mvc_NetCore_EF.Controllers
{
    public class HospitalesController : Controller
    {

        private RepositoryHospital repo;

        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            return View(hospitales);
        }

        public IActionResult Details(int hospitalCod)
        {
            Hospital hospital = this.repo.FindHospital(hospitalCod);
            return View(hospital);
        }
    }
}
