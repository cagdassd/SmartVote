using Entities.Abstract;

namespace Entities.Concrete
{
    public class Election : IEntity
    {
        public int ElectionID { get; set; }
        public string ElectionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }

}
