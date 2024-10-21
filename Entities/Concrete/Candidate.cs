using Entities.Abstract;

namespace Entities.Concrete
{
    public class Candidate : IEntity
    {
        public int CandidateID { get; set; }
        public string CandidateName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int ElectionID { get; set; }
        public Election Election { get; set; }
    }

}
