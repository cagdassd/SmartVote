using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Candidate : IEntity
    {
        [Key]
        public int CandidateID { get; set; }
        public string? CandidateName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public int? ElectionID { get; set; }
        public Election? Election { get; set; }
    }

}
