using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ICandidateService _candidateService;
        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
