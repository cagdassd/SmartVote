using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Vote : IEntity
    {
        [Key]
        public int VoteID { get; set; }
        public DateTime VoteDate { get; set; } = DateTime.Now;
        public string BlockchainTransactionID { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int ElectionID { get; set; }
        public Election Election { get; set; }
    }

}
