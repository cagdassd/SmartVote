using Entities.Concrete;

namespace WebUI.Models
{
    public class VoteViewModel
    {
        public int ElectionId { get; set; }
        public string ElectionName { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int SelectedCandidateId { get; set; }
    }
}
