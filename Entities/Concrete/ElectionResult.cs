using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class ElectionResult : IEntity
    {
        [Key]
        public int ElectionResultID { get; set; }
        public int TotalVotes { get; set; }

        public int ElectionID { get; set; }
        public Election Election { get; set; }

        public int CandidateID { get; set; }
        public Candidate Candidate { get; set; }
    }

}
