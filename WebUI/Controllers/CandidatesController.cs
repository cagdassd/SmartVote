using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ICandidateService _candidateService;
        private readonly IElectionService _electionService;
        public CandidatesController(ICandidateService candidateService, IElectionService electionService)
        {
            _candidateService = candidateService;
            _electionService = electionService;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Elections = await _electionService.GetElections();
            return View(await _candidateService.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> AddCandidate(string candidateName, string candidateDescription)
        {
            var candidate = new Candidate()
            {
                CandidateName=candidateName,
                Description = candidateDescription,
                ElectionID = 1
            };
            await _candidateService.Add(candidate);
            return RedirectToAction("Index", "Candidates");
        }
    }
}
