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
        private readonly IUserService _userService;
        public CandidatesController(ICandidateService candidateService, IElectionService electionService, IUserService userService)
        {
            _candidateService = candidateService;
            _electionService = electionService;
            _userService = userService;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Elections = await _electionService.GetElections();
            ViewBag.Users = await _userService.GetUsers();
            var candidates = await _candidateService.GetAll();
            return View(candidates);
        }
        [HttpPost]
        public async Task<IActionResult> AddCandidate(string candidateName, string candidateDescription, int electionId)
        {
            var candidate = new Candidate
            {
                CandidateName = candidateName,
                Description = candidateDescription,
                ElectionID = electionId,
                CreatedAt = DateTime.Now
            };

            await _candidateService.Add(candidate);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(string fullName, string email, string password, string role)
        {
            var user = new User
            {
                FullName = fullName,
                Email = email,
                PasswordHash = password, // Güvenlik için şifre hash'lenmelidir
                Role = role,
                IsActive = true,
                CreatedAt = DateTime.Now
            };

            await _userService.Add(user);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> AddElection(string electionName, string description, DateTime startDate, DateTime endDate)
        {
            var election = new Election
            {
                ElectionName = electionName,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                IsActive = true
            };

            await _electionService.Add(election);
            return RedirectToAction("Index");
        }
    }
}
