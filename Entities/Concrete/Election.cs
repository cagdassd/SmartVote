using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Election : IEntity
    {
        [Key]
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
